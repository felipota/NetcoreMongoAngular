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

        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        [BsonElement("Ciudad")]
        public string Ciudad { get; set; }

        [BsonElement("Correo")]
        public string Correo { get; set; }

        [BsonElement("Nit")]
        public string Nit { get; set; }

        [BsonElement("Facturas")]
        public List<Factura> Facturas { get; set; }

    }
}
