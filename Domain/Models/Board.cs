using TaskManagment.Domain.Core.Models;

namespace TaskManagment.Domain.Models
{
    public class Board : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProjectId { get; set; }
    }
}
