using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Data;
using TaskManagment.Domain.Models;

namespace TaskManagment.Infrastructure.Data.Repositories
{
    public class OrganizationRepository : Repository<Organization>, IOrganizationRepository
    {
        public Task<IEnumerable<Organization>> GetListByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
