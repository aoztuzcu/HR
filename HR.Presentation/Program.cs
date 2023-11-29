using HR.Persistence;
using HR.Application;

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

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                  name: "areaDefault",
                  areaName: "Personnel",
                  pattern: "{area:exists}/{controller=Person}/{action=Index}/{id?}"
                ); ;

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Person}/{action=Index}/{id?}");
            });

            app.Run();
        }
    }
}