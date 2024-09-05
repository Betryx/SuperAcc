using System.Drawing;
using Furniro.Domain.Enteties;
using Furniro.Domain.Aggregates;

namespace Furniro.Application.Common.Interfaces.Peristance.Abstaction;

public interface IProductRepository : IRepository<Product>
{
    Task<DateTime> GetCreationDateAsync(Guid id);
    Task<DateTime> GetLastUpdateDateAsync(Guid id);
    Task<String> GetNameAsync(Guid id);
    Task<String> GetShrotDesciptionAsync(Guid id);
    Task<String> GetDescriptionAsync(Guid id);
    Task<Decimal> GetPriceAsync(Guid id);
    Task<int> GetDiscountAsync(Guid id);
    Task<int> GetQualityAsync(Guid id);
    Task<bool> GetMarkAsNewAsync(Guid id);
    Task<Image> GetCoverPhotoAsync(Guid id);
    Task<List<Image>> GetAdditionalPhotoAsync(Guid id);
    Task<List<string>> GetSizesAsync(Guid id);
    Task<Category> GetCategoryAsync();

}