using System.Drawing;
using Furniro.Domain.Aggregates;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace Furniro.Application.Common.Interfaces.Peristance;

public interface ICategoryRepository : IRepository<Category>
{
    Task<string> GetNameAsync();
    Task<Image> GetCoverImageAsync();
    Task<ICollection<Product>> GetProductsInCategoryAsync();
}