namespace CamadaDeNegocio.Models.PowerBI
{
    public class PowerBiModel
    {
        public Dictionary<string,float>? MediaDescartePorAtendimento { get; set; }
        public Dictionary<string, List<string>>? Top5AgendamentosPorFaixaEtaria { get; set; }
        public Dictionary<string, string>? ProcedimentosMaisPedidosPorFaixaEtaria { get; set; }
    }
}
