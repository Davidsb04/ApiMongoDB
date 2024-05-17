using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiMongoDB.Models
{
    public class ClienteModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Nome")]
        public string Nome { get; set; } = null!;

        [BsonElement("Email")]
        public string Email { get; set; } = null!;

        [BsonElement("Telefone")]
        public string Telefone { get; set; } = null!;
    }
}
