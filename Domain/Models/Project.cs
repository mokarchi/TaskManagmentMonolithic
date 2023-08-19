using TaskManagment.Domain.Core.Models;

namespace TaskManagment.Domain.Models
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrganizationId { get; set; }
    }
}
