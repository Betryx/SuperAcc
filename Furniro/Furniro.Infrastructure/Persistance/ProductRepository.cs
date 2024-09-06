using Furniro.Application.Common.Interfaces.Persistance.Abstaction;
using Furniro.Domain.Aggregates;
using Furniro.Domain.Enteties;
using System.Drawing;

namespace Furniro.Infrastructure.Peristance;

public class ProductRepository : IProductRepository
{
    public Task CreateAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Image>> GetAdditionalPhotoAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetCategoryAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Image> GetCoverPhotoAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<DateTime> GetCreationDateAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetDescriptionAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetDiscountAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<DateTime> GetLastUpdateDateAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> GetMarkAsNewAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetNameAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<decimal> GetPriceAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetQualityAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetShrotDesciptionAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<string>> GetSizesAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }
}