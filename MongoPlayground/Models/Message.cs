namespace MongoPlayground.Models
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    [BsonIgnoreExtraElements]
    public class Message
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("headers")]
        public HeaderModel Headers { get; set; }

        [BsonElement("mailbox")]
        public string Mailbox { get; set; }

        [BsonElement("body")]
        public string Body { get; set; }

        [BsonElement("filename")]
        public string Filename { get; set; }

        [BsonElement("subFolder")]
        public string SubFolder { get; set; }
    }
}