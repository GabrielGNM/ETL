using CamadaDeDados;
using CamadaDeDados.Models;
using CamadaDeNegocio;

namespace CamadaDeApresentacao
{
    class Program
    {
        static void Main()
        {
            var dataLayer = new AcessoBancoDeDados();
            var businessLogicLayer = new Transformar();

            // Extração de dados
            //var Accounts = dataLayer.ExtractExemploData();
            var Pacientes = dataLayer.ExtractPacienteData();
            var Agendamentos = dataLayer.ExtractAgendamentoData();
            var DescartesEcologicos = dataLayer.ExtractDescarteEcologicoData();

            // Transformação de dados
            //List<string> transformedData = businessLogicLayer.TransformData(rawData);

            // Carregamento de dados transformados
            //dataLayer.LoadData(transformedData);

            Console.ReadLine();
        }
    }
}
