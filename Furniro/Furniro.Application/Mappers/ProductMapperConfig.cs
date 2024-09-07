using Furniro.Application.DTOs.CategoryDTOs;
using Furniro.Application.DTOs.ProductDTOs;
using Furniro.Domain.Enteties;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniro.Application.Mappers
{
    public class ProductMapperConfig
    {
        public static void RegisterMappings()
        {
            TypeAdapterConfig<ProductRequestDto, Product>
                .NewConfig()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.ShortDescription, src => src.ShortDescription)
                .Map(dest => dest.Description, src => src.Description)
                .Map(dest => dest.Price, src => src.Price)
                .Map(dest => dest.Discount, src => src.Discount)
                .Map(dest => dest.Quality, src => src.Quality)
                .Map(dest => dest.MarkAsNew, src => src.MarkAsNew)
                .Map(dest => dest.FileName, src => src.FileName)
                .Map(dest => dest.CoverPhoto, src => src.CoverPhoto)
                .Map(dest => dest.AdditionalPhotos, src => src.AdditionalPhotos)
                .Map(dest => dest.Sizes, src => src.Sizes)
                .Map(dest => dest.Colors, src => src.Colors)
                .Map(dest => dest.CategoryId, src => src.CategoryId);

            TypeAdapterConfig<Product, ProductResponceDto>
                .NewConfig()
                .Map(dest => dest.Name, src => src.Name)
                .Map(dest => dest.ShortDescription, src => src.ShortDescription)
                .Map(dest => dest.Description, src => src.Description)
                .Map(dest => dest.Price, src => src.Price)
                .Map(dest => dest.Discount, src => src.Discount)
                .Map(dest => dest.Quality, src => src.Quality)
                .Map(dest => dest.MarkAsNew, src => src.MarkAsNew)
                .Map(dest => dest.CoverPhoto, src => src.CoverPhoto)
                .Map(dest => dest.AdditionalPhotos, src => src.AdditionalPhotos)
                .Map(dest => dest.Sizes, src => src.Sizes)
                .Map(dest => dest.Colors, src => src.Colors)
                .Map(dest => dest.CategoryId, src => src.CategoryId);
        }
    }
}