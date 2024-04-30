using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FYP_Appointment_Management.Data;
using FYP_Appointment_Management.Models;

namespace FYP_Appointment_Management.Pages.Staff_pages
{
    public class IndexModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.Staff_appointmentsContext _context;

        public IndexModel(FYP_Appointment_Management.Data.Staff_appointmentsContext context)
        {
            _context = context;
        }

        public IList<Staff_appointmentsContext> Staffs_appointments { get; set; } = default!;

        //public async Task OnGetAsync()
        //{
        //    Staff_appointmentsContext = await _context.Staffs_appointmentsContext.ToListAsync();
        //}

        public IActionResult OnGet()
        {
            // Retrieve appointments from the database
            Staffs_appointments = (IList<Staff_appointmentsContext>)_context.Staffs_appointments.ToList();
            return Page();
        }

        public IActionResult confirmAppointment(int Staffs_appointmentsId)
        {
            // Logic to confirm the appointment
            return RedirectToPage("/Staff-pages/my_consultations");
        }

        public IActionResult rescheduleAppointment(int Staffs_appointmentsId)
        {
            // Logic to reschedule the appointment
            return RedirectToPage("/Staff-pages/my_consultations");
        }

        public IActionResult cancelAppointment(int Staffs_appointmentsId)
        {
            // Logic to cancel the appointment
            return RedirectToPage("/Staff-pages/my_consultations");
        }
    }
}