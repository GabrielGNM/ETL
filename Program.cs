// PresentationLayer.cs
class Program
{
    static void Main()
    {
        DataLayer dataLayer = new DataLayer();
        BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();

        // Extração de dados
        List<string> rawData = dataLayer.ExtractData();

        // Transformação de dados
        List<string> transformedData = businessLogicLayer.TransformData(rawData);

        // Carregamento de dados transformados
        dataLayer.LoadData(transformedData);

        Console.ReadLine();
    }
}
