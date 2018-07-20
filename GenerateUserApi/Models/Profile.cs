using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GenerateUserApi.Models
{
    public class Profile
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string typeAccount { get; set; }
    }
}
