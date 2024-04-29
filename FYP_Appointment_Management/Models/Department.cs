using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
