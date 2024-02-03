using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace congress_api.Models
{
    public class SenadoresHistoricos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRepresentante { get; set; }

        [Required]
        public required string Id { get; set; }

        [Required]
        [MaxLength(100)]
        [JsonProperty("SENADOR")]
        public required string NombreCompleto { get; set; }

        [MaxLength(100)]
        public required string Reemplazo { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Provincia { get; set; }

        [Required]
        [MaxLength(100)]
        [JsonProperty("PARTIDO POLITICO O ALIANZA")]
        public string? PartidoAlianza { get; set; }

        [Required]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("INICIO PERIODO LEGAL")]
        public required DateOnly? DesignacionLegal { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("CESE PERIODO LEGAL")]
        public required DateOnly? CeseLegal { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("INICIO PERIODO REAL")]
        public required DateOnly? DesignacionReal { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("CESE PERIODO REAL")]
        public required DateOnly? CeseReal { get; set; }

        [MaxLength(1000)]
        public string? Observaciones { get; set; }
    }
}
