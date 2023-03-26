using AutoMapper;
using HotelApiProject.DataTransferObjectLayer.DTOs.RoomDTO;
using HotelApiProject.EntityLayer.Concrete;

namespace HotelApiProject.WebAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDTO, Room>();
            CreateMap<Room, RoomAddDTO>();

            CreateMap<UpdateRoomDTO, Room>().ReverseMap();
        }
    }
}
