using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SecureCliAPI.Models
{
    [BsonIgnoreExtraElements]
    public class Secure
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("link")]
        public string Link { get; set; }

        [BsonElement("isSecure")] 
        public bool  IsSecure { get; set; }

    }
}