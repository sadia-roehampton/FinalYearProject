using System.ComponentModel.DataAnnotations;
namespace FYP_Appointment_Management.Models
{
    public class Staff_appointments
    {   
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Patient_Name { get; set; }
        public string Status { get; set; }
        public string Actions { get; set; }
    }
}

    