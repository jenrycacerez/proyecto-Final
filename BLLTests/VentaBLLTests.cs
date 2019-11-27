using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Jenry.BLL;
using ProyectoFinal_Jenry.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Jenry.BLL.Tests
{
    [TestClass()]
    public class VentaBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Ventas v = new Ventas();
            v.VentaId = 0;
            v.Cliente = "Jenry";
            v.Modo = "Tarjeta";
            v.Itbis = 18;
            v.Subtotal = 90;
            v.Total = 90;
            v.Fecha = DateTime.Now;
            v.UsuarioId = 1;
            v.Clienteid = 1;
            paso = VentaBLL.Guardar(v);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso = false;
            paso = VentaBLL.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
        }
    }
}