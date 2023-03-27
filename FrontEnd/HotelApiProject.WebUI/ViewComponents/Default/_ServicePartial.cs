using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents.Default
{
    public class _ServicePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
