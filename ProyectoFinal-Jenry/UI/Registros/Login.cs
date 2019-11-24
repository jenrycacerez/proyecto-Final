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
        public int IdForma = 0;
        public Login()
        {
            InitializeComponent();
        }



        public void Logins()
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Expression<Func<Usuarios, bool>> filtro = x => true;
            List<Usuarios> usuario = new List<Usuarios>();
            var username = UsuariotextBox.Text;
            var password = ClavetextBox.Text;
            filtro = x => x.Usuario.Equals(username);
            usuario = Repositorio.GetList(filtro);

            if (usuario.Exists(x => x.Usuario.Equals(username)))
            {
                if (usuario[0].Clave== Eramake.eCryptography.Encrypt(password))
                {
       
                    IdForma= usuario[0].UsuarioId;
                    Valido = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta.", "Supermarket Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (Eramake.eCryptography.Encrypt(password) == Eramake.eCryptography.Encrypt("123456") && username.ToLower().Equals("administrador"))
            {
                IdForma = 0;
                Valido = true;
                this.Close();
              
            }
            else
            {
                if (UsuariotextBox.Text == string.Empty || ClavetextBox.Text == string.Empty)
                    MessageBox.Show("Ingrese en todos los campos.", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!usuario.Exists(x => x.Usuario.Equals(username)))
                    MessageBox.Show("Usuario no existe.", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


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

       
       
        private void Button1_Click(object sender, EventArgs e)
        {
            Logins();
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
                    Clave = Eramake.eCryptography.Encrypt("123456"),
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
