using Microsoft.Extensions.DependencyInjection;

namespace Furniro.Application.Common;

public class DependencyInjectionContainer
{
    public static IServiceCollection ConfigureServices()
    {
        var services = new ServiceCollection();

        return services;
    }

    public static IServiceProvider BuildServiceProvider(IServiceCollection services)
    {
        return services.BuildServiceProvider();
    }
}   