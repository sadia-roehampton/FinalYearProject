using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FYP_Appointment_Management.Data;
using FYP_Appointment_Management.Models;

namespace FYP_Appointment_Management.Pages.Staff_pages
{
    public class CreateModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.Staff_appointmentsContext _context;

        public CreateModel(FYP_Appointment_Management.Data.Staff_appointmentsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Staff_appointments Staff_appointments { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Staffs_appointments.Add(Staff_appointments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
