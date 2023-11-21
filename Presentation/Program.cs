using CamadaDeDados;
using CamadaDeDados.Models;
using CamadaDeNegocio;

namespace Program
{
    class Program
    { 
        static void Main()
        {
            var dataLayer = new Dados();
            var businessLogicLayer = new Transformar();

            // Extração de dados
            List<Account> rawData = dataLayer.ExtractData();

            // Transformação de dados
            //List<string> transformedData = businessLogicLayer.TransformData(rawData);

            // Carregamento de dados transformados
            //dataLayer.LoadData(transformedData);

            Console.ReadLine();
        }
    }
}
