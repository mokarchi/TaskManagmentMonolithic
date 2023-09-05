using TaskManagment.Domain.Core.Models;

namespace TaskManagment.Domain.Models
{
    public class Organization : BaseEntity
    {
        public Organization(string name, string description, string userId)
        {
            Name = name;
            Description = description;
            UserId = userId;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
    }
}
