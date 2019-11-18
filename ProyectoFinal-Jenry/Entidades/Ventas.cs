﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Jenry.Entidades
{
   public  class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public string Cliente { get; set; }
        public string Modo { get; set; }
        public decimal Itbis { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        [Browsable(false)]
        public int UsuarioId { get; set; }

        public int Clienteid { get; set; }
        public virtual List<VentasDetalles> Detalle { get; set; }
        public Ventas()
        {
            VentaId = 0;
            UsuarioId = 0;
            Cliente = string.Empty;
            Modo = string.Empty;
            Itbis = 0;
            Subtotal = 0;
            Total = 0;
            Fecha = DateTime.Now;
            Clienteid = 0;
            Detalle = new List<VentasDetalles>();
        }
    }
}
