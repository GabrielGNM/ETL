using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CamadaDeNegocio.Models.DataBase
{
    public class DescarteEcologicoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid descarte_id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? tiporesiduo { get; set; }

        [Required]
        [MaxLength(255)]
        public string? metododescarte { get; set; }

        [Required]
        public DateTime datadescarte { get; set; }
    }
}
