using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
