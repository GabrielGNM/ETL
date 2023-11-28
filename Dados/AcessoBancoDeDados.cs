using CamadaDeDados.Context;
using CamadaDeNegocio.Models.DataBase;

namespace CamadaDeDados
{
    public class AcessoBancoDeDados
    {
        private readonly ClinicaGardenDbContext dbContext;

        public AcessoBancoDeDados()
        {
            dbContext = new ClinicaGardenDbContext();
        }

        public List<PacienteModel> ExtractPacienteData()
        {
            try
            {
                return dbContext.pacientes.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extracting Paciente data: {ex.Message}");
                return new List<PacienteModel>();
            }
        }

        public List<AgendamentoModel> ExtractAgendamentoData()
        {
            try
            {
                return dbContext.agendamentos.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extracting Agendamento data: {ex.Message}");
                return new List<AgendamentoModel>();
            }
        }

        public List<DescarteEcologicoModel> ExtractDescarteEcologicoData()
        {
            try
            {
                return dbContext.descartesecologicos.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error extracting DescarteEcologico data: {ex.Message}");
                return new List<DescarteEcologicoModel>(); 
            }
        }

        public void LoadData(List<string> transformedData)
        {
            // Your loading logic here
            foreach (var data in transformedData)
            {
                // Lógica de inserção
                Console.WriteLine($"Dado carregado: {data}");
            }
        }
    }
}
