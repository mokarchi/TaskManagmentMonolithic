using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using TaskManagment.Infrastructure.Data.DbContext;

namespace TaskManagment.Infrastructure.Data.DataProviders
{
    public static class DbContextSeedData
    {

        public static void SeedDatabase(this IServiceScopeFactory scopeFactory)
        {
            using (var serviceScope = scopeFactory.CreateScope())
            {
                string adminRoleId = string.Empty;
                var dbContext = serviceScope.ServiceProvider.GetService<IMongoDbContext>();
                var _tasks = dbContext.GetCollection<Task>();

                //TODO: seed user,organization,project,board

                #region Tasks
                if (!_tasks.AsQueryable().Any())
                {
                    //var role = new Task
                    //{
                    //    Title = "test title",
                    //    Description = "test Description",
                    //    State=TaskState.ToDo,
                    //    BoardId="GET FROM SEEDED BOARD",
                    //};
                    //_tasks.InsertOne(role);
                }
                #endregion

            }
        }
    }
}
