using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Jenry.Entidades
{
    public class VentasDetalles
    {
        [Key]
        [Browsable(false)]
        public int VentaDetalleId { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Impuesto { get; set; }

        public VentasDetalles()
        {
            VentaDetalleId = 0;
            Precio = 0;
            Cantidad = 0;
            Impuesto = 0;
            ProductoId = 0;
        }
    }
}
