using System.Linq.Expressions;

namespace Furniro.Application.Common.Interfaces.Persistance;

public interface IRepository<TEntity> where TEntity : class
{
    Task  CreateAsync(TEntity item);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity> GetByIdAsync(Guid id);
    Task UpdateAsync(TEntity item);
    Task DeleteByIdAsync(Guid id);
}