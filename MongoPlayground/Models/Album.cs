namespace MongoPlayground.Models
{
    using System.Collections.Generic;

    using MongoDB.Bson.Serialization.Attributes;

    public class Album
    {
        [BsonId]
        public int Id { get; set; }

        [BsonElement("images")]
        public List<int> Images { get; set; }
    }
}