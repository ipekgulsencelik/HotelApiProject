﻿using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebUI.ViewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
