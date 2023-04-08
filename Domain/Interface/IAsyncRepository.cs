using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IAsyncRepository<T> where T : BaseEntity
    { 
 
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();

        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(T entity);


    }
}
