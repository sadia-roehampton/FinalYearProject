using FYP_Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace FYP_Appointment_Management.Data
{
    public class StaffContext : DbContext
    {        
        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {
        }
        public DbSet<Staff> Staffs { get; set; }
    }
}
