using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasBlazor1.Models
{
    public class MorasDetalle
    {
        [Key]
        public int Id { get; set; }

        public int MoraId { get; set; }

        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [Range(0.0, Double.MaxValue, ErrorMessage = "Este campo debe ser mayor que cero (0).")]
        public double Valor { get; set; }
    }
}
