using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents.Default
{
    public class _AboutUsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
