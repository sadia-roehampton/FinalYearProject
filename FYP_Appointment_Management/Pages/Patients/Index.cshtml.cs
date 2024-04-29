using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FYP_Appointment_Management.Data;
using FYP_Appointment_Management.Models;

namespace FYP_Appointment_Management.Pages.Patients
{
    public class IndexModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.FYP_Appointment_ManagementContext _context;

        public IndexModel(FYP_Appointment_Management.Data.FYP_Appointment_ManagementContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Patient = await _context.Patient.ToListAsync();
        }
    }
}
