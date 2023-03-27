using AutoMapper;
using HotelApiProject.EntityLayer.Concrete;
using HotelApiProject.WebUI.DTOs.AboutDTO;
using HotelApiProject.WebUI.DTOs.LoginDTO;
using HotelApiProject.WebUI.DTOs.RegisterDTO;
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

            CreateMap<CreateNewUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO, AppUser>().ReverseMap();

            CreateMap<ResultAboutDTO, About>().ReverseMap();
            CreateMap<UpdateAboutDTO, About>().ReverseMap();
        }
    }
}
