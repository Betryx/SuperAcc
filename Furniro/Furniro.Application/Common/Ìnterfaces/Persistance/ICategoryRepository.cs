using System.Drawing;
using Furniro.Domain.Aggregates;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace Furniro.Application.Common.Interfaces.Persistance;

public interface ICategoryRepository : IRepository<Category>
{
    Task<string> GetNameAsync(Guid id);
    Task<Image> GetCoverImageAsync(Guid id);
    Task<ICollection<Product>> GetProductsInCategoryAsync(Guid id);
}