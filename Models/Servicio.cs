using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppSalon.Models
{
    public class Servicio
    {
        [Key]
        public int Id { get; set; }	  
        [Required(ErrorMessage = "El nombre del servicio es obligatorio")]
        public string NombreServicio { get; set; }
        [Required(ErrorMessage = "El precio del servicio es obligatorio")]
        public float PrecioServicio  { get; set; }  
        public bool EstadoServicio  { get; set; }  = true;

    }
}