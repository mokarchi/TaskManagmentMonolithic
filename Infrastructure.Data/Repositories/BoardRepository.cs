using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Data;
using TaskManagment.Domain.Models;

namespace TaskManagment.Infrastructure.Data.Repositories
{
    public class BoardRepository : Repository<Domain.Models.Board>, IBoardRepository
    {
        public Task<IEnumerable<Board>> GetListByBoardIdAsync(string boardId)
        {
            throw new NotImplementedException();
        }
    }
}
