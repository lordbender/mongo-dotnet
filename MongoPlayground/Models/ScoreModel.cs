namespace MongoPlayground.Models
{
    using MongoDB.Bson.Serialization.Attributes;

    internal class ScoreModel
    {
        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("score")]
        public double Score { get; set; }
    }
}