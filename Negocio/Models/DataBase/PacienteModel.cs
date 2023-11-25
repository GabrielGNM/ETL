using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CamadaDeNegocio.Models.DataBase
{
    public class PacienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid paciente_id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? nome { get; set; }

        [Required]
        [MaxLength(255)]
        public string? endereco { get; set; }

        [Required]
        public DateTime datanascimento { get; set; }

        [Required]
        [MaxLength(20)]
        public string? genero { get; set; }

        [Required]
        [MaxLength(20)]
        public string? telefone { get; set; }
    }
}
