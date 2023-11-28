using CamadaDeNegocio.Models.DataBase;
using Microsoft.EntityFrameworkCore;

namespace CamadaDeDados.Context
{
    public class ClinicaGardenDbContext : DbContext
    {
        public DbSet<PacienteModel> pacientes { get; set; }
        public DbSet<AgendamentoModel> agendamentos { get; set; }
        public DbSet<DescarteEcologicoModel> descartesecologicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configurar a string de conexão do seu banco de dados
            optionsBuilder.UseNpgsql(Environment.GetEnvironmentVariable("ConnectionStringClinicaGarden"));
        }
    }
}
