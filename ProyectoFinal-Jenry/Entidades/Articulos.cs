using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Jenry.Entidades
{
   public  class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public int Codigo { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public string Proveedor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public string Seccion { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public decimal Ganancia { get; set; }
        public decimal ITBIS { get; set; }
        public DateTime Vencimiento { get; set; }
        [Browsable(false)]
        public int UsuarioId { get; set; }


        public Articulos()
        {
            ArticuloId = 0;
            Codigo = 0;
            Articulo = string.Empty;
            Cantidad = 0;
            Proveedor = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
            Seccion = string.Empty;
            Precio = 0;
            Costo = 0;
            Ganancia = 0;
            ITBIS = 0;
            Vencimiento = DateTime.Now;
            UsuarioId = 0;
        }
    }
}
