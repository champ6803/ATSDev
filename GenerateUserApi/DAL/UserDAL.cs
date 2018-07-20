using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GenerateUserApi.Models
{
    public class UserDAL
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<User> col;

        public UserDAL()
        {
            this.client = new MongoClient("mongodb://127.0.0.1:27017");
            this.db = client.GetDatabase("ats");
            this.col = this.db.GetCollection<User>("user");
        }

        public async Task<IEnumerable<User>> All()
        {
            var list = await this.col.Find(new BsonDocument()).ToListAsync();
            return list;
        }

        public async Task InserUser(User user)
        {
            await this.col.InsertOneAsync(user);
        }
    }
}