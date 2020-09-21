using ClienteEndereco.API.Domain.Models;
using ClienteEndereco.API.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Domain.Services {
    public class EnderecoService : IEnderecoService {

        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository) {
            _enderecoRepository = enderecoRepository;
        }

        public async Task AddAsync(Endereco endereco) {
            try {
                endereco.Validar();
                await _enderecoRepository.AddAsync(endereco);
            } catch (Exception) {

                throw;
            }
        }

        public async Task<IEnumerable<Endereco>> ListAsync() {
            return await _enderecoRepository.LIstAsync();
        }

        public async Task Remove(int id) {
            await _enderecoRepository.Remove(id);
        }

        public async Task Update(Endereco endereco) {
            try {
                endereco.Validar();
                await _enderecoRepository.Update(endereco);
            } catch (Exception) {

                throw;
            }
            
        }
    }
}
