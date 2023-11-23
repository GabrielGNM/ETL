using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CamadaDeDados.Models
{
    public class AgendamentoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AgendamentoId { get; set; }

        [Required]
        [MaxLength(50)]
        public string PacienteId { get; set; }

        [Required]
        public int ProcedimentoId { get; set; }

        [Required]
        [MaxLength(50)]
        public string DescarteId { get; set; }

        [Required]
        public DateTime DataAgendamento { get; set; }

        [Required]
        [MaxLength(20)]
        public string StatusAgendamento { get; set; }

    }
}
