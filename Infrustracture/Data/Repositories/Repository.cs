using Domain.Base;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrustracture.Data.Repositories
{
    public class Repository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly EFContext _context;


        public Repository(EFContext context)
        {
            _context = context;

        }

        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);

            _context.SaveChanges();
            
            
            return entity;
        }

        public Task<T> Delete(T entity)
        {
            _context.Set<T>().Remove(entity);

            _context.SaveChanges();


            return Task.FromResult(entity);

        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FirstAsync(c => c.Id == id);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);

            _context.SaveChanges();

            return Task.FromResult(entity);
        }


    }
}
