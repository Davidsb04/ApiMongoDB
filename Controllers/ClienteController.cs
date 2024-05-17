using ApiMongoDB.Models;
using ApiMongoDB.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteService _clienteService;

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<List<ClienteModel>> Get() =>
        await _clienteService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<ClienteModel>> GetOne(string id)
        {
            var cliente = await _clienteService.GetAsync(id);

            if(cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }


        [HttpPost]
        public async Task<IActionResult> Post(ClienteModel cliente)
        {
            await _clienteService.CreatAsync(cliente);

            return CreatedAtAction(nameof(Get), new {id = cliente.Id}, cliente);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id,  ClienteModel updateCliente)
        {
            var cliente = await _clienteService.GetAsync(id);

            if( cliente == null)
            {
                return NotFound();
            }

            updateCliente.Id = cliente.Id;

            await _clienteService.UpdateAsync(id, updateCliente);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var cliente = await _clienteService.GetAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            await _clienteService.DeleteAsync(id);

            return NoContent();
        }
    }
}
