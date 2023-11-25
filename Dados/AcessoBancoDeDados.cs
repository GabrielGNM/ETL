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
                // Log the exception details for further investigation
                // You can use a logging library or print to console for simplicity
                return new List<PacienteModel>(); // Return an empty list or handle the error as needed
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
                // Log the exception details for further investigation
                // You can use a logging library or print to console for simplicity
                return new List<AgendamentoModel>(); // Return an empty list or handle the error as needed
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
                // Log the exception details for further investigation
                // You can use a logging library or print to console for simplicity
                return new List<DescarteEcologicoModel>(); // Return an empty list or handle the error as needed
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

        // Implement IDisposable to properly dispose of the DbContext
        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
