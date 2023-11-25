using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CamadaDeNegocio.Models.DataBase
{
    public class DescarteEcologicoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DescarteId { get; set; }

        [Required]
        [MaxLength(255)]
        public string TipoResiduo { get; set; }

        [Required]
        [MaxLength(255)]
        public string MetodoDescarte { get; set; }

        [Required]
        public DateTime DataDescarte { get; set; }
    }
}
