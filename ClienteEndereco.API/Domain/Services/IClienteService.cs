using ClienteEndereco.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Domain.Services {
    public interface IClienteService {
        Task<IEnumerable<Cliente>> ListAsync();
        Task AddAsync(Cliente cliente);        
        Task Remove(int id);
        Task Update(Cliente cliente);
    }
}
