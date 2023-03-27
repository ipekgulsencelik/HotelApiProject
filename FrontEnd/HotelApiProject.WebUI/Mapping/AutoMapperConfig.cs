using AutoMapper;
using HotelApiProject.EntityLayer.Concrete;
using HotelApiProject.WebUI.DTOs.ServiceDTO;

namespace HotelApiProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDTO, Service>().ReverseMap();
            CreateMap<UpdateServiceDTO, Service>().ReverseMap();
            CreateMap<CreateServiceDTO, Service>().ReverseMap();
        }
    }
}
