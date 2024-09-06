using Furniro.Application.Common.Interfaces.Persistance;
using Furniro.Application.Common.Interfaces.Persistance.Abstaction;
using Furniro.Infrastructure.Peristance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Furniro.Infrastructure;

public class DependencyInjectionContainer
{
    public static IServiceCollection ConfigureServices()
    {
        var services = new ServiceCollection();

        services.AddDbContext<FurniroDbContext>(options =>
        {
            options.UseSqlServer("postgresql://postgres:qnWkPdDiXMklLzUEyUybNrZkZPolVrnM@autorack.proxy.rlwy.net:38574/railway");

        });

        services.AddTransient<IProductRepository, ProductRepository>();
        services.AddTransient<ICategoryRepository, CategoryRepository>();

        return services;
    }

    public static IServiceProvider BuildServiceProvider(IServiceCollection services)
    {
        return services.BuildServiceProvider();
    }
}   