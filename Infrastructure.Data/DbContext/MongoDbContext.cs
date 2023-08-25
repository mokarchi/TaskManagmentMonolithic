using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagment.Infrastructure.Data.DbContext
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly string _dbName;
        private readonly string _connectionString;
        private readonly IMongoDatabase _database;
        private readonly IMongoClient _client;

        public MongoDbContext(string dbName, string connectionString)
        {
            _dbName = dbName;
            _connectionString = connectionString;
            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(_connectionString));
            _client = new MongoClient(settings);
            _database = _client.GetDatabase(_dbName);
        }

        public IMongoCollection<TEntity> GetCollection<TEntity>(string name = "")
        {
            if (string.IsNullOrEmpty(name))
                name = typeof(TEntity).Name + "s";

            return _database.GetCollection<TEntity>(name);
        }

        public void CreateCollection<TEntity>(string name = "")
        {
            if (string.IsNullOrEmpty(name))
                name = typeof(TEntity).Name + "s";

            _database.CreateCollection(name);
        }

        public IList<string> Collections()
        {
            var collections = _database.ListCollections().ToList();
            return collections.Select(c => c["name"].ToString()).ToList();
        }
    }
}
