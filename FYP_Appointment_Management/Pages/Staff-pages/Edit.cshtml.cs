using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FYP_Appointment_Management.Data;
using FYP_Appointment_Management.Models;

namespace FYP_Appointment_Management.Pages.Staff_pages
{
    public class EditModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.Staff_appointmentsContext _context;

        public EditModel(FYP_Appointment_Management.Data.Staff_appointmentsContext context)
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

            var staff_appointments =  await _context.Staffs_appointments.FirstOrDefaultAsync(m => m.Id == id);
            if (staff_appointments == null)
            {
                return NotFound();
            }
            Staff_appointments = staff_appointments;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Staff_appointments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Staff_appointmentsExists(Staff_appointments.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Staff_appointmentsExists(int id)
        {
            return _context.Staffs_appointments.Any(e => e.Id == id);
        }
    }
}
