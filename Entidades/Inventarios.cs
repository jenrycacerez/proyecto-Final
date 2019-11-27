﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Inventarios
    {
        [Key]
        public int InventarioId { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        [Browsable(false)]
        public int UsuarioId { get; set; }
        public Inventarios()
        {
            InventarioId = 0;
            Cantidad = 0;
            ArticuloId = 0;
            Fecha = DateTime.Now;
            UsuarioId = 0;
        }

    }
}
