using FYP_Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace FYP_Appointment_Management.Data
{
    public class Staff_appointmentsContext : DbContext
    {
        public Staff_appointmentsContext(DbContextOptions<Staff_appointmentsContext> options) : base(options)
        {
        }       
        public DbSet<Staff_appointments> Staffs_appointments { get; set; }
    }
}
