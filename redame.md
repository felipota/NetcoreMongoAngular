#Config.

##MonolegalApi:

###Se debe configurar las siguiente secciones en el appsettings.json :
###la configuración de correo electrónico se realiza en la siguiente sección:

"EmailSettings": {
    "MailServer": "smtp.gmail.com",
    "MailPort": 465,
    "SenderName": "Felipe Cardenas Prueba",
    "Sender": "felipe.linkthehero@gmail.com",
    "Password": "***********"
  },

###La configuración de base de datos se realiza en la siguiente sección:

  "ConnectionStrings": {
    "MonolegalDB": "mongodb://localhost:27017",
    "Database": "MonolegalDB"
  },


##MonolegalApp:

se debe configurar la ruta del api en el archivo:
\src\app\providers\base.url.ts


##Mongo:

Se debe crear un DB con nombre MonolegalDB (se puede crear con otro nombre pero se debe configurar en el appsettings.json del api), luego una colección con nombre Clientes la cual se le realizara la siguiente inserción(el ejemplo incluye tres clientes, pero se pueden agregar mas):
[
  {
    "nombre": "Felipe Cardenas",
    "ciudad": "Bogota D.C.",
    "correo": "link_the_hero@hotmail.com",
    "nit": "86080878",
    "facturas": [
      {
        "codigoFactura": "P-00001",
        "fechaCreacion": "2019-01-01",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00002",
        "fechaCreacion": "2019-01-02",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00003",
        "fechaCreacion": "2019-01-03",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00004",
        "fechaCreacion": "2019-01-04",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      }
    ]
  },
  {
    "nombre": "Pepe Perez",
    "ciudad": "Bogota D.C.",
    "correo": "link_the_hero@hotmail.com",
    "nit": "1121097392",
    "facturas": [
      {
        "codigoFactura": "P-00005",
        "fechaCreacion": "2019-01-01",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00006",
        "fechaCreacion": "2019-01-02",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00007",
        "fechaCreacion": "2019-01-03",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00008",
        "fechaCreacion": "2019-01-04",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      }
    ]
  },
  {
    "nombre": "Caroleta Ramirez",
    "ciudad": "Bogota D.C.",
    "correo": "link_the_hero@hotmail.com",
    "nit": "11234564",
    "facturas": [
      {
        "codigoFactura": "P-00009",
        "fechaCreacion": "2019-01-01",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00010",
        "fechaCreacion": "2019-01-02",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00011",
        "fechaCreacion": "2019-01-03",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      },
      {
        "codigoFactura": "P-00012",
        "fechaCreacion": "2019-01-04",
        "fechaPago": "",
        "pagada": false,
        "estado": "PrimerRecordatorio",
        "subTotal": 16200,
        "iva": 3800,
        "retencion": 0,
        "total": 20000
      }
    ]
  }
]
