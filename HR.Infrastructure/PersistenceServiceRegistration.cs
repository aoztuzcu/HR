using HR.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Persistence;

public static class PersistenceServiceRegistration
{

    public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HRContext>(
            opt => opt.UseSqlServer(configuration.GetConnectionString("cstring"))
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

        //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        //services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
