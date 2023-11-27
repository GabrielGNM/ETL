using CamadaDeDados;
using CamadaDeDados.Context;
using CamadaDeServico;
using Microsoft.AspNetCore.Mvc;

namespace CamadaDeApresentação.Controllers
{
    [Route("EtlApi/")]
    [ApiController]
    public class PowerBiController : ControllerBase
    {
        [HttpGet("BuscarDadosPowerBi")]
        public IActionResult ExecuteETL()
        {
            try
            {
                using (var context = new ClinicaGardenDbContext())
                {
                    var dataLayer = new AcessoBancoDeDados();
                    var serviceLayer = new ServiceTransform();

                    var resultadoPowerBi = serviceLayer.TransformData(dataLayer.ExtractPacienteData(), dataLayer.ExtractAgendamentoData(), dataLayer.ExtractDescarteEcologicoData());
                    return Ok(resultadoPowerBi);
                }
            }
            catch (Exception ex)
            {
                // Lide com erros aqui
                return StatusCode(500, $"Erro durante o processo ETL: {ex.Message}");
            }
        }
    }
}
