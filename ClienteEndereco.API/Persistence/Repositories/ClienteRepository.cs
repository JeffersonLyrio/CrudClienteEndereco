using ClienteEndereco.API.Domain.Models;
using ClienteEndereco.API.Domain.Repositories;
using ClienteEndereco.API.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Persistence.Repositories {

    //classse responsavel pela manipulação da entidade Cliente
    public class ClienteRepository : BaseRepository, IClienteRepository {
        public ClienteRepository(AppDbContext context) : base(context) { }

        /*
            Adiciona um novo Cliente
            
            insert into Cliente
                (Identificador, Nome, Cpf, Idade, DataNascimento)
            values
                (cliente.Identificador, cliente.Nome, cliente.Cpf, cliente.Idade, cliente.DataNascimento)
        */
        public async Task AddAsync(Cliente cliente) {
            await _context.Clientes.AddAsync(cliente);
            _context.SaveChanges();
        }


        /*
            Seleciona um Cliente especifico pelo id
            
            select * from Cliente c 
            where c.Id = id
        */
        public async Task<Cliente> FindByIdAsync(int id) {
            return await _context.Clientes.FindAsync(id);
        }


        /*
            Lista todos os Clientes
            
            select * from Cliente
        */
        public async Task<IEnumerable<Cliente>> LIstAsync() {
            return await _context.Clientes.ToListAsync();
        }


        /*
            Remove um Cliente especificado pelo id
            
            delete Cliente c
            where c.Id = id
        */
        public async Task Remove(int id) {
            Cliente cliente = await FindByIdAsync(id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
        }

        /*
            Atualiza o Cliente

            update Cliente c
            set c.Identificador = cliente.Identificador
                c.Nome = cliente.Nome
                c.Cpf = cliente.Cpf
                c.Idade = cliente.Idade
                c.DataNascimento = cliente.DataNascimento
         */
        public async Task Update(Cliente cliente) {            
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }
    }
}
