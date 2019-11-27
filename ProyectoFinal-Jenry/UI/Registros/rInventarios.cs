using BLL;
using Entidades;
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
    public partial class rInventarios : Form
    {
        private int id;
        public rInventarios(int id)
        {
            this.id = id;
            InitializeComponent();
            Producto();
        }
        private void Producto()
        {
            RepositorioBase<Articulos> db = new RepositorioBase<Articulos>();
            var listado = new List<Articulos>();
            listado = db.GetList(p => true);
            ProductocomboBox.DataSource = listado;
            ProductocomboBox.DisplayMember = "Articulo";
            ProductocomboBox.ValueMember = "ArticuloId";
        }

        private void Limpiar()
        {

            IDnumericUpDown.Value = 0;
            ProductocomboBox.Text = null;
            CantidadnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();

        }

        private Inventarios LlenaClase()
        {
            Inventarios i = new Inventarios();
            i.InventarioId = Convert.ToInt32(IDnumericUpDown.Value);
            i.ArticuloId = Convert.ToInt32(ProductocomboBox.SelectedValue);
            i.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            i.Fecha = FechadateTimePicker.Value;
            i.UsuarioId = id;
            return i;
        }

        private void LlenaCampo(Inventarios i)
        {
            IDnumericUpDown.Value = i.InventarioId;
            ProductocomboBox.SelectedValue = i.ArticuloId;
            CantidadnumericUpDown.Value = i.Cantidad;
            FechadateTimePicker.Value = i.Fecha;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Inventarios> Repositorio = new RepositorioBase<Inventarios>();
            Inventarios i = Repositorio.Buscar((int)IDnumericUpDown.Value);
            return (i != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Inventarios i = new Inventarios();
            bool paso = false;


            if (!Validar())
                return;

            i = LlenaClase();


            if (IDnumericUpDown.Value == 0)
            {
                if (!ValidarRepeticion())
                    return;

                paso = InventarioBLL.Guardar(i);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar.", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = InventarioBLL.Modificar(i);
            }

            if (paso)
                MessageBox.Show("Guardado", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inventarios> Repositorio = new RepositorioBase<Inventarios>();
            Inventarios i = new Inventarios();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Limpiar();

            i = Repositorio.Buscar(id);
            if (i != null)
                LlenaCampo(i);
            else
                MessageBox.Show("No encontrado.");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public static bool RepetirProducto(int descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Inventarios.Any(p => p.ArticuloId.Equals(descripcion)))
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
        private bool ValidarRepeticion()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (RepetirProducto((int)ProductocomboBox.SelectedValue))
            {
                MyErrorProvider.SetError(ProductocomboBox, "No se pueden repetir.");
                paso = false;
            }
            return paso;
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(ProductocomboBox.Text))
            {
                MyErrorProvider.SetError(ProductocomboBox, "No puede ser vacio.");
                paso = false;
            }
            if (CantidadnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CantidadnumericUpDown, "No puede ser 0.");
                paso = false;
            }
            if (FechadateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechadateTimePicker, "No puede ser despues que hoy.");
                paso = false;
            }
            return paso;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            MyErrorProvider.Clear();


            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (InventarioBLL.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No existe.");
        }
    }
}
