using Application.Services;
using Application.Contracts;
using Domain.Contracts;
using Infra.Data.Repository;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {

        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        return services;
    }
}