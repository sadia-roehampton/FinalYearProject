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
    public class DetailsModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.FYP_Appointment_ManagementContext _context;

        public DetailsModel(FYP_Appointment_Management.Data.FYP_Appointment_ManagementContext context)
        {
            _context = context;
        }

        public Staff_appointments Staff_appointments { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff_appointments = await _context.Staff_appointments.FirstOrDefaultAsync(m => m.Id == id);
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
    }
}
