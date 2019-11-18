using ProyectoFinal_Jenry.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Jenry.UI.Reporte
{
    public partial class FormularioCliente : Form
    {
        private List<Clientes> ListaClientes;
        public FormularioCliente()
        {
            InitializeComponent();
        }

      
        public FormularioCliente(List<Clientes> clientes)
        {
            this.ListaClientes = clientes;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                        
            rptClientes oCliente = new rptClientes();
            oCliente.SetDataSource(ListaClientes);

            VisorCrystalReport.ReportSource = oCliente;
            VisorCrystalReport.Refresh();

          
        }

        private void VisorCrystalReport_Load(object sender, EventArgs e)
        {

        }
    }
}
