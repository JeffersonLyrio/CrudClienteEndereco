using ClienteEndereco.API.Domain.Models;
using ClienteEndereco.API.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Domain.Services {
    public class ClienteService : IClienteService {

        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) {
            _clienteRepository = clienteRepository;
        }

        public async Task<IEnumerable<Cliente>> ListAsync() {
            return await _clienteRepository.LIstAsync();
        }

        public async Task AddAsync(Cliente cliente) {
            try {
                cliente.Validar();
                await _clienteRepository.AddAsync(cliente);
            } catch (Exception) {

                throw;
            }

        }

        public async Task Remove(int id) {
            await _clienteRepository.Remove(id);
        }

        public async Task Update(Cliente cliente) {
            try {
                cliente.Validar();
                await _clienteRepository.Update(cliente);
            } catch (Exception) {

                throw;
            }
            
        }
    }
}
