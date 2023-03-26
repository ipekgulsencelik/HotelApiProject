using AutoMapper;
using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataTransferObjectLayer.DTOs.RoomDTO;
using HotelApiProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelApiProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomApiController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        
        public RoomApiController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        
        [HttpPost]
        public IActionResult AddRoom(RoomAddDTO roomAddDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = _mapper.Map<Room>(roomAddDTO);
            _roomService.TInsert(values);
            
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDTO updateRoomDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            
            var values = _mapper.Map<Room>(updateRoomDTO);
            _roomService.TUpdate(values);
            
            return Ok("Successfully Updated");
        }
    }
}
