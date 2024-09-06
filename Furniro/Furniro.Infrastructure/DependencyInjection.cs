using Furniro.Application.Common.Interfaces.Persistance;
using Furniro.Application.Common.Interfaces.Persistance.Abstaction;
using Furniro.Infrastructure.Peristance;
using Furniro.Infrastructure.Persistance.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Furniro.Infrastructure;

public static class DependencyInjectionContainer
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        services.AddDbContext<FurniroDbContext>(options =>
                options.UseSqlServer(connectionString));
  
        return services;
    }
}   