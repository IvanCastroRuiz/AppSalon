using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppSalon.Models;

namespace AppSalon.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {
        }

        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<Cliente> Cliente {get; set;}
        public DbSet<Administrador> Administrador {get; set;}
        public DbSet<Tecnico> Tecnico {get; set;}

        public DbSet<Cita> Cita {get; set;}
        public DbSet<Servicio> Servicio {get; set;}
        public DbSet<CitasServicios> CitasServicios {get; set;}

    }
}