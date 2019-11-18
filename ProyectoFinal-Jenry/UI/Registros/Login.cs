using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Jenry.UI.Registros
{
    public partial class Login : Form
    {
        public bool Valido = false;
        public Login()
        {
            InitializeComponent();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            //Llamar Base de datos pasandole Usuario y Clave

            //Si encuentra Registro
            Valido = true;
            this.Close();

        }
    }
}
