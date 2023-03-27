using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
