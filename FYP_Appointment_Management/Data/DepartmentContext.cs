using FYP_Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace FYP_Appointment_Management.Data
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options)
        {
        }
        public DbSet<Department> departments { get; set; }
    }
}
