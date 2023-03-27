using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
