using Furniro.Application.Common.Interfaces.Persistance;
using Furniro.Application.DTOs.CategoryDTOs;
using Furniro.Application.DTOs.ProductDTOs;
using Furniro.Domain.Aggregates;
using MapsterMapper;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq.Expressions;

namespace Furniro.Infrastructure.Peristance;

public class CategoryRepository : ICategoryRepository
{
    private readonly IRepository<Category> _repository;
    private readonly IMapper _mapper;

    public CategoryRepository(IRepository<Category> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task CreateAsync(CategoryRequestDto category)
    {
        var item = _mapper.Map<Category>(category);

        await _repository.CreateAsync(item);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public async Task<IEnumerable<CategoryResponceDto>> GetAllAsync()
    {
        var list = await _repository.GetAllAsync();

        return _mapper.Map<List<CategoryResponceDto>>(list);
    }

    public async Task<CategoryResponceDto> GetByIdAsync(Guid id)
    {
        var item = await _repository.GetByIdAsync(id);
        return _mapper.Map<CategoryResponceDto>(item);
    }

    public async Task<Image> GetCoverImageAsync(Guid id)
    {
        // Implement logic to retrieve the cover image for the category
        // This might involve accessing the category's `CoverPhoto` property or fetching the image from an external source
        throw new NotImplementedException();
    }

    public async Task<string> GetNameAsync(Guid id)
    {
        var category = await _repository.GetByIdAsync(id);
        return category?.Name;
    }

    public Task<ICollection<ProductResponceDto>> GetProductsInCategoryAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(CategoryRequestDto category)
    {
        var item = _mapper.Map<Category>(category);
        await _repository.UpdateAsync(item);
    }
}