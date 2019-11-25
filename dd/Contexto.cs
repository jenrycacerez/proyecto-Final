using ProyectoFinal_Jenry.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Jenry.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }


        public DbSet<Articulos> Articulos { get; set; }
       
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<VentasDetalles> VentasDetalles { get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
