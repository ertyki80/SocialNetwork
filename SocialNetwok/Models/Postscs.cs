using System;
using MongoDB.Bson.Serialization.Attributes;

namespace SocialNetwork.Models
{
    public class Posts
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("title")]
        public Name Title { get; set; }

        [BsonElement("body")]
        public string Body { get; set; }

        [BsonElement("tags")]
        public Tags Tags { get; set; }

        [BsonElement("comments")]
        public Comments Comments { get; set; }

        [BsonElement("timeOfCreating")]
        public DateTime TimeOfCreating { get; set; }

        [BsonElement("like")]
        public int Like { get; set; }

    }
    public class Tags
    {
        [BsonElement("id")]
        public string Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
    }
    public class Comments
    {
        [BsonElement("author")]
        public double Author { get; set; }
        [BsonElement("body")]
        public string Body { get; set; }
    }
}
