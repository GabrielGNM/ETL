using CamadaDeDados.Context;
using CamadaDeDados.Models;

namespace CamadaDeDados
{
    public class Dados
    {
        public List<Account> ExtractData()
        {
            // Lógica de extração de dados, pode ser consulta a um banco de dados, leitura de arquivo, etc.
            // Retornar dados brutos, por exemplo, de um banco de dados
            var rawData = new List<Account>();
            using (var dbContext = new TechMuseDbContext())
            {
                // Obter todos os registros da tabela Account
                var accounts = dbContext.Accounts.ToList();
                rawData = accounts;
                // Agora, 'accounts' contém todos os registros da tabela Account
            }
            return rawData;
        }

        public void LoadData(List<string> transformedData)
        {
            // Lógica de carregamento de dados, por exemplo, inserção em um banco de dados
            foreach (var data in transformedData)
            {
                // Lógica de inserção
                Console.WriteLine($"Dado carregado: {data}");
            }
        }
    }

}
