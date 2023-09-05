using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Core.Data;

namespace TaskManagment.Domain.Data
{
    public interface IProjectRepository : IRepository<Models.Project>
    {
        Task<IEnumerable<Models.Project>> GetListByOrganizationIdAsync(string organizationId);
    }
}
