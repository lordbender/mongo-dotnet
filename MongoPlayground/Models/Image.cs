namespace MongoPlayground.Models
{
    using System.Collections.Generic;

    using MongoDB.Bson.Serialization.Attributes;

    public class Image
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("height")]
        public int Height { get; set; }

        [BsonElement("width")]
        public int Width { get; set; }

        [BsonElement("tags")]
        public List<string> Tags { get; set; }
    }
}