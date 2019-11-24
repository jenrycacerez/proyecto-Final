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
    public partial class FormularioVentas : Form
    {
        private List<Ventas> ListaVentas;
        public FormularioVentas()
        {
            InitializeComponent();
        }

        public FormularioVentas(List<Ventas> ventas)
        {
            this.ListaVentas = ventas;
            InitializeComponent();
        }
        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormularioVentas_Load(object sender, EventArgs e)
        {
            rptVentas oVentas = new rptVentas();
            oVentas.SetDataSource(ListaVentas);

            VisorCrystalReport.ReportSource = oVentas;
            VisorCrystalReport.Refresh();
        }
    }
}
