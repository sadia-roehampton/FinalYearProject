using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FYP_Appointment_Management.Models
{
    public class Staff
    {
        [Key]
        public int Staff_Id { get; set; }
        public string Staff_First_Name { get; set; }
        public string Staff_Last_Name { get; set; }
        public string Staff_Role { get; set; }
        public string Staff_Email { get; set; }
      
    }
}
