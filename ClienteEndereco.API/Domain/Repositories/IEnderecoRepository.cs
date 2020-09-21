using ClienteEndereco.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Domain.Repositories {
    public interface IEnderecoRepository {
        Task<IEnumerable<Endereco>> LIstAsync();
        Task AddAsync(Endereco endereco);
        Task Update(Endereco endereco);
        Task Remove(int id);
    }
}
