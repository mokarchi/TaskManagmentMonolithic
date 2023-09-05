using TaskManagment.Domain.Data;

namespace TaskManagment.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<Domain.Models.User>, IUserRepository
    {
        public UserRepository()
        {

        }
    }
}
