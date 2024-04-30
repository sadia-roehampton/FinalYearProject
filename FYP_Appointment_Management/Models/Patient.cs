using System.ComponentModel.DataAnnotations;
namespace FYP_Appointment_Management.Models
{
    public class Patient
    {
        [Key]
        public int Patient_Id { get; set; }
        public string Patient_First_Name { get; set; }
        public string Patient_Last_Name { get; set; }
        public string Patient_Gender { get; set; }
        public DateOnly Patient_DOB { get; set; }
        public int Patient_Phone { get; set; }
        public string Patient_Email { get; set; }     

    }
}
