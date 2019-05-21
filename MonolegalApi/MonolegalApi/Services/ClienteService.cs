<<<<<<< HEAD
﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using MonolegalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonolegalApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IMongoCollection<Cliente> _clientes;
        public ClienteService(IOptions<DBConnectionStrings> connectionString)
        {
            var client = new MongoClient(connectionString.Value.MonolegalDB);
            var database = client.GetDatabase("Monolegal");
            _clientes = database.GetCollection<Cliente>("Clientes");
        }

        public List<Cliente> Get()
        {
            return _clientes.Find(Cliente => true).ToList();
        }

        public Cliente Get(string id)
        {
            return _clientes.Find<Cliente>(Cliente => Cliente.Id == id).FirstOrDefault();
        }

        public Cliente Create(Cliente Cliente)
        {
            _clientes.InsertOne(Cliente);
            return Cliente;
        }

        public void Update(string id, Cliente ClienteIn)
        {
            _clientes.ReplaceOne(Cliente => Cliente.Id == id, ClienteIn);
        }

        public void Remove(Cliente ClienteIn)
        {
            _clientes.DeleteOne(Cliente => Cliente.Id == ClienteIn.Id);
        }

        public void Remove(string id)
        {
            _clientes.DeleteOne(Cliente => Cliente.Id == id);
        }
    }
}
=======
﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using MonolegalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonolegalApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IMongoCollection<Cliente> _clientes;
        public ClienteService(IOptions<DBConnectionStrings> connectionString)
        {
            var client = new MongoClient(connectionString.Value.MonolegalDB);
            var database = client.GetDatabase("Monolegal");
            _clientes = database.GetCollection<Cliente>("Clientes");
        }

        public List<Cliente> Get()
        {
            return _clientes.Find(Cliente => true).ToList();
        }

        public Cliente Get(string id)
        {
            return _clientes.Find<Cliente>(Cliente => Cliente.Id == id).FirstOrDefault();
        }

        public Cliente Create(Cliente Cliente)
        {
            _clientes.InsertOne(Cliente);
            return Cliente;
        }

        public void Update(string id, Cliente ClienteIn)
        {
            _clientes.ReplaceOne(Cliente => Cliente.Id == id, ClienteIn);
        }

        public void Remove(Cliente ClienteIn)
        {
            _clientes.DeleteOne(Cliente => Cliente.Id == ClienteIn.Id);
        }

        public void Remove(string id)
        {
            _clientes.DeleteOne(Cliente => Cliente.Id == id);
        }
    }
}
>>>>>>> 9bd5cb3e33341e4627f0d1eab90da82dc9784e56
