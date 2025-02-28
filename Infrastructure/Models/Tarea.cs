using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webapi.Domain.Entities;

namespace webapi.Infrastructure.Models
{
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Titulo { get; set; }

        [StringLength(255, ErrorMessage = "Máximo 255 caracteres")]
        public string? Descripcion { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public DateTime FechaVencimiento { get; set; }

        [Required]
        [EnumDataType(typeof(EstadoDTO))]
        public EstadoDTO Estado { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Máximo 6 caracteres")]
        public string Codigo { get; set; }
    }
}
