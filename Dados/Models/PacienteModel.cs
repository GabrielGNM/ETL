using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CamadaDeDados.Models
{
    public class PacienteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PacienteId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(255)]
        public string Endereco { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [MaxLength(20)]
        public string Genero { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefone { get; set; }
    }
}
