namespace CamadaDeNegocio
{
    public class Transformar
    {
        public List<string> TransformData(List<string> rawData)
        {
            // Lógica de transformação dos dados brutos
            List<string> transformedData = new List<string>();
            foreach (var data in rawData)
            {
                // Lógica de transformação, por exemplo, converter para maiúsculas
                transformedData.Add(data.ToUpper());
            }
            return transformedData;
        }
    }
}
