using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessingFileController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadFile([FromForm] IFormFile file)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Files/" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);

            return Created("", file);
        }
    }
}
