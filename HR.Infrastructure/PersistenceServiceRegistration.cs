using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories;
using HR.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HR.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<HRContext>(
            opt => opt.UseSqlServer(configuration.GetConnectionString("cstring"))
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IJobRepository, JobRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        return services;
    }
}
