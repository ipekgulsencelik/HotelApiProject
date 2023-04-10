using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageFileController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Images/" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);

            return Created("", file);
        }
    }
}
