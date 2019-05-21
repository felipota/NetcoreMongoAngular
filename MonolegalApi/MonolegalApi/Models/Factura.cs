using MongoDB.Bson.Serialization.Attributes;


namespace MonolegalApi.Models
{
    public class Factura
    {
        [BsonElement("codigoFactura")]
        public string codigoFactura { get; set; }

        [BsonElement("fechaCreacion")]
        public string fechaCreacion { get; set; }

        [BsonElement("fechaPago")]
        public string fechaPago { get; set; }

        [BsonElement("pagada")]
        public bool pagada { get; set; }

        [BsonElement("estado")]
        public string estado { get; set; }

        [BsonElement("subTotal")]
        public decimal subTotal { get; set; }

        [BsonElement("iva")]
        public decimal iva { get; set; }

        [BsonElement("retencion")]
        public decimal retencion { get; set; }

        [BsonElement("total")]
        public decimal total { get; set; }
    }
}

