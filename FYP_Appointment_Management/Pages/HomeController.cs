using Microsoft.AspNetCore.Mvc;

namespace FYP_Appointment_Management.Pages
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
