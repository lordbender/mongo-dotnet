namespace MongoPlayground.Models
{
    using System.Collections.Generic;

    using MongoDB.Bson.Serialization.Attributes;

    internal class ZipModel
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("pop")]
        public int Population { get; set; }

        [BsonElement("state")]
        public string State { get; set; }

        [BsonElement("loc")]
        public List<double> LatLong { get; set; }
    }
}