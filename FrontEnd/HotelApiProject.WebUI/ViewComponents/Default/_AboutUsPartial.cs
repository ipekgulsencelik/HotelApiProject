using HotelApiProject.WebUI.DTOs.AboutDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelApiProject.WebUI.ViewComponents.Default
{
    public class _AboutUsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        
        public _AboutUsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5000/api/About");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDTO>>(jsonData);
            
                return View(values);
            }

            return View();
        }
    }
}