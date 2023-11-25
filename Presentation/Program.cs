using CamadaDeDados;
using CamadaDeServico;

namespace CamadaDeApresentacao
{
    class Program
    {
        static async Task Main()
        {
            var dataLayer = new AcessoBancoDeDados();
            var businessLogicLayer = new ServiceTransform();

            // Extração de dados

            var Pacientes = dataLayer.ExtractPacienteData();
            var Agendamentos = dataLayer.ExtractAgendamentoData();
            var DescartesEcologicos = dataLayer.ExtractDescarteEcologicoData();

            Console.WriteLine(DescartesEcologicos.ToString());
            Console.WriteLine(Agendamentos.ToString());
            Console.WriteLine(Pacientes.ToString());



            //dataLayer.LoadData(dataReadyToLoad);

            // Transformação de dados
            //var transformedData = ServiceTransform.TransformData(Pacientes, Agendamentos, DescartesEcologicos);
            //List<string> transformedData = businessLogicLayer.TransformData(rawData);

            // Carregamento de dados transformados
            //dataLayer.LoadData(transformedData);

            Console.ReadLine();
        }
    }
}
