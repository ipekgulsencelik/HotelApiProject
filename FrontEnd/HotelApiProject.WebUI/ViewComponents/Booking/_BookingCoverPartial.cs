using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents.Booking
{
    public class _BookingCoverPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
