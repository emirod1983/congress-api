using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace congress_api.Models
{
    public class ReprCamaraAlta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? IdRepresentante { get; set; }
        [Required]
        public required string Id { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Bloque { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Apellido { get; set; }
        [Required]
        [MaxLength(100)]
        public required string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        public required string Provincia { get; set; }
        [MaxLength(100)]
        [JsonProperty("PARTIDO O ALIANZA")]
        public string? PartidoAlianza { get; set; }
        [Required]
        [MaxLength(15)]
        public required string D_Legal { get; set; }
        [Required]
        [MaxLength(15)]
        public required string C_Legal { get; set; }
        [Required]
        [MaxLength(15)]
        public required string D_Real { get; set; }
        [Required]
        [MaxLength(15)]
        public required string C_Real { get; set; }
        [MaxLength(100)]
        public string? Email { get; set; }
        [MaxLength(100)]
        public string? Telefono { get; set; }
        [MaxLength(100)]
        public string? Foto { get; set; }
        [MaxLength(100)]
        public string? Facebook { get; set; }
        [MaxLength(100)]
        public string? Twitter { get; set; }
        [MaxLength(100)]
        public string? Instagram { get; set; }
        [MaxLength(100)]
        public string? Youtube { get; set; }
    }
}
