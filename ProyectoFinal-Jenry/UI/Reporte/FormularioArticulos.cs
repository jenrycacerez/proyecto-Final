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
    public partial class FormularioArticulos : Form
    {
        private List<Articulos> ListaArticulos;
        public FormularioArticulos()
        {
            InitializeComponent();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public FormularioArticulos(List<Articulos> articulos)
        {
            this.ListaArticulos = articulos;
            InitializeComponent();
        }

        private void FormularioArticulos_Load(object sender, EventArgs e)
        {
            rptArticulos oCliente = new rptArticulos();
            oCliente.SetDataSource(ListaArticulos);

            crystalReportViewer.ReportSource = oCliente;
            crystalReportViewer.Refresh();
        }
    }
}
