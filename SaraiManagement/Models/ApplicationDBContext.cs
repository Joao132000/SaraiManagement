using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace SaraiManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Caixa>Caixas { get; set; }
        public DbSet<Dinheiro>Dinheiros { get; set; }
        public DbSet<Doacao>Doacaos { get; set; }
        public DbSet<Doador> Doadors { get; set; }
        public DbSet<Donatario> Donatarios { get; set; }
        public DbSet<ItemDoado>ItemDoados { get; set; }
        public DbSet<Movimentacao>Movimentacaos { get; set; }
        public DbSet<Outros> Outros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
