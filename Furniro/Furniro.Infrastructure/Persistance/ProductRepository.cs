using Furniro.Application.Common.Interfaces.Persistance;
using Furniro.Application.Common.Interfaces.Persistance.Abstaction;
using Furniro.Domain.Aggregates;
using Furniro.Domain.Enteties;
using Furniro.Infrastructure.Persistance.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq.Expressions;

namespace Furniro.Infrastructure.Peristance;

public class ProductRepository : IProductRepository
{
    private readonly IRepository<Product> _repository;

    public ProductRepository(IRepository<Product> repository)

    {
        _repository = repository;
    }

    public async Task CreateAsync(Product product)
    {
        await _repository.CreateAsync(product);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        await _repository.DeleteByIdAsync(id);
    }

    public async Task<List<byte[]>> GetAdditionalPhotoAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product.AdditionalPhotos.ToList() ?? new List<byte[]>();
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public Task<IEnumerable<Product>> GetAsync(Expression<Func<Product, bool>> predicate)
    {
        return _repository.GetAsync(predicate);
    }

    public async Task<Product> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Category> GetCategoryAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.Category;
    }

    public async Task<byte[]> GetCoverPhotoAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.CoverPhoto;
    }

    public async Task<DateTime> GetCreationDateAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.CreationDate ?? DateTime.MinValue;
    }

    public async Task<string> GetDescriptionAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.Description;
    }

    public async Task<int> GetDiscountAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.Discount ?? 0;
    }

    public async Task<DateTime> GetLastUpdateDateAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.LastUpdatedDate ?? DateTime.MinValue;
    }

    public async Task<bool> GetMarkAsNewAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.MarkAsNew ?? false;
    }

    public async Task<string> GetNameAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.Name;
    }

    public async Task<decimal> GetPriceAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.Price ?? 0;
    }

    public async Task<int> GetQualityAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.Quality ?? 0;
    }

    public async Task<string> GetShrotDesciptionAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.ShortDescription;
    }

    public async Task<List<string>> GetSizesAsync(Guid id)
    {
        var product = await _repository.GetByIdAsync(id);
        return product?.Sizes.ToList() ?? new List<string>();
    }

    public async Task UpdateAsync(Product product)
    {
        await _repository.UpdateAsync(product);
    }
}