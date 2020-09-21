using ClienteEndereco.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Domain.Services {
    public interface IEnderecoService {
        Task<IEnumerable<Endereco>> ListAsync();
        Task AddAsync(Endereco endereco);
        Task Update(Endereco endereco);
        Task Remove(int id);
    }
}
