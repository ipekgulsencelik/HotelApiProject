using HotelApiProject.WebUI.DTOs.ContactDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace HotelApiProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            //var responseMessage = await client.GetAsync("http://localhost:3523/api/MessageCategory");

            //var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //var values = JsonConvert.DeserializeObject<List<ResultMessageCategoryDTO>>(jsonData);
            //List<SelectListItem> values2 = (from x in values
            //                                select new SelectListItem
            //                                {
            //                                    Text = x.MessageCategoryName,
            //                                    Value = x.MessageCategoryID.ToString()
            //                                }).ToList();
            //ViewBag.v = values2;

            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateContactDTO createContactDTO)
        {
            createContactDTO.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDTO);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            await client.PostAsync("http://localhost:5000/api/Contact", stringContent);
            
            return RedirectToAction("Index", "Default");
        }
    }
}