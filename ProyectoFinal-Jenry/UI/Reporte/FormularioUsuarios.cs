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
    public partial class FormularioUsuarios : Form
    {
        private List<Usuarios> ListaClientes;
        public FormularioUsuarios()
        {
            InitializeComponent();
        }

        public FormularioUsuarios(List<Usuarios> usuarios)
        {
            this.ListaClientes = usuarios;
            InitializeComponent();
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {

            rptUsuarios oUsuarios = new rptUsuarios();
            oUsuarios.SetDataSource(ListaClientes);

            VisorCrystalReport.ReportSource = oUsuarios;
            VisorCrystalReport.Refresh();
        }
    }
}
