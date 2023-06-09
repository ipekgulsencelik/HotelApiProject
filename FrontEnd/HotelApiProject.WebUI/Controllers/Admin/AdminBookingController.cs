﻿using HotelApiProject.WebUI.DTOs.BookingDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelApiProject.WebUI.Controllers.Admin
{
    public class AdminBookingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        
        public AdminBookingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5000/api/Booking");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookingDTO>>(jsonData);

                return View(values);
            }
            
            return View();
        }

        public async Task<IActionResult> ApprovedReservation(ResultBookingDTO resultBookingDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(resultBookingDTO);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5000/api/Booking/UpdateBookingStatus", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            
            return View();
        }
    }
}
