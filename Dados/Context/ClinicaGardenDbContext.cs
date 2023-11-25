using CamadaDeDados.Models;
using Microsoft.EntityFrameworkCore;

namespace CamadaDeDados.Context
{
    public class ClinicaGardenDbContext : DbContext
    {
        public DbSet<PacienteModel> paciente { get; set; }
        public DbSet<AgendamentoModel> agendamentos { get; set; }
        public DbSet<DescarteEcologicoModel> descarteecologicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurar a string de conexão do seu banco de dados
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("ConnectionStringClinicaGarden"));
        }
    }
}
