using Furniro.Domain.Common.Models;
using System.Buffers.Text;
using System.Linq.Expressions;

namespace Furniro.Application.Common.Interfaces.Persistance;

public interface IRepository<T> where T : BaseClass
{
    Task  CreateAsync(T item);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task UpdateAsync(T item);
    Task DeleteByIdAsync(Guid id);
}