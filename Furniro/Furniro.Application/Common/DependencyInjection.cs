using Furniro.Application.Common.Interfaces.Persistance.Abstaction;
using Furniro.Application.Common.Interfaces.Persistance;
using Microsoft.Extensions.DependencyInjection;
using Furniro.Application.Mappers;
using MapsterMapper;
using Mapster;

namespace Furniro.Application.Common;

public static class DependencyInjectionContainer
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var config = new TypeAdapterConfig();
        services.AddSingleton<IMapper>(new Mapper(config));

        CategoryMapperConfig.RegisterMappings();
        ProductMapperConfig.RegisterMappings();

        return services;
    }
}   