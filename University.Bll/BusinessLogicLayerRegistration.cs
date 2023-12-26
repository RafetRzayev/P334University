using Microsoft.Extensions.DependencyInjection;
using University.Bll.Services.Contracts;
using University.Bll.Services;
using System.Reflection;

namespace University.Bll;

public static class BusinessLogicLayerRegistration
{
    public static IServiceCollection AddBllServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(ICrudService<,,,>), typeof(CrudManager<,,,>));
        services.AddScoped<IStudentService, StudentManager>();
        services.AddScoped<IDepartmentService, DepartmentManager>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}
