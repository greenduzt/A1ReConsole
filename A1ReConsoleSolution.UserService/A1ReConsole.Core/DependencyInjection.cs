using Microsoft.Extensions.DependencyInjection;
namespace A1ReConsole.Core;

public static class DependencyInjection
{
    // Extension method to add core services to the dependency injection container
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}
