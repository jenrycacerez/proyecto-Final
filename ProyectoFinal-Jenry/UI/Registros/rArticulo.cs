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
    public partial class rArticulo : Form
    {
        private int id;
        public rArticulo(int id)
        {
            this.id = id;
            Proveedore();
            InitializeComponent();
        }

        private void Proveedore()
        {
            RepositorioBase<Proveedor> db = new RepositorioBase<Proveedor>();
            var listado = new List<Proveedor>();
            listado = db.GetList(p => true);
            ProveedorcomboBox.DataSource = listado;
            ProveedorcomboBox.DisplayMember = "Nombres";
            ProveedorcomboBox.ValueMember = "ProveedorId";
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> Repositorio = new RepositorioBase<Articulos>();
            Articulos p = new Articulos();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Limpiar();

            p = Repositorio.Buscar(id);
            if (p != null)
                LlenaCampo(p);
            else
                MessageBox.Show("No encontrado.");
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Articulos> Repositorio = new RepositorioBase<Articulos>();
            Articulos p = Repositorio.Buscar((int)IDnumericUpDown.Value);
            return (p != null);
        }

        private void AddProveedorbutton_Click(object sender, EventArgs e)
        {
            rProveedor r = new rProveedor(id);
            r.ShowDialog();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            CodigonumericUpDown.Value = 0;
            ArticulotextBox.Text = null;
            ProveedorcomboBox.Text = null;
            CantidadtextBox.Text = null;
            MarcatextBox.Text = string.Empty;
            ModelotextBox.Text = string.Empty;
            PrecionumericUpDown.Value = 0;
            CostonumericUpDown.Value = 0;
            GananciatextBox.Text = string.Empty;
            ItbistextBox.Text = string.Empty;
            ItbiscomboBox.Text = string.Empty;

            MyErrorProvider.Clear();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void LlenaCampo(Articulos p)
        {
            IDnumericUpDown.Value = p.ArticuloId;
            CodigonumericUpDown.Value = p.Codigo;
            ArticulotextBox.Text = p.Articulo;
            ProveedorcomboBox.Text = p.Proveedor;
            
            CantidadtextBox.Text = p.Cantidad.ToString();
            MarcatextBox.Text = p.Marca;
            ModelotextBox.Text = p.Modelo;

            PrecionumericUpDown.Value = p.Precio;
            CostonumericUpDown.Value = p.Costo;
            GananciatextBox.Text = p.Ganancia.ToString();
            ItbistextBox.Text = p.ITBIS.ToString();
          
        }
        private Articulos LlenaClase()
        {
            Articulos p = new Articulos();
            p.ArticuloId = Convert.ToInt32(IDnumericUpDown.Value);
            p.Codigo = Convert.ToInt32(CodigonumericUpDown.Value);
            p.Articulo = ArticulotextBox.Text;
            p.Proveedor = ProveedorcomboBox.Text;
            
            p.Precio = PrecionumericUpDown.Value;
            p.Marca = MarcatextBox.Text;
            p.Modelo = ModelotextBox.Text;
            p.Costo = CostonumericUpDown.Value;
            p.Ganancia = Convert.ToDecimal(GananciatextBox.Text);
            p.ITBIS = Convert.ToDecimal(ItbistextBox.Text);
            
            p.UsuarioId = id;
            return p;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> Repositorio = new RepositorioBase<Articulos>();

            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (Repositorio.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No existe.");
        }

        public static bool RepetirProducto(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Articulos.Any(p => p.Articulo.Equals(descripcion)))
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
        public static bool RepetirCodigo(int descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Articulos.Any(p => p.Codigo.Equals(descripcion)))
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

            if (RepetirCodigo((int)CodigonumericUpDown.Value))
            {
                MyErrorProvider.SetError(CodigonumericUpDown, "No se pueden repetir.");
                paso = false;
            }
            if (RepetirProducto(ArticulotextBox.Text))
            {
                MyErrorProvider.SetError(ArticulotextBox, "No se pueden repetir.");
                paso = false;
            }
            return paso;
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(ArticulotextBox.Text))
            {
                MyErrorProvider.SetError(ArticulotextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ProveedorcomboBox.Text))
            {
                MyErrorProvider.SetError(ProveedorcomboBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(MarcatextBox.Text))
            {
                MyErrorProvider.SetError(MarcatextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ModelotextBox.Text))
            {
                MyErrorProvider.SetError(ModelotextBox, "No puede ser vacio.");
                paso = false;
            }

            if (PrecionumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(PrecionumericUpDown, "No puede ser 0.");
                paso = false;
            }
            if (CostonumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CostonumericUpDown, "No puede ser 0.");
                paso = false;
            }
            if (CostonumericUpDown.Value > PrecionumericUpDown.Value)
            {
                MyErrorProvider.SetError(CostonumericUpDown, "Costo no puede ser mayor que Precio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ItbiscomboBox.Text))
            {
                MyErrorProvider.SetError(ItbiscomboBox, "No puede ser vacio.");
                paso = false;
            }
            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Articulos> Repositorio = new RepositorioBase<Articulos>();
           Articulos p = new Articulos();
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

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal defecto = 0;

            if (PrecionumericUpDown.Value > CostonumericUpDown.Value)
                GananciatextBox.Text = Convert.ToString(PrecionumericUpDown.Value - CostonumericUpDown.Value);
            else
                GananciatextBox.Text = defecto.ToString();
        }

        private void CostonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PrecionumericUpDown.Value > CostonumericUpDown.Value)
                GananciatextBox.Text = Convert.ToString(PrecionumericUpDown.Value - CostonumericUpDown.Value);
            else
                GananciatextBox.Text = "0";
        }

        private void ItbiscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            double exento = 0;
            double itbis16 = 0.16;
            double itbis18 = 0.18;

            if (ItbiscomboBox.Text == "Exento")
                ItbistextBox.Text = Convert.ToString(exento);
            else
            {
                if (PrecionumericUpDown.Value > 0)
                {
                    if (ItbiscomboBox.Text == "16%")
                        ItbistextBox.Text = Convert.ToString(PrecionumericUpDown.Value * (decimal)itbis16);
                    if (ItbiscomboBox.Text == "18%")
                        ItbistextBox.Text = Convert.ToString(PrecionumericUpDown.Value * (decimal)itbis18);
                }
            }
        }
    }
}
