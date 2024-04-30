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
    public class DeleteModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.Staff_appointmentsContext _context;

        public DeleteModel(FYP_Appointment_Management.Data.Staff_appointmentsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Staff_appointments Staff_appointments { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff_appointments = await _context.Staffs_appointments.FirstOrDefaultAsync(m => m.Id == id);

            if (staff_appointments == null)
            {
                return NotFound();
            }
            else
            {
                Staff_appointments = staff_appointments;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff_appointments = await _context.Staffs_appointments.FindAsync(id);
            if (staff_appointments != null)
            {
                Staff_appointments = staff_appointments;
                _context.Staffs_appointments.Remove(Staff_appointments);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
