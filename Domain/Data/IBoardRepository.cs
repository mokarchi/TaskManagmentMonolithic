using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Core.Data;
using TaskManagment.Domain.Models;

namespace TaskManagment.Domain.Data
{
    public interface IBoardRepository : IRepository<Board>
    {
        Task<IEnumerable<Board>> GetListByBoardIdAsync(string boardId);
    }
}
