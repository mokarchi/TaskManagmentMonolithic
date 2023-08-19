using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Core.Data;
using TaskManagment.Domain.Core.Models;

namespace TaskManagment.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public Repository()
        {

        }
        public Task CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //   Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
