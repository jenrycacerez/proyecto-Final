using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Jenry.Entidades
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }
        public string Nombres { get; set; }
        public string Contacto { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        [Browsable(false)]

        public string Rnc { get; set; }
        public int UsuarioId { get; set; }

        public Proveedor()
        {
            ProveedorId = 0;
            Nombres = string.Empty;
            Contacto = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
            Telefono = string.Empty;
            Fecha = DateTime.Now;
            Rnc = string.Empty;
            UsuarioId = 0;
        }
    }
}
