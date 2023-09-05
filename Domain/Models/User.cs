using TaskManagment.Domain.Core.Models;

namespace TaskManagment.Domain.Models
{
    public class User : ApplicationUser
    {
        public User()
        {

        }

        public string DisplayName { get; set; }
    }
}
