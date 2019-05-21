using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MonolegalApi.Models;
using MonolegalApi.Services;

namespace MonolegalApi.Controllers
{
    [DisableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _ICLienteService;

        public ClientesController(IClienteService ICLienteService)
        {
            _ICLienteService = ICLienteService;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            return _ICLienteService.Get();
        }

        [HttpGet("{id:length(24)}", Name = "GetCliente")]
        public ActionResult<Cliente> Get(string id)
        {
            var Cliente = _ICLienteService.Get(id);

            if (Cliente == null)
            {
                return NotFound();
            }

            return Cliente;
        }

        [HttpPost]
        public ActionResult<Cliente> Create(Cliente Cliente)
        {
            _ICLienteService.Create(Cliente);

            return CreatedAtRoute("GetCliente", new { id = Cliente.Id.ToString() }, Cliente);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Cliente ClienteIn)
        {
            var Cliente = _ICLienteService.Get(id);

            if (Cliente == null)
            {
                return NotFound();
            }

            _ICLienteService.Update(id, ClienteIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var Cliente = _ICLienteService.Get(id);

            if (Cliente == null)
            {
                return NotFound();
            }

            _ICLienteService.Remove(Cliente.Id);

            return NoContent();
        }
    }
}