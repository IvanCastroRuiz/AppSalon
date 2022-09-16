using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppSalon.Models
{
    public class Tecnico
    {
         [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage = "El tipo identificacion es obligatorio")]
        public string TipoIdentificacion { get; set; }   
        [Required(ErrorMessage = "El numero identificacion es obligatorio")]
        public string NumeroIdentificacion { get; set; }   
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }   
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; }   
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; } 
        [Required(ErrorMessage = "El direccion es obligatorio")]
        public string Direccion { get; set; } 
        [Required(ErrorMessage = "El email es obligatorio")]
        public string Email { get; set; } 
        [Required(ErrorMessage = "El rut es obligatorio")]
        public string Rut { get; set; } 
        [Required(ErrorMessage = "El nivel de estudio es obligatorio")]
        public string NivelEstudio { get; set; }     
        [Required(ErrorMessage = "El numero registro es obligatorio")]
        public string NumeroRegistro { get; set; }     
        public Usuario Usuario { get; set; } 
    }
}