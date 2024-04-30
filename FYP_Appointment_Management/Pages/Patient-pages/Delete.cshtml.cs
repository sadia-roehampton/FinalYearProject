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
    public class DeleteModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.Patient_appointmentsContext _context;

        public DeleteModel(FYP_Appointment_Management.Data.Patient_appointmentsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Patient_appointments Patient_appointments { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient_appointments = await _context.Patients_appointments.FirstOrDefaultAsync(m => m.Id == id);

            if (patient_appointments == null)
            {
                return NotFound();
            }
            else
            {
                Patient_appointments = patient_appointments;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient_appointments = await _context.Patients_appointments.FindAsync(id);
            if (patient_appointments != null)
            {
                Patient_appointments = patient_appointments;
                _context.Patients_appointments.Remove(Patient_appointments);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
