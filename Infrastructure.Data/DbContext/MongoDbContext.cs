using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagment.Infrastructure.Data.DbContext
{
    public class MongoDbContext : IMainDbContext
    {
        #region Fields

        private readonly string _dbName;
        private readonly string _connectionString;
        private readonly IMongoDatabase _database;
        private readonly IMongoClient _client;

        #endregion

        #region Ctor


        public MongoDbContext(IConfiguration configuration)
        {
            _dbName = configuration["Mongo:Database"];
            _connectionString = configuration["Mongo:Connection"];
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(_connectionString));
            _client = new MongoClient(settings);
            _database = _client.GetDatabase(_dbName);
        }



        #endregion

        #region Public Methods





        /// <summary>
        /// 
        /// </summary>
        public IMongoCollection<TEntity> GetCollection<TEntity>(string name = "")
        {
            if (string.IsNullOrEmpty(name))
                name = typeof(TEntity).Name + "s";

            return _database.GetCollection<TEntity>(name);
        }





        /// <summary>
        /// 
        /// </summary>
        public void CreateCollection<TEntity>(string name = "")
        {
            if (string.IsNullOrEmpty(name))
                name = typeof(TEntity).Name + "s";

            _database.CreateCollection(name);
        }




        /// <summary>
        /// 
        /// </summary>
        public IList<string> Collections()
        {
            var collections = _database.ListCollections().ToList();
            return collections.Select(c => c["name"].ToString()).ToList();
        }



        #endregion

    }
}
