using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;


namespace MonolegalApi.Models
{
    public class Cliente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string nombre { get; set; }

        [BsonElement("ciudad")]
        public string ciudad { get; set; }

        [BsonElement("correo")]
        public string correo { get; set; }

        [BsonElement("nit")]
        public string nit { get; set; }

        [BsonElement("facturas")]
        public List<Factura> facturas { get; set; }

    }
}
