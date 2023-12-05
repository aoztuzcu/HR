using HR.Persistence;
using HR.Application;
using HR.Domain.Concrete.User.Role;
using HR.Infrastructure.Persistence;
using HR.Domain.Concrete;
using HR.Domain.Concrete.User;
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

            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
               //endpoints.MapControllerRoute(
               //name: "default",
               //pattern: "{controller=Login}/{action=Login1}/{id?}");

                endpoints.MapAreaControllerRoute(
                  name: "areaDefault",
                  areaName: "Personnel",
                  pattern: "{area:exists}/{controller=Person}/{action=Index}/{id?}"
                ); ;

               
            });

            app.Run();
        }
    }
}