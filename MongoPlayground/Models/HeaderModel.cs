namespace MongoPlayground.Models
{
    using System.Collections.Generic;

    using MongoDB.Bson.Serialization.Attributes;

    [BsonIgnoreExtraElements]
    public class HeaderModel
    {
        [BsonElement("From")]
        public string From { get; set; }

        [BsonElement("To")]
        public List<string> To { get; set; }
    }
}