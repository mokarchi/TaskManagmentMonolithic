using TaskManagment.Domain.Core.Enums;
using TaskManagment.Domain.Core.Models;

namespace TaskManagment.Domain.Models
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; }
        public string BoardId { get; set; }
    }
}
