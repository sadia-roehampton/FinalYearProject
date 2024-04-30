using FYP_Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace FYP_Appointment_Management.Data
{
    public class Patient_appointmentsContext : DbContext
    {
        public Patient_appointmentsContext(DbContextOptions<Patient_appointmentsContext> options) : base(options)
        {
        }
        public DbSet<Patient_appointments> Patients_appointments { get; set; }
    }
}