using CamadaDeDados.Models;
using Microsoft.EntityFrameworkCore;

namespace CamadaDeDados.Context
{
    public class TechMuseDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurar a string de conexão do seu banco de dados
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionStringTechMuse"));
        }
    }
}
