
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MonolegalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonolegalApi.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IMongoCollection<Cliente> _clientes;
        public ClienteService(IOptions<DBConnectionStrings> connectionString)
        {
            var client = new MongoClient(connectionString.Value.MonolegalDB);
            var database = client.GetDatabase(connectionString.Value.Database);
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
