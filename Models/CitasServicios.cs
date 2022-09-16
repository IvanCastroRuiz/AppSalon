using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppSalon.Models
{
    public class CitasServicios
    {
        [Key]
        public int Id { get; set; }	   
        public Cita Cita { get; set; }
        public Servicio Servicio { get; set; }

    }
}