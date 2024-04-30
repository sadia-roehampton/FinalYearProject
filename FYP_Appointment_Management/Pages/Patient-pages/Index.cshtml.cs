using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FYP_Appointment_Management.Data;
using FYP_Appointment_Management.Models;

namespace FYP_Appointment_Management.Pages.Patient_pages
{
    public class IndexModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.Patient_appointmentsContext _context;

        public IndexModel(FYP_Appointment_Management.Data.Patient_appointmentsContext context)
        {
            _context = context;
        }

        public IList<Patient_appointments> Patients_appointments { get;set; } = default!;

        //public async Task OnGetAsync()
        //{
        //    Patients_appointments = await _context.Patients_appointments.ToListAsync();
        //}

        public IActionResult OnGet()
        {
            // Retrieve appointments from the database
            Patients_appointments = _context.Patients_appointments.ToList();
            return Page();
        }

        public IActionResult confirmAppointment(int Patient_appointmentsId)
        {
            // Logic to confirm the appointment
            return RedirectToPage("/Patient-pages/Patient_appointments");
        }

        public IActionResult rescheduleAppointment(int Patient_appointmentsId)
        {
            // Logic to reschedule the appointment
            return RedirectToPage("/Patient-pages/Patient_appointments");
        }

        public IActionResult cancelAppointment(int Patient_appointmentsId)
        {
            // Logic to cancel the appointment
            return RedirectToPage("/Patient-pages/Patient_appointments");
        }
    }
}
