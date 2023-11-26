// ETLController.cs
using CamadaDeDados;
using CamadaDeDados.Context;
using CamadaDeServico;
using Microsoft.AspNetCore.Mvc;

namespace CamadaDeApresentação.Controllers
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
                using (var context = new ClinicaGardenDbContext())
                {
                    var dataLayer = new AcessoBancoDeDados();
                    var businessLogicLayer = new ServiceTransform();

                    // Extração de dados

                    var pacientes = dataLayer.ExtractPacienteData();

                    foreach (var item in pacientes)
                    {
                        Console.WriteLine(item.nome.ToString());
                    }
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
