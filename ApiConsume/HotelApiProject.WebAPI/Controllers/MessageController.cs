using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult messageList()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddMessage(Message message)
        {
            _messageService.TInsert(message);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var values = _messageService.TGetByID(id);
            _messageService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSendMessage(Message message)
        {
            _messageService.TUpdate(message);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var values = _messageService.TGetByID(id);
            return Ok(values);
        }
        
        [HttpGet("GetMessageCount")]
        public IActionResult GetMessageCount()
        {
            return Ok(_messageService.TGetMessageCount());
        }
    }
}
