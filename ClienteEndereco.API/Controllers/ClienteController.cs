using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteEndereco.API.Domain.Models;
using ClienteEndereco.API.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClienteEndereco.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase {

        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService) {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Recupera todos os clientes
        /// </summary>
        /// <returns>Lista de Cliente</returns>
        [HttpGet]
        public async Task<IEnumerable<Cliente>> Get() {
            var clientes = await _clienteService.ListAsync();
            return clientes;
        }

        /// <summary>
        /// Adiciona um novo cliente
        /// </summary>
        /// <param name="cliente"></param>
        [HttpPost]
        public async Task Post([FromBody] Cliente cliente) {
            await _clienteService.AddAsync(cliente);
        }

        /// <summary>
        /// Atualiza o cliente especificado
        /// </summary>
        /// <param name="cliente"></param>        
        [HttpPut]
        public async Task Put([FromBody] Cliente cliente) {
            await _clienteService.Update(cliente);
        }

        /// <summary>
        /// Deleta o cliente especificado
        /// </summary>
        /// <param name="id"></param>        
        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _clienteService.Remove(id);
        }
    }
}
