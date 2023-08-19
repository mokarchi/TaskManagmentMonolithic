using TaskManagment.Domain.Core.Models;

namespace TaskManagment.Domain.Models
{
    public class Organization : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
