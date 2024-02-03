using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace congress_api.Models
{
    public class DiputadosHistoricos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? IdRepresentante { get; set; }

        [Required]
        public required string Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        [JsonProperty("diputado_apellido")]
        public required string Apellido { get; set; }
        
        [Required]
        [MaxLength(100)]
        [JsonProperty("diputado_nombre")]
        public required string Nombre { get; set; }

        [MaxLength(50)]
        [JsonProperty("diputado_genero")]
        public required string Genero { get; set; }

        [Required]
        [MaxLength(100)]
        [JsonProperty("distrito")]
        public required string Distrito { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("inicio_mandato")]
        public required DateOnly? InicioMandato { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("fin_mandato")]
        public required DateOnly? FinMandato { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("juramento_fecha")]
        public required DateOnly? FechaJura { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("cese")] // Descifrar que significa este campo
        public required DateOnly? Cese { get; set; }

        [Required]
        [MaxLength(150)]
        [JsonProperty("bloque")]
        public required string Bloque { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("bloque_inicio")]
        public required DateOnly? BloqueInicio { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        [JsonProperty("bloque_fin")]
        public required DateOnly? BloqueFin { get; set; }
    }
}
