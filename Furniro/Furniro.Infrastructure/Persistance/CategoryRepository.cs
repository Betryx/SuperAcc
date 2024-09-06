using Furniro.Application.Common.Interfaces.Persistance;
using Furniro.Domain.Aggregates;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System.Drawing;

namespace Furniro.Infrastructure.Peristance;

public class CategoryRepository : ICategoryRepository
{
    public Task CreateAsync(Category entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Category>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Image> GetCoverImageAsync()
    {
        throw new NotImplementedException();
    }

    public Task<string> GetNameAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Product>> GetProductsInCategoryAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Category entity)
    {
        throw new NotImplementedException();
    }
}