using ClienteEndereco.API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteEndereco.API.Persistence.Contexts {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<Cliente>().ToTable("Clientes");
            builder.Entity<Cliente>().HasKey(p => p.Identificador);
            builder.Entity<Cliente>().Property(p => p.Identificador).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Cliente>().Property(p => p.Nome).HasMaxLength(30);
            builder.Entity<Cliente>().Property(p => p.Cpf).IsRequired();
            builder.Entity<Cliente>().Property(p => p.Idade);
            builder.Entity<Cliente>().Property(p => p.DataNascimento).IsRequired();


            builder.Entity<Endereco>().ToTable("Enderecos");
            builder.Entity<Endereco>().HasKey(p => p.Id);
            builder.Entity<Endereco>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Endereco>().Property(p => p.Logradura).IsRequired().HasMaxLength(50);
            builder.Entity<Endereco>().Property(p => p.Bairro).IsRequired().HasMaxLength(40);
            builder.Entity<Endereco>().Property(p => p.Cidade).IsRequired().HasMaxLength(40);
            builder.Entity<Endereco>().Property(p => p.Estado).IsRequired().HasMaxLength(40);
        }
    }
}
