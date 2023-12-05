using HR.Application;
using HR.Domain.Concrete.Identity;
using HR.Domain.Concrete.Identity.Role;
using HR.Infrastructure.Persistence;
using HR.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Globalization;

namespace HR.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddApplicationService();
            builder.Services.AddPersistenceService(builder.Configuration);

            builder.Services.AddIdentity<User, UserRole>(x =>
            {
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;
            })
           .AddEntityFrameworkStores<HRContext>();

            // CurrencyService
            builder.Services.AddHttpClient();

            var app = builder.Build();

            // View'den Ondalýklý Deðer dönebilmesi için gerekli kod bloðu
            app.Use(async (context, next) =>
            {
                var currentThreadCulture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
                currentThreadCulture.NumberFormat = NumberFormatInfo.InvariantInfo;
                Thread.CurrentThread.CurrentCulture = currentThreadCulture;
                Thread.CurrentThread.CurrentUICulture = currentThreadCulture;
                await next();
            });

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();




            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                  //name: "areaDefault",
                  name: "Personnel",
                  areaName: "Personnel",
                  pattern: "Personnel/{controller=Person}/{action=Index}"
                //pattern: "{area:exists}/{controller=Person}/{action=Index}/{id?}"
                ); ;



                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Login1}/{id?}");
            });
            app.Run();
        }
    }
}