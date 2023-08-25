using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Data;

namespace TaskManagment.Infrastructure.Data.Repositories
{
    public class ProjectRepository : Repository<Domain.Models.Project>, IProjectRepository
    {
        public Task<IEnumerable<Domain.Models.Project>> GetListByOrganizationIdAsync(string organizationId)
        {
            throw new NotImplementedException();
        }
    }
}
