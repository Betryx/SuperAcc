using Furniro.Application.Common.Interfaces.Persistance;
using Furniro.Domain.Aggregates;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq.Expressions;

namespace Furniro.Infrastructure.Peristance;

public class CategoryRepository : ICategoryRepository
{
    private readonly IRepository<Category> _repository;

    public CategoryRepository(IRepository<Category> repository)
    {
        _repository = repository;

    }

    public async Task CreateAsync(Category category)
    {
        await _repository.CreateAsync(category);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<IEnumerable<Category>> GetAsync(Expression<Func<Category, bool>> predicate)
    {
        return await _repository.GetAsync(predicate);
    }

    public async Task<Category> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
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

    public Task<ICollection<Product>> GetProductsInCategoryAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(Category category)
    {
        await _repository.UpdateAsync(category);
    }
}