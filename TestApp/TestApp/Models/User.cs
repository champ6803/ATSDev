using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TestApp.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
    }
}
