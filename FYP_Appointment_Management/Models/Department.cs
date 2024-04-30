using System.ComponentModel.DataAnnotations;
namespace FYP_Appointment_Management.Models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        public int Dept_phone { get; set; }

    }
}
