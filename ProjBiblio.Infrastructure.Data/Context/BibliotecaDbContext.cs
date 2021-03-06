using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProjBiblio.Domain.Entities;
using ProjBiblio.Infrastructure.Data.Context.Config;

namespace ProjBiblio.Infrastructure.Data.Context
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Autor> Autor { get; set; }

        public DbSet<Livro> Livro { get; set; }  

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Emprestimo> Emprestimo { get; set; }

        public DbSet<LivroAutor> LivroAutor { get; set; }

        public DbSet<LivroEmprestimo> LivroEmprestimo { get; set; }

        public DbSet<Carrinho> Carrinho { get; set; }

        public DbSet<Genero> Genero { get; set; }

        public DbSet<Marketing> Marketing { get; set; }

        public DbSet<LivroMarketing> LivroMarketing { get; set; }
    }
}