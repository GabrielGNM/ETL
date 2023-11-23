using CamadaDeDados.Models;
using Microsoft.EntityFrameworkCore;

namespace CamadaDeDados.Context
{
    public class ClinicaGardenDbContext : DbContext
    {
        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<AgendamentoModel> Agendamentos { get; set; }
        public DbSet<DescarteEcologicoModel> DescartesEcologicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurar a string de conexão do seu banco de dados
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionStringTechMuse"));
        }
    }
}
