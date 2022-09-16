using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppSalon.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }	
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime Hora { get; set; }
        public Cliente Cliente { get; set; } 
        public Tecnico Tecnico { get; set; } 
        public Administrador Administrador { get; set; } 
        public bool EstadoCita  { get; set; }  = true;
        public float TotalServicio  { get; set; }  
        public float Comision  { get; set; }  
        
    }
}