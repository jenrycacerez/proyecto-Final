using ProyectoFinal_Jenry.BLL;
using ProyectoFinal_Jenry.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
              if (usuario.Exists(x => x.Clave.Equals(Eramake.eCryptography.Encrypt(password))))
              {
                   List<Usuarios> id = Repositorio.GetList(U => U.Usuario == UsuariotextBox.Text);
                   MenuForm f = new MenuForm(id[0].UsuarioId);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Clave incorrecta.", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (UsuariotextBox.Text == string.Empty || ClavetextBox.Text == string.Empty)
                    MessageBox.Show("Ingrese en todos los campos.", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!usuario.Exists(x => x.Usuario.Equals(username)))
                    MessageBox.Show("Usuario no existe.", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
