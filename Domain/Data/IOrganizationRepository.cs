using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Core.Data;

namespace TaskManagment.Domain.Data
{
    public interface IOrganizationRepository : IRepository<Models.Organization>
    {
        Task<IEnumerable<Models.Organization>> GetListByUserIdAsync(string userId);
    }
}
