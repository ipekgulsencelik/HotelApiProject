using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.BusinessLayer.Concrete;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Concrete;
using HotelApiProject.DataAccessLayer.Concrete.EntityFramework;

namespace HotelApiProject.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<Context>();

            builder.Services.AddScoped<IRoomDAL, EFRoomDAL>();
            builder.Services.AddScoped<IRoomService, RoomManager>();

            builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();
            builder.Services.AddScoped<IServiceService, ServiceManager>();

            builder.Services.AddScoped<IStaffDAL, EFStaffDAL>();
            builder.Services.AddScoped<IStaffService, StaffManager>();

            builder.Services.AddScoped<ISubscribeDAL, EFSubscribeDAL>();
            builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

            builder.Services.AddScoped<ITestimonialDAL, EFTestimonialDAL>();
            builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}