using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SocialNetwork.Models
{
   
    class Users
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("isActive")]
        public bool IsActive { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("name")]
        public Name Name { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("about")]
        public string About { get; set; }

        [BsonElement("registered")]
        public string Registered { get; set; }

        [BsonElement("friends")]
        public IEnumerable<Friend> Friends { get; set; }
        
    }
    class Name
    {
        [BsonElement("first")]
        public string First { get; set; }
        [BsonElement("last")]
        public string Last { get; set; }
    }
    class Friend
    {
        [BsonElement("id")]
        public double First { get; set; }
        [BsonElement("name")]
        public string Last { get; set; }
    }
}
