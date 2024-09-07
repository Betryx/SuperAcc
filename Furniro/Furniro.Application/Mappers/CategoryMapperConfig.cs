using Furniro.Application.DTOs.CategoryDTOs;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furniro.Domain.Aggregates;

namespace Furniro.Application.Mappers
{
    public class CategoryMapperConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<Category, CategoryResponceDto>
                .NewConfig()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.CoverPhoto, src => src.CoverPhoto)
                .Map(dest => dest.Products, src => src.Products);

            TypeAdapterConfig<CategoryResponceDto, Category>
                .NewConfig()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.CoverPhoto, src => src.CoverPhoto);
        }
    }
}
