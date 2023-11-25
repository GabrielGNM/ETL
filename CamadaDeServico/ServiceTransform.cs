using CamadaDeNegocio.Models.DataBase;
using CamadaDeNegocio.Models.PowerBI;

namespace CamadaDeServico
{
    public class ServiceTransform
    {
        public PowerBiModel _PowerBiModel { get; set; }
        public static void TransformData(List<PacienteModel> Pacientes, List<AgendamentoModel> Agendamentos, List<DescarteEcologicoModel> DescartesEcologicos)
        {
           // _PowerBiModel.MediaDescartePorAtendimento = BuscaMediaDescartePorAtendimento(Agendamentos, DescartesEcologicos);
            // Lógica de transformação dos dados brutos
            List<string> transformedData = new List<string>();
            //foreach (var data in rawData)
            //{
            //    // Lógica de transformação, por exemplo, converter para maiúsculas
            //    transformedData.Add(data.ToUpper());
            //}
            //return _PowerBiModel;
        }

        public static float BuscaMediaDescartePorAtendimento(List<AgendamentoModel> Agendamentos, List<DescarteEcologicoModel> DescartesEcologicos)
        {
            return 10;
        }
    }
}
