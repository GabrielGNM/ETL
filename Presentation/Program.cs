using CamadaDeDados;
using CamadaDeNegocio.Models.DataBase;
using CamadaDeServico;

namespace CamadaDeApresentacao
{
    class Program
    {
        static void Main()
        {
            var dataLayer = new AcessoBancoDeDados();
            var businessLogicLayer = new ServiceTransform();

            // Extração de dados

            var pacientes = dataLayer.ExtractPacienteData();
            var agendamentos = dataLayer.ExtractAgendamentoData();
            var descartesEcologicos = dataLayer.ExtractDescarteEcologicoData();

            foreach (var item in pacientes)
            {
                Console.WriteLine(item.nome.ToString());
            }
            foreach (var item in agendamentos)
            {
                Console.WriteLine(item.procedimento_id.ToString());
            }
            foreach (var item in descartesEcologicos)
            {
                Console.WriteLine(item.descarte_id.ToString());
            }

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
