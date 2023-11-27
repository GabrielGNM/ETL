using CamadaDeNegocio.Models.DataBase;
using CamadaDeNegocio.Models.PowerBI;

namespace CamadaDeServico
{
    public class ServiceTransform
    {
        public PowerBiModel TransformData(List<PacienteModel> Pacientes, List<AgendamentoModel> Agendamentos, List<DescarteEcologicoModel> DescartesEcologicos)
        {
            var resultado = new PowerBiModel();
            resultado.MediaDescartePorAtendimento = BuscaMediaDescartePorAtendimento(Agendamentos, DescartesEcologicos);
            resultado.ProcedimentosMaisPedidosPorFaixaEtaria = BuscaProcedimentosMaisPedidosPorFaixaEtaria(Pacientes, Agendamentos);
            resultado.Top5AgendamentosPorFaixaEtaria = BuscaQtdAgendamentoPorFaixaEtaria(Pacientes, Agendamentos);
            return resultado;
        }

        public static Dictionary<string, float>? BuscaMediaDescartePorAtendimento(List<AgendamentoModel> agendamentos, List<DescarteEcologicoModel> descartesEcologicos)
        {
            var resultado = new Dictionary<string, float>();

            foreach (var item in agendamentos)
            {
                if (!resultado.ContainsKey(item.procedimentos))
                {
                    DescarteEcologicoModel descarte = descartesEcologicos.FirstOrDefault(d => d.descarte_id.ToString() == item.descarte_id);
                    resultado.Add(item.procedimentos, descarte.peso);
                }
                else
                {
                    float valor = resultado[item.procedimentos];
                    DescarteEcologicoModel descarte = descartesEcologicos.FirstOrDefault(d => d.descarte_id.ToString() == item.descarte_id);
                    valor += descarte.peso;
                }
            };

            var contagemProcedimentos = agendamentos
                   .GroupBy(a => a.procedimentos)
                   .Select(g => new { Procedimento = g.Key, Contagem = g.Count() })
                   .ToList();

            foreach (var item in contagemProcedimentos)
            {
                if (item.Contagem > 1)
                {
                    resultado[item.Procedimento] = resultado[item.Procedimento] / item.Contagem;
                }
            }

            return resultado;
        }

        public static Dictionary<string, string>? BuscaProcedimentosMaisPedidosPorFaixaEtaria(List<PacienteModel> Pacientes, List<AgendamentoModel> Agendamentos)
        {
            var resultado = new Dictionary<string, string>();

            var consulta = from paciente in Pacientes
                           join agendamento in Agendamentos on paciente.paciente_id.ToString() equals agendamento.paciente_id
                           let idade = DateTime.Now.Year - paciente.datanascimento.Year
                           select new { FaixaEtaria = ObterFaixaEtaria(idade), Procedimento = agendamento.procedimentos };

            var contagemPorFaixa = consulta
                .GroupBy(x => new { x.FaixaEtaria, x.Procedimento })
                .Select(g => new { g.Key.FaixaEtaria, g.Key.Procedimento, Contagem = g.Count() });

            var procedimentoMaisPedidoPorFaixa = contagemPorFaixa
                .GroupBy(x => x.FaixaEtaria)
                .Select(g => new { FaixaEtaria = g.Key, Procedimento = g.OrderByDescending(x => x.Contagem).First().Procedimento });

            foreach (var item in procedimentoMaisPedidoPorFaixa)
            {
                resultado.Add(item.FaixaEtaria, item.Procedimento);
            }

            return resultado;

        }
        public static Dictionary<string, List<string>>? BuscaQtdAgendamentoPorFaixaEtaria(List<PacienteModel> Pacientes, List<AgendamentoModel> Agendamentos) {
           
            var consulta = from paciente in Pacientes
                           join agendamento in Agendamentos on paciente.paciente_id.ToString() equals agendamento.paciente_id
                           let idade = DateTime.Now.Year - paciente.datanascimento.Year
                           select new { FaixaEtaria = ObterFaixaEtaria(idade), Procedimento = agendamento.procedimentos };

            var contagemPorFaixa = consulta
                .GroupBy(x => new { x.FaixaEtaria, x.Procedimento })
                .Select(g => new { g.Key.FaixaEtaria, g.Key.Procedimento, Contagem = g.Count() });

            var top5ProcedimentosPorFaixa = contagemPorFaixa
                .GroupBy(x => x.FaixaEtaria)
                .ToDictionary(
                    g => g.Key,
                    g => g.OrderByDescending(x => x.Contagem)
                          .Take(5)
                          .Select(x => x.Procedimento)
                          .ToList()
                );

            return top5ProcedimentosPorFaixa;
        }
        static string ObterFaixaEtaria(int idade)
        {
            if (idade <= 18)
            {
                return "Criança";
            }
            else if (idade <= 60)
            {
                return "Adulto";
            }
            else
            {
                return "Idoso";
            }
        }
    }
}
