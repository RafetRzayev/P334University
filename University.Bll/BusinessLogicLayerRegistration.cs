using Microsoft.Extensions.DependencyInjection;
using University.Bll.Services.Contracts;
using University.Bll.Services;

namespace University.Bll;

public static class BusinessLogicLayerRegistration
{
    public static IServiceCollection AddBllServices(this IServiceCollection services)
    {
        services.AddScoped<IStudentService, StudentManager>();

        return services;
    }
}
