using ProyectoFinal_Jenry.BLL;
using ProyectoFinal_Jenry.DAL;
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

namespace ProyectoFinal_Jenry.UI.Registros
{
    public partial class rProveedor : Form
    {
        private int id;
        public rProveedor(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Limpiar()
        {

            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            ContactotextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            TlfmaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            RnctextBox.Text = string.Empty;
            MyErrorProvider.Clear();

        }

        private Proveedor LlenaClase()
        {
            Proveedor p = new Proveedor();
            p.ProveedorId = Convert.ToInt32(IDnumericUpDown.Value);
            p.Fecha = FechadateTimePicker.Value;
            p.Nombres = NombrestextBox.Text;
            p.Contacto = ContactotextBox.Text;
            p.Email = EmailtextBox.Text;
            p.Telefono = TlfmaskedTextBox.Text;
            p.Direccion = DirecciontextBox.Text;
            p.Rnc = RnctextBox.Text;
            p.UsuarioId = id;
            return p;
        }

        private void LlenaCampo(Proveedor p)
        {
            IDnumericUpDown.Value = p.ProveedorId;
            FechadateTimePicker.Value = p.Fecha;
            NombrestextBox.Text = p.Nombres;
            ContactotextBox.Text = p.Contacto;
            EmailtextBox.Text = p.Email;
            TlfmaskedTextBox.Text = p.Telefono;
            DirecciontextBox.Text = p.Direccion;
            RnctextBox.Text = p.Rnc;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Proveedor> Repositorio = new RepositorioBase<Proveedor>();
            Proveedor p = Repositorio.Buscar((int)IDnumericUpDown.Value);
            return (p != null);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedor> Repositorio = new RepositorioBase<Proveedor>();
            Proveedor p = new Proveedor();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Limpiar();

            p = Repositorio.Buscar(id);
            if (p != null)
                LlenaCampo(p);
            else
                MessageBox.Show("No encontrado.");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public static bool RepetirProveedor(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Proveedor.Any(p => p.Nombres.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool RepetirEmail(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Proveedor.Any(p => p.Email.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool RepetirTelefono(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Proveedor.Any(p => p.Telefono.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool RepetirDireccion(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Proveedor.Any(p => p.Direccion.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool RepetirContacto(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Proveedor.Any(p => p.Contacto.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                MyErrorProvider.SetError(NombrestextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyErrorProvider.SetError(EmailtextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ContactotextBox.Text))
            {
                MyErrorProvider.SetError(ContactotextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                MyErrorProvider.SetError(DirecciontextBox, "No puede ser vacio.");
                paso = false;
            }
            if (!TlfmaskedTextBox.MaskCompleted)
            {
                MyErrorProvider.SetError(TlfmaskedTextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(RnctextBox.Text))
            {
                MyErrorProvider.SetError(RnctextBox, "No puede ser vacio.");
                paso = false;
            }
            return paso;
        }
        private bool ValidarRepeticion()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (RepetirProveedor(NombrestextBox.Text))
            {
                MyErrorProvider.SetError(NombrestextBox, "No se pueden repetir.");
                paso = false;
            }
            if (RepetirContacto(ContactotextBox.Text))
            {
                MyErrorProvider.SetError(ContactotextBox, "No se pueden repetir.");
                paso = false;
            }
            if (RepetirEmail(EmailtextBox.Text))
            {
                MyErrorProvider.SetError(EmailtextBox, "No se pueden repetir.");
                paso = false;
            }
            if (RepetirTelefono(TlfmaskedTextBox.Text))
            {
                MyErrorProvider.SetError(TlfmaskedTextBox, "No se pueden repetir.");
                paso = false;
            }
            if (RepetirDireccion(DirecciontextBox.Text))
            {
                MyErrorProvider.SetError(DirecciontextBox, "No se pueden repetir.");
                paso = false;
            }
            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedor> Repositorio = new RepositorioBase<Proveedor>();
            Proveedor p = new Proveedor();
            bool paso = false;

            if (!Validar())
                return;


            p = LlenaClase();


            if (IDnumericUpDown.Value == 0)
            {
                if (!ValidarRepeticion())
                    return;

                paso = Repositorio.Guardar(p);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Repositorio.Modificar(p);
            }

            if (paso)
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Proveedor> Repositorio = new RepositorioBase<Proveedor>();

            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (Repositorio.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No existe.");
        }
    }
}
