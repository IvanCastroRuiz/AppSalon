using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AppSalon.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }        
         [Required(ErrorMessage = "El usuario es obligatorio")]
        public string Username { get; set; }        
        [Required(ErrorMessage = "La contraseña es obligatorio")]
        public string Password { get; set; }        
        [Required(ErrorMessage = "El privilegio es obligatorio")]
        public string Privilegio { get; set; }   
        public bool Activo { get; set; } = true;       
   
    }
}