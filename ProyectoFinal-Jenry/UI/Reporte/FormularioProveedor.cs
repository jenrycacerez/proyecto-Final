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
    public partial class FormularioProveedor : Form
    {
        private List<Proveedor> ListaProveedor;
        public FormularioProveedor()
        {
            InitializeComponent();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public FormularioProveedor(List<Proveedor> proveedor)
        {
            this.ListaProveedor = proveedor;
            InitializeComponent();
        }

        private void FormularioProveedor_Load(object sender, EventArgs e)
        {
            rptProveedor oProveedor = new rptProveedor();
            oProveedor.SetDataSource(ListaProveedor);

            VisorCrystalReport.ReportSource = oProveedor;
            VisorCrystalReport.Refresh();

        }
    }
}
