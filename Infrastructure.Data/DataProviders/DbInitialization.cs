﻿using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using TaskManagment.Domain.Core.Extensions;
using TaskManagment.Domain.Core.Models;
using TaskManagment.Domain.Models;
using TaskManagment.Infrastructure.Data.DbContext;

namespace TaskManagment.Infrastructure.Data.DataProviders
{
    public static class DbInitialization
    {

        /// <summary>
        /// initial db and create collections and set indexes
        /// </summary>
        public static void InitialMongoDb(this IServiceScopeFactory scopeFactory)
        {
            using (var serviceScope = scopeFactory.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetService<IMainDbContext>();

                CreateCollections(dbContext);

                CreateIndexes(dbContext);
            }
        }



        /// <summary>
        /// Ensure collections created
        /// </summary>
        private static void CreateCollections(IMainDbContext dbContext)
        {
            var collections = dbContext.Collections();

            if (!collections.Has<Board>())
                dbContext.CreateCollection<Board>();

            if (!collections.Has<Task>())
                dbContext.CreateCollection<Task>();

            if (!collections.Has<Organization>())
                dbContext.CreateCollection<Organization>();

            if (!collections.Has<Project>())
                dbContext.CreateCollection<Project>();

            if (!collections.Has<User>())
                dbContext.CreateCollection<User>();

            if (!collections.Has<ApplicationRole>(name: "Roles"))
                dbContext.CreateCollection<ApplicationRole>(name: "Roles");
        }



        /// <summary>
        /// Create index for collections
        /// </summary>
        private static void CreateIndexes(IMainDbContext dbContext)
        {
            #region Task Indexs

            dbContext.GetCollection<Task>().Indexes.CreateOneAsync(new CreateIndexModel<Task>(Builders<Task>.IndexKeys.Ascending(x => x.Id), new CreateIndexOptions() { Name = "Id", Unique = true }));
            dbContext.GetCollection<Task>().Indexes.CreateOneAsync(new CreateIndexModel<Task>(Builders<Task>.IndexKeys.Ascending(x => x.BoardId), new CreateIndexOptions() { Name = "BoardId" }));


            #endregion

            #region Board Indexs

            dbContext.GetCollection<Board>().Indexes.CreateOneAsync(new CreateIndexModel<Board>(Builders<Board>.IndexKeys.Ascending(x => x.Id), new CreateIndexOptions() { Name = "Id", Unique = true }));
            dbContext.GetCollection<Board>().Indexes.CreateOneAsync(new CreateIndexModel<Board>(Builders<Board>.IndexKeys.Ascending(x => x.ProjectId), new CreateIndexOptions() { Name = "ProjectId" }));


            #endregion

            #region Project Indexs

            dbContext.GetCollection<Project>().Indexes.CreateOneAsync(new CreateIndexModel<Project>(Builders<Project>.IndexKeys.Ascending(x => x.Id), new CreateIndexOptions() { Name = "Id", Unique = true }));
            dbContext.GetCollection<Project>().Indexes.CreateOneAsync(new CreateIndexModel<Project>(Builders<Project>.IndexKeys.Ascending(x => x.OrganizationId), new CreateIndexOptions() { Name = "OrganizationId" }));


            #endregion

            #region Organization Indexs

            dbContext.GetCollection<Organization>().Indexes.CreateOneAsync(new CreateIndexModel<Organization>(Builders<Organization>.IndexKeys.Ascending(x => x.Id), new CreateIndexOptions() { Name = "Id", Unique = true }));
            dbContext.GetCollection<Organization>().Indexes.CreateOneAsync(new CreateIndexModel<Organization>(Builders<Organization>.IndexKeys.Ascending(x => x.UserId), new CreateIndexOptions() { Name = "UserId" }));


            #endregion

            #region User Indexs

            dbContext.GetCollection<User>().Indexes.CreateOneAsync(new CreateIndexModel<User>(Builders<User>.IndexKeys.Ascending(x => x.Id), new CreateIndexOptions() { Name = "Id", Unique = true }));
            dbContext.GetCollection<User>().Indexes.CreateOneAsync(new CreateIndexModel<User>(Builders<User>.IndexKeys.Ascending(x => x.UserName), new CreateIndexOptions() { Name = "UserName", Unique = true }));
            dbContext.GetCollection<User>().Indexes.CreateOneAsync(new CreateIndexModel<User>(Builders<User>.IndexKeys.Ascending(x => x.Email), new CreateIndexOptions() { Name = "Email" }));
            dbContext.GetCollection<User>().Indexes.CreateOneAsync(new CreateIndexModel<User>(Builders<User>.IndexKeys.Ascending(x => x.PhoneNumber), new CreateIndexOptions() { Name = "PhoneNumber", Unique = true }));
            dbContext.GetCollection<User>().Indexes.CreateOneAsync(new CreateIndexModel<User>(Builders<User>.IndexKeys.Ascending(x => x.DisplayName), new CreateIndexOptions() { Name = "DisplayName" }));
            dbContext.GetCollection<User>().Indexes.CreateOneAsync(new CreateIndexModel<User>(Builders<User>.IndexKeys.Ascending(x => x.NormalizedEmail), new CreateIndexOptions() { Name = "NormalizedEmail" }));
            dbContext.GetCollection<User>().Indexes.CreateOneAsync(new CreateIndexModel<User>(Builders<User>.IndexKeys.Ascending(x => x.NormalizedUserName), new CreateIndexOptions() { Name = "NormalizedUserName", Unique = true }));


            #endregion

            #region ApplicationRole Indexs

            dbContext.GetCollection<ApplicationRole>(name: "Roles").Indexes.CreateOneAsync(new CreateIndexModel<ApplicationRole>(Builders<ApplicationRole>.IndexKeys.Ascending(x => x.Id), new CreateIndexOptions() { Name = "Id", Unique = true }));

            #endregion
        }

    }
}
