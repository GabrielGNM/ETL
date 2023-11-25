using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CamadaDeNegocio.Models.DataBase
{
    public class AgendamentoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid agendamento_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? paciente_id { get; set; }

        [Required]
        public int procedimento_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? descarte_id { get; set; }

        [Required]
        public DateTime dataagendamento { get; set; }

        [Required]
        [MaxLength(20)]
        public string? statusagendamento { get; set; }

    }
}
