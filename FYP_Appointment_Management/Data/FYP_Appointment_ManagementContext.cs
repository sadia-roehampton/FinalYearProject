using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FYP_Appointment_Management.Models;

namespace FYP_Appointment_Management.Data
{
    public class FYP_Appointment_ManagementContext : DbContext
    {
        public FYP_Appointment_ManagementContext (DbContextOptions<FYP_Appointment_ManagementContext> options)
            : base(options)
        {
        }

        public DbSet<FYP_Appointment_Management.Models.Patient_appointments> Patient_appointments { get; set; } = default!;
        public DbSet<FYP_Appointment_Management.Models.Staff_appointments> Staff_appointments { get; set; } = default!;
    }
}
