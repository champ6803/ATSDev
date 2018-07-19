using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TestApp.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string email { get; set; }
        public string pwd { get; set; }
    }
}
