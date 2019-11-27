using Entidades;
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
    public partial class FormularioInventario : Form
    {
        private List<Inventarios> ListaInventarios;
        public FormularioInventario()
        {
            InitializeComponent();
        }

        public FormularioInventario(List<Inventarios> inventarios)
        {
            this.ListaInventarios = inventarios;
            InitializeComponent();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormularioInventario_Load(object sender, EventArgs e)
        {
            ListadoInventario oInventario = new ListadoInventario();
            oInventario.SetDataSource(ListaInventarios);

            VisorCrystalReport.ReportSource = oInventario;
            VisorCrystalReport.Refresh();
        }
    }
}
