
using System.ComponentModel.DataAnnotations;

namespace webapi.Domain.Entities
{
    public class TareaDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public EstadoDTO Estado { get; set; }
        public string Codigo { get; set; }
    }
}
