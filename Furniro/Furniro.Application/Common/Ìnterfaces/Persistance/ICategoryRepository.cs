using System.Drawing;
using System.Linq.Expressions;
using Furniro.Application.DTOs.CategoryDTOs;
using Furniro.Application.DTOs.ProductDTOs;
using Furniro.Domain.Aggregates;
using Furniro.Domain.Enteties;

namespace Furniro.Application.Common.Interfaces.Persistance;

public interface ICategoryRepository
{
    Task CreateAsync(CategoryRequestDto item);
    Task<IEnumerable<CategoryResponceDto>> GetAllAsync();
    Task<CategoryResponceDto> GetByIdAsync(Guid id);
    Task UpdateAsync(CategoryRequestDto item);
    Task DeleteByIdAsync(Guid id);
    Task<string> GetNameAsync(Guid id);
    Task<Image> GetCoverImageAsync(Guid id);
    Task<ICollection<ProductResponceDto>> GetProductsInCategoryAsync(Guid id);
}