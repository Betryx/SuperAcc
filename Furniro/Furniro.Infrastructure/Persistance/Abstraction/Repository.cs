using Furniro.Application.Common.Interfaces.Persistance;
using Furniro.Domain.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Furniro.Infrastructure.Persistance.Abstraction
{
    public class Repository<T> : IRepository<T> where T : BaseClass
    {
        private readonly FurniroDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(FurniroDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task CreateAsync(T item)
        {
            await _dbSet.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(Guid id)
        {
            var item = await GetByIdAsync(id);
            if (item != null)
            {
                _dbSet.Remove(item);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException($"Item does not exist! (ID: {id}");
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _dbSet.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
