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
        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("D_LEGAL")]
        public required DateOnly? DesignacionLegal { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("C_LEGAL")]
        public required DateOnly? CeseLegal { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("D_REAL")]
        public required DateOnly? DesignacionReal { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("C_REAL")]
        public required DateOnly? CeseReal { get; set; }
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
