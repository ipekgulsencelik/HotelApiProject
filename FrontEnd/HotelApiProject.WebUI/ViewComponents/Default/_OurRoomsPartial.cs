using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents.Default
{
    public class _OurRoomsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
