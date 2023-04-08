using Domain.Base;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrustracture.Data.Repositories
{
    public class Repository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _dbSet;

        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public Task<T> Delete(T entity)
        {
            _dbSet.Remove(entity);

            return Task.FromResult(entity);

        }

        public async Task<T> Get(int id)
        {
            return await _dbSet.FirstAsync(c => c.Id == id);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public Task<T> Update(T entity)
        {
            _dbSet.Update(entity);
            return Task.FromResult(entity);
        }


    }
}
