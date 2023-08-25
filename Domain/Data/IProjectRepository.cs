using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Core.Data;
using TaskManagment.Domain.Models;

namespace TaskManagment.Domain.Data
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<IEnumerable<Project>> GetListByOrganizationIdAsync(string organizationId);
    }
}
