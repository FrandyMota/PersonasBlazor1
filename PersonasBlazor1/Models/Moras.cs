using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasBlazor1.Models
{
    public class Moras
    {
        [Key]
        public int MoraId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime Fecha { get; set; }

        public double Total { get; set; }


        [ForeignKey("MoraId")]
        public virtual List<MorasDetalle> MoraDetalle { get; set; } = new List<MorasDetalle>();
    }
}
