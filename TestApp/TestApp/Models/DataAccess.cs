using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TestApp.Models
{
    public class DataAccess
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<User> col;

        public DataAccess()
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

        public async Task<User> Get(string id)
        {
            var us = await this.col.Find(x => x.id == id).FirstAsync();
            return us;
        }
    }
}