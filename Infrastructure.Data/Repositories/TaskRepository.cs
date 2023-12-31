﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskManagment.Domain.Data;

namespace TaskManagment.Infrastructure.Data.Repositories
{
    public class TaskRepository : Repository<Domain.Models.Task>, ITaskRepository
    {
        public Task<IEnumerable<Domain.Models.Task>> GetListByBoardIdAsync(string boardId)
        {
            throw new NotImplementedException();
        }
    }
}
