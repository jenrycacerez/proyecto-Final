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
    public partial class FormularioFacturas : Form
    {
        private List<VentasDetalles> ListaFactura;
        public FormularioFacturas()
        {
            InitializeComponent();
        }

        public FormularioFacturas(List<VentasDetalles> ventasD)
        {
            this.ListaFactura = ventasD;
            InitializeComponent();
        }
        private void FormularioFacturas_Load(object sender, EventArgs e)
        {
            rptFacturas oFacturas = new rptFacturas();
            oFacturas.SetDataSource(ListaFactura);

            crystalReportViewer.ReportSource = oFacturas;
            crystalReportViewer.Refresh();
        }
    }
}
