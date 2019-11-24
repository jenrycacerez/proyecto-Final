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
    public partial class FormularioFactura : Form
    {
        private List<VentasDetalles> ListaFactura;
        public FormularioFactura()
        {
            InitializeComponent();
        }
        public FormularioFactura(List<VentasDetalles> ventasD)
        {
            this.ListaFactura = ventasD;
            InitializeComponent();
        }
        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormularioFactura_Load(object sender, EventArgs e)
        {
            rptFactura oFactura = new rptFactura();
            oFactura.SetDataSource(ListaFactura);

            crystalReportViewer.ReportSource = oFactura;
            crystalReportViewer.Refresh();
        }
    }
}
