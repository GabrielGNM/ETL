// ETLController.cs
namespace CamadaDeApresentacao.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ETLController : ControllerBase
    {
        [HttpGet]
        public IActionResult ExecuteETL()
        {
            try
            {
                using (var context = new ETLContext())
                {
                    // Extrair dados das tabelas
                    var pacientes = context.Pacientes.ToList();
                    var descartesEcologicos = context.DescartesEcologicos.ToList();

                    // Transformar dados
                    var etlProcessor = new ETLProcessor();
                    var agendamentos = etlProcessor.Transform(pacientes, descartesEcologicos);

                    // Carregar dados na tabela de agendamentos
                    context.Agendamentos.AddRange(agendamentos);
                    context.SaveChanges();
                }

                return Ok("Processo ETL concluído com sucesso!");
            }
            catch (Exception ex)
            {
                // Lide com erros aqui
                return StatusCode(500, $"Erro durante o processo ETL: {ex.Message}");
            }
        }
    }
}
