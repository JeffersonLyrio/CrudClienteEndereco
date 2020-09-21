using ClienteEndereco.API.Domain.Models;
using ClienteEndereco.API.Domain.Repositories;
using ClienteEndereco.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Persistence.Repositories {
    public class EnderecoRepository : BaseRepository, IEnderecoRepository {

        public EnderecoRepository(AppDbContext context) : base(context) { }
        public async Task AddAsync(Endereco endereco) {
            await _context.Enderecos.AddAsync(endereco);
            _context.SaveChanges();
        }

        public async Task<Endereco> FindByIdAsync(int id) {
            return await _context.Enderecos.FindAsync(id);
        }

        public async Task<IEnumerable<Endereco>> LIstAsync() {
            return await _context.Enderecos.ToListAsync();
        }

        public async Task Remove(int id) {
            Endereco endereco = await FindByIdAsync(id);
            _context.Remove(endereco);
            _context.SaveChanges();
        }

        public async Task Update(Endereco endereco) {
            _context.Update(endereco);
            _context.SaveChanges();
        }
    }
}
