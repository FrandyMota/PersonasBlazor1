using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonasBlazor1.Models
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un nombre")]
        public string Nombre { get; set; }

        [Phone(ErrorMessage = "El teléfono debe tener el siguiente formato: 999-999-9999")]
        [StringLength(14, ErrorMessage = "El teléfono debe tener el tamaño correcto", MinimumLength = 10)]
        [Required(ErrorMessage = "Es obligatorio introducir un telefono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una cédula")]
        [StringLength(13, ErrorMessage = "La cédula debe tener el tamaño correcto", MinimumLength = 11)]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una fecha")]
        public DateTime FechaNacimiento { get; set; }
        public double Balance { get;  set; }
    }
}
