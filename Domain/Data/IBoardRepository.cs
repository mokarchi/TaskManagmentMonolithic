using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Core.Data;

namespace TaskManagment.Domain.Data
{
    public interface IBoardRepository : IRepository<Models.Board>
    {
        Task<IEnumerable<Models.Board>> GetListByBoardIdAsync(string boardId);
    }
}
