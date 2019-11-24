using ProyectoFinal_Jenry.BLL;
using ProyectoFinal_Jenry.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
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



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);



        private bool ValidarCampos()
        {
            bool paso = true;

            errorProvider.Clear(); ;


            if (string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                errorProvider.SetError(UsuariotextBox, "Este campo es obligatorio");
                UsuariotextBox.Focus();
                paso = false;
            }


            if (string.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                errorProvider.SetError(ClavetextBox, " Este campo es obligtorio!! ");
                ClavetextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ValidarLogin()
        {
            bool paso = false;

            if (UsuariotextBox.Text == "Admin" && ClavetextBox.Text == "12345678")
            {
                paso = true;
            }

            return paso;
        }


      

        private void Buttonnuevo_Click(object sender, EventArgs e)
        {
           UsuariotextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            errorProvider.Clear();
        }



        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            //Llamar Base de datos pasandole Usuario y Clave
           
            //Si encuentra Registro
         //   Valido = true;
           // this.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (!ValidarLogin())
            {
                MessageBox.Show("Usuario No Valido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MenuForm main = new MenuForm(1);
            Hide();
            main.ShowDialog();
            Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> user = new List<Usuarios>();
            user = Repositorio.GetList(p => true);
            if (user.Count == 0)
            {
                Repositorio.Guardar(new Usuarios()
                {
                    Usuario = "administrador",
                   // Clave = Eramake.eCryptography.Encrypt("administrador"),
                    Nombres = "Jenry Cacerez",
                    Email = "Jenrybrown@hotmail.com",
                    FechaCreacion = DateTime.Now
                });
               // MetroFramework.MetroMessageBox.Show(this, "Al no existir usuario(s) se ha creado uno por defecto.", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                
            }
        }
    }
}
