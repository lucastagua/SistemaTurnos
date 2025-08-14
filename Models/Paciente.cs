using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Dirección")]
        [Display(Name ="Dirección")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Teléfono")]
        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Email")]
        [EmailAddress (ErrorMessage ="No es un Email Válido")]
        public string Email { get; set; }
        public List<Turno> Turno { get; set; }
    }
}