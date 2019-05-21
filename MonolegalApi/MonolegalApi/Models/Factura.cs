﻿using MongoDB.Bson.Serialization.Attributes;


namespace MonolegalApi.Models
{
    public class Factura
    {
        [BsonElement("CodigoFactura")]
        public string CodigoFactura { get; set; }

        [BsonElement("FechaCreacion")]
        public string FechaCreacion { get; set; }

        [BsonElement("FechaPago")]
        public string FechaPago { get; set; }

        [BsonElement("Pagada")]
        public bool Pagada { get; set; }

        [BsonElement("estado")]
        public string estado { get; set; }

        [BsonElement("SubTotal")]
        public decimal SubTotal { get; set; }

        [BsonElement("Iva")]
        public decimal Iva { get; set; }

        [BsonElement("Retencion")]
        public decimal Retencion { get; set; }

        [BsonElement("Total")]
        public decimal Total { get; set; }
    }
}
