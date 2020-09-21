using ClienteEndereco.API.Domain.Models;
using ClienteEndereco.API.Domain.Repositories;
using ClienteEndereco.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Persistence.Repositories {

    //classse responsavel pela manipulação da entidade Endereco
    public class EnderecoRepository : BaseRepository, IEnderecoRepository {

        public EnderecoRepository(AppDbContext context) : base(context) { }

        /*
            Adiciona um novo Endereço
            
            insert into Endereco
                (Id, Logradura, Bairro, Cidade, Estado)
            values
                (endereco.Id, endereco.Logradura, endereco.Bairro, endereco.Cidade, endereco.Estado)
        */
        public async Task AddAsync(Endereco endereco) {
            await _context.Enderecos.AddAsync(endereco);
            _context.SaveChanges();
        }

        /*
            Seleciona um endereço especifico pelo id
            
            select * from Endereco e 
            where e.Id = id
        */
        public async Task<Endereco> FindByIdAsync(int id) {
            return await _context.Enderecos.FindAsync(id);
        }

        /*
            Lista todos os endereços
            
            select * from Endereco
        */
        public async Task<IEnumerable<Endereco>> LIstAsync() {
            return await _context.Enderecos.ToListAsync();
        }

        /*
            Remove um endereço especificado pelo id
            
            delete Endereco e
            where e.Id = id
        */
        public async Task Remove(int id) {
            Endereco endereco = await FindByIdAsync(id);
            _context.Remove(endereco);
            _context.SaveChanges();
        }

        /*
            Atualiza o endereço

            update Endereco e
            set e.Logradura = endereco.Logradura
                e.Bairro = endereco.Bairro
                e.Cidade = endereco.Cidade
                e.Estado = endereco.Estado
         */
        public async Task Update(Endereco endereco) {
            _context.Update(endereco);
            _context.SaveChanges();
        }
    }
}
