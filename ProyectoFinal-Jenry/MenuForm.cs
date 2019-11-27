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
using ProyectoFinal_Jenry.UI.Consultas;


namespace ProyectoFinal_Jenry
{
    public partial class MenuForm : Form
    {
        public int id { get; set; }
        public MenuForm()
        {

        
            InitializeComponent();

            this.Visible = false;
            Login login = new Login();
            login.ShowDialog();
            this.id = login.IdForma;
            if (login.Valido)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        private void RegistrosArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulo rArticulo = new rArticulo(id);
            rArticulo.MdiParent = this;
            rArticulo.StartPosition = FormStartPosition.CenterScreen;
            rArticulo.Show();
        }

        private void RegistrosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes rClientes = new rClientes(id);
            rClientes.MdiParent = this;
            rClientes.StartPosition = FormStartPosition.CenterScreen;
            rClientes.Show();
        }

        private void RegistroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios r = new rUsuarios();
            r.MdiParent = this;
            r.StartPosition = FormStartPosition.CenterScreen;
            r.Show();
        }

        private void RegistroProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProveedor rProveedor = new rProveedor(id);
            rProveedor.MdiParent = this;
            rProveedor.StartPosition = FormStartPosition.CenterScreen;
            rProveedor.Show();
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentas rVentas = new rVentas(id);
            rVentas.MdiParent = this;
            rVentas.StartPosition = FormStartPosition.CenterScreen;
            rVentas.Show();
        }

        private void ColsultasDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVentas cVentas = new cVentas();
            cVentas.MdiParent = this;
            cVentas.StartPosition = FormStartPosition.CenterScreen;
            cVentas.Show();
        }

        private void ConsultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuarios c = new cUsuarios();
            c.MdiParent = this;
            c.StartPosition = FormStartPosition.CenterScreen;
            c.Show();
        }

        private void ConsultasDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cProveedor cProveedor = new cProveedor();
            cProveedor.MdiParent = this;
            cProveedor.StartPosition = FormStartPosition.CenterScreen;
            cProveedor.Show();
        }

        private void ConsultasDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cClientes cClientes = new cClientes();
            cClientes.MdiParent = this;
            cClientes.StartPosition = FormStartPosition.CenterScreen;
            cClientes.Show();
        }

        private void ConsultasDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cArticulo cArticulo = new cArticulo();
            cArticulo.MdiParent = this;
            cArticulo.StartPosition = FormStartPosition.CenterScreen;
            cArticulo.Show();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var select = MessageBox.Show("¿Seguro?", "Rafa Motor Sotfware.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (select == DialogResult.Yes)
                Application.Exit();
        }

        private void DesconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var select = MessageBox.Show("¿Seguro?", "Rafa Motor Sotfware.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (select == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
          
        }

        private void RegistroInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInventarios r = new rInventarios(id);
            r.MdiParent = this;
            r.StartPosition = FormStartPosition.CenterScreen;
            r.Show();

        }
    }
}
