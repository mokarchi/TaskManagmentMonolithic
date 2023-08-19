using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Core.Models;

namespace TaskManagment.Domain.Core.Data
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(string id);
        Task<TEntity> GetByIdAsync(string id);
        Task<IEnumerable<TEntity>> GetListAsync();
    }
}
