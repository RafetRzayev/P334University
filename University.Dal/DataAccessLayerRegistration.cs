using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using University.Dal.DataContext;
using University.Dal.Repositories;
using University.Dal.Repositories.Contracts;

namespace University.Dal;

public static class DataAccessLayerRegistration
{
    public static IServiceCollection AddDalServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));
        services.AddScoped<IStudentRepository, StudentRepository>();

        return services;
    }
}
