using ProyectoFinal_Jenry.Entidades;
using ProyectoFinal_Jenry.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal_Jenry.UI.Reporte;

namespace ProyectoFinal_Jenry.UI.Consultas
{
    public partial class cArticulo : Form
    {
        private List<Articulos> Lista;
        public cArticulo()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Articulos>();
            RepositorioBase<Articulos> r = new RepositorioBase<Articulos>();

            if (RangocheckBox.Checked == true)
            {
                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = r.GetList(p => true);
                            break;

                        case "ID":
                            int parse;
                            if (!int.TryParse(CriteriotextBox.Text, out parse))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.ArticuloId == id);
                            }
                            break;
                        case "Codigo":
                            int parse2;
                            if (!int.TryParse(CriteriotextBox.Text, out parse2))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int codigo = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Codigo == codigo);
                            }
                            break;
                        case "Producto":
                            listado = r.GetList(p => p.Articulo.Contains(CriteriotextBox.Text));
                            break;
                        case "Proveedor":
                            listado = r.GetList(p => p.Proveedor.Contains(CriteriotextBox.Text));
                            break;
                        //case "Seccion":
                         //   listado = r.GetList(p => p.Seccion.Contains(CriteriotextBox.Text));
                           // break;
                        case "Precio":
                            decimal parse3;
                            if (!decimal.TryParse(CriteriotextBox.Text, out parse3))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                decimal pr = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Precio == pr);
                            }
                            break;
                        case "Costo":
                            decimal parse4;
                            if (!decimal.TryParse(CriteriotextBox.Text, out parse4))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                decimal co = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Costo == co);
                            }
                            break;
                        case "Ganancia":
                            decimal parse5;
                            if (!decimal.TryParse(CriteriotextBox.Text, out parse5))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                decimal ga = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Ganancia == ga);
                            }
                            break;
                        case "Cantidad":
                            int parse6;
                            if (!int.TryParse(CriteriotextBox.Text, out parse6))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int ca = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Cantidad == ca);
                            }
                            break;
                        case "Impuesto":
                            decimal parse7;
                            if (!decimal.TryParse(CriteriotextBox.Text, out parse7))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                decimal im = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.ITBIS == im);
                            }
                            break;

                    }
                   // listado = listado.Where(c => c.Vencimiento.Date >= DesdedateTimePicker.Value.Date && c.Vencimiento.Date <= HastadateTimePicker.Value.Date).ToList();
                }
                else
                {
                    if (FiltrocomboBox.Text == string.Empty)
                    {
                        MessageBox.Show("El filtro no puede estar vacio.");
                    }
                    else
                       if ((string)FiltrocomboBox.Text != "Todo")
                    {
                        if (CriteriotextBox.Text == string.Empty)
                        {
                            MessageBox.Show("Al seleccionar uno diferente de Todo necesita escribir algo en el criterio.");
                        }
                    }
                    listado = r.GetList(p => true);
                  //  listado = listado.Where(c => c.Vencimiento.Date >= DesdedateTimePicker.Value.Date && c.Vencimiento.Date <= HastadateTimePicker.Value.Date).ToList();
                }
                Lista = listado;
                ConsultadataGridView.DataSource = listado;
            }
            else
            {
                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = r.GetList(p => true);
                            break;

                        case "ID":
                            int parse;
                            if (!int.TryParse(CriteriotextBox.Text, out parse))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.ArticuloId == id);
                            }
                            break;
                        case "Codigo":
                            int parse2;
                            if (!int.TryParse(CriteriotextBox.Text, out parse2))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int codigo = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Codigo == codigo);
                            }
                            break;
                        case "Producto":
                            listado = r.GetList(p => p.Articulo.Contains(CriteriotextBox.Text));
                            break;
                        case "Proveedor":
                            listado = r.GetList(p => p.Proveedor.Contains(CriteriotextBox.Text));
                            break;
                        case "Seccion":
                            listado = r.GetList(p => p.Seccion.Contains(CriteriotextBox.Text));
                            break;
                        case "Precio":
                            decimal parse3;
                            if (!decimal.TryParse(CriteriotextBox.Text, out parse3))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                decimal pr = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Precio == pr);
                            }
                            break;
                        case "Costo":
                            decimal parse4;
                            if (!decimal.TryParse(CriteriotextBox.Text, out parse4))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                decimal co = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Costo == co);
                            }
                            break;
                        case "Ganancia":
                            decimal parse5;
                            if (!decimal.TryParse(CriteriotextBox.Text, out parse5))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                decimal ga = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Ganancia == ga);
                            }
                            break;
                        case "Cantidad":
                            int parse6;
                            if (!int.TryParse(CriteriotextBox.Text, out parse6))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int ca = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Cantidad == ca);
                            }
                            break;
                        case "Impuesto":
                            decimal parse7;
                            if (!decimal.TryParse(CriteriotextBox.Text, out parse7))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                decimal im = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.ITBIS == im);
                            }
                            break;
                    }
                }
                else
                {
                    if (FiltrocomboBox.Text == string.Empty)
                    {
                        MessageBox.Show("El filtro no puede estar vacio.");
                    }
                    else
                       if ((string)FiltrocomboBox.Text != "Todo")
                    {
                        if (CriteriotextBox.Text == string.Empty)
                        {
                            MessageBox.Show("Al seleccionar uno diferente de Todo necesita escribir algo en el criterio.");
                        }
                    }
                    else
                    {
                        listado = r.GetList(p => true);
                    }
                }
                Lista = listado;
                ConsultadataGridView.DataSource = listado;
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (ConsultadataGridView.RowCount == 0)
            {
                MessageBox.Show("No se puede imprimir");
                return;
            }
            else
            {
               // var listado = new List<Articulos>();
               // RepositorioBase<Articulos> rListado = new RepositorioBase<Articulos>();
              //  listado = rListado.GetList(p => true);
                FormularioArticulos frm = new FormularioArticulos(Lista);
                frm.ShowDialog();
            }


          
        }
    }
}
