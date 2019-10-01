using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace myshop.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}