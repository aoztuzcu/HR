using HR.Application.Contracts.Persistence.Repositories;
using HR.Application.Contracts.Persistence.Repositories.Base;
using HR.Application.Contracts.Persistence.Services;
using HR.Infrastructure.Persistence;
using HR.Persistence.Repositories;
using HR.Persistence.Repositories.Base;
using HR.Persistence.Services;
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
        services.AddScoped<IPersonnelRepository, PersonnelRepository>();
        services.AddScoped<IJobRepository, JobRepository>();    
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IPermissionRequestRepository, PermissionRequestRepository>();
        services.AddScoped<IExpenditureRepository, ExpenditureRepository>();
        services.AddScoped<IExpenditureTypeRepository, ExpenditureTypeRepository>();
        services.AddScoped<IPermissionRequestRepository,PermissionRequestRepository>();
        services.AddScoped<IPermissionTypeRepository, PermissionTypeRepository>();
        services.AddScoped<IAdvancePaymentRepository, AdvancePaymentRepository>();
        services.AddScoped<ICurrencyService, CurrencyService>();
        return services;
    }
}
