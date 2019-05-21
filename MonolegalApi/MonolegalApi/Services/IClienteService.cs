using MonolegalApi.Models;
using System.Collections.Generic;
namespace MonolegalApi.Services
{
    public interface IClienteService
    {
        List<Cliente> Get();

        Cliente Get(string id);

        Cliente Create(Cliente Cliente);

        void Update(string id, Cliente ClienteIn);

        void Remove(Cliente ClienteIn);

        void Remove(string id);
    }
}

