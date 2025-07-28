using Microsoft.Extensions.DependencyInjection;
namespace A1ReConsole.Infrastructure;

public static class DependencyInjection
{
    // Extension method to add infrastructure services to the dependency injection container
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
