using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Direccion")]
        [Display(Name ="Dirección")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Debe Ingresar un Telefono")]
        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }
        [Required (ErrorMessage = "Debe Ingresar un Email")]
        [EmailAddress (ErrorMessage ="No es un Email Válido")]
        public string Email { get; set; }
        [Display (Name = "Horario desde...")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionDesde { get; set; }
        [Display (Name = "Horario hasta...")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime HorarioAtencionHasta { get; set; }
        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }
        public List<Turno> Turno { get; set; }
    }
}