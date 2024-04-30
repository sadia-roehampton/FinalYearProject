using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FYP_Appointment_Management.Data;
using FYP_Appointment_Management.Models;

namespace FYP_Appointment_Management.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly FYP_Appointment_Management.Data.StaffContext _context;

        public IndexModel(FYP_Appointment_Management.Data.StaffContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Staff = await _context.Staffs.ToListAsync();
        }
    }
}
