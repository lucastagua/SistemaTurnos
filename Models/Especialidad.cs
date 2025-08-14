using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models

{
public class Especialidad
{
    [Key]
    public int IdEspecialidad { get; set; }
    [StringLength(20, ErrorMessage = "El campo Descripción debe tener como máximo 20 caracteres")]
    [Required( ErrorMessage = "Debe ingresar una Descripción")]
    [Display (Name = "Descripción", Prompt = "Ingrese una descripción")]
    public string Descripcion { get; set; }
    public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }
}
}