using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Core.Data;

namespace TaskManagment.Domain.Data
{
    public interface ITaskRepository : IRepository<Models.Task>
    {
        Task<IEnumerable<Task>> GetListByBoardIdAsync(string boardId);
    }
}
