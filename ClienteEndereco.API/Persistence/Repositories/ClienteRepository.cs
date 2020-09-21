using ClienteEndereco.API.Domain.Models;
using ClienteEndereco.API.Domain.Repositories;
using ClienteEndereco.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Persistence.Repositories {
    public class ClienteRepository : BaseRepository, IClienteRepository {
        public ClienteRepository(AppDbContext context) : base(context) { }

        public async Task AddAsync(Cliente cliente) {
            await _context.Clientes.AddAsync(cliente);
            _context.SaveChanges();
        }

        public async Task<Cliente> FindByIdAsync(int id) {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> LIstAsync() {
            return await _context.Clientes
                .FromSqlRaw($"SELECT * FROM Clientes")
                .ToListAsync();
        }

        public async Task Remove(int id) {
            Cliente cliente = await FindByIdAsync(id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        public async Task Update(Cliente cliente) {            
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
    }
}
