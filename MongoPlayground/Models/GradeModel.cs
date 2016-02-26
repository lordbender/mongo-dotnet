namespace MongoPlayground.Models
{
    using System.Collections.Generic;

    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    internal class GradeModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("student_id")]
        public int StudentId { get; set; }

        [BsonElement("class_id")]
        public int ClassId { get; set; }

        [BsonElement("scores")]
        public List<ScoreModel> Scores { get; set; }
    }
}