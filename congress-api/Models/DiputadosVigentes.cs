using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace congress_api.Models
{
    public class DiputadosVigentes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? IdRepresentante { get; set; }
        [Required]
        public required string Id { get; set; }
        [Required]
        [MaxLength(150)]
        [JsonProperty("bloque")]
        public required string Bloque { get; set; }
        [Required]
        [MaxLength(50)]
        [JsonProperty("diputado_apellido")]
        public required string Apellido { get; set; }
        [Required]
        [MaxLength(100)]
        [JsonProperty("diputado_nombre")]
        public required string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        [JsonProperty("distrito")]
        public required string Provincia { get; set; }
        [Required]
        [MaxLength(15)]
        [JsonProperty("mandato")]
        public required string Mandato { get; set; }
        [Required]
        [MaxLength(15)]
        [JsonProperty("fecha_jura")]
        public required string FechaJura { get; set; }
        [Required]
        [MaxLength(15)]
        [JsonProperty("fecha_inicio")]
        public required string FechaInicio { get; set; }
        [MaxLength(100)]
        public string? Foto { get; set; }
    }
}
