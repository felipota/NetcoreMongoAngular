<<<<<<< HEAD
﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
=======
﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
>>>>>>> 9bd5cb3e33341e4627f0d1eab90da82dc9784e56
