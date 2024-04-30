using FYP_Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace FYP_Appointment_Management.Data
{
    public class PatientContext : DbContext
    {        
        public PatientContext(DbContextOptions<PatientContext> options) : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
    }
}
