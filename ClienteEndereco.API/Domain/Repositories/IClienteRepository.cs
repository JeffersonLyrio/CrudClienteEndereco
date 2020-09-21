using ClienteEndereco.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Domain.Repositories {
    public interface IClienteRepository {
        Task<IEnumerable<Cliente>> LIstAsync();
        Task AddAsync(Cliente cliente);
        Task<Cliente> FindByIdAsync(int id);
        Task Update(Cliente cliente);
        Task Remove(int id);
    }
}
