using FluentValidation;
using FluentValidation.AspNetCore;
using HotelApiProject.DataAccessLayer.Concrete;
using HotelApiProject.EntityLayer.Concrete;
using HotelApiProject.WebUI.DTOs.GuestDTO;
using HotelApiProject.WebUI.ValidationRules.GuestValidationRules;

namespace HotelApiProject.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<Context>();
            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
            builder.Services.AddHttpClient();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddTransient<IValidator<CreateGuestDTO>, CreateGuestValidator>();
            builder.Services.AddTransient<IValidator<UpdateGuestDTO>, UpdateGuestValidator>();

            builder.Services.AddControllersWithViews().AddFluentValidation(); 

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}