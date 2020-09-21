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
    public class EnderecoController : ControllerBase {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService) {
            _enderecoService = enderecoService;
        }

        /// <summary>
        /// Recupera todos os Endereços
        /// </summary>
        /// <returns>Lista de Endereco</returns>
        [HttpGet]
        public async Task<IEnumerable<Endereco>> Get() {
            var enderecos = await _enderecoService.ListAsync();
            return enderecos;
        }

        /// <summary>
        /// Adiciona um novo Endereço
        /// </summary>
        /// <param name="endereco"></param>
        [HttpPost]
        public async Task Post([FromBody] Endereco endereco) {
            await _enderecoService.AddAsync(endereco);
        }

        /// <summary>
        /// Atualiza o endereço especificado
        /// </summary>
        /// <param name="id"></param>
        [HttpPut]
        public async Task Put([FromBody] Endereco endereco) {
            await _enderecoService.Update(endereco);
        }

        /// <summary>
        /// Deleta o endereço especificado
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            await _enderecoService.Remove(id);
        }
    }
}
