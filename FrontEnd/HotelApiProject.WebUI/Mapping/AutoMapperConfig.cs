using AutoMapper;
using HotelApiProject.EntityLayer.Concrete;
using HotelApiProject.WebUI.DTOs.AboutDTO;
using HotelApiProject.WebUI.DTOs.BookingDTO;
using HotelApiProject.WebUI.DTOs.GuestDTO;
using HotelApiProject.WebUI.DTOs.LoginDTO;
using HotelApiProject.WebUI.DTOs.RegisterDTO;
using HotelApiProject.WebUI.DTOs.ServiceDTO;
using HotelApiProject.WebUI.DTOs.StaffDTO;
using HotelApiProject.WebUI.DTOs.SubscribeDTO;
using HotelApiProject.WebUI.DTOs.TestimonialDTO;

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

            CreateMap<ResultTestimonialDTO, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDTO, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDTO, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDTO, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDTO, Booking>().ReverseMap();

            CreateMap<CreateGuestDTO, Guest>().ReverseMap();
            CreateMap<UpdateGuestDTO, Guest>().ReverseMap();
        }
    }
}
