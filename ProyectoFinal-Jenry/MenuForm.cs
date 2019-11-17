using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal_Jenry.UI.Registros;

namespace ProyectoFinal_Jenry
{
    public partial class MenuForm : Form
    {
        public int id { get; set; }
        public MenuForm(int id)
        {

            this.id = id;
            InitializeComponent();
        }

        private void RegistrosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RegistrosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes rClientes = new rClientes(id);
            rClientes.Show();
        }
    }
}
