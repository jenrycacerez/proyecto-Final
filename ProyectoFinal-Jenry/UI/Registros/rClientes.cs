﻿using ProyectoFinal_Jenry.BLL;
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
    public partial class rClientes : Form
    {
        private int id;
        public rClientes(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            TlfmaskedTextBox.Text = string.Empty;
            ClmaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes c = new Clientes();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Limpiar();

            c = Repositorio.Buscar(id);
            if (c != null)
                LlenaCampo(c);
            else
                MessageBox.Show("No encontrado.");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenaCampo(Clientes c)
        {
            IDnumericUpDown.Value = c.ClienteId;
            FechadateTimePicker.Value = c.Fecha;
            NombrestextBox.Text = c.Nombres;
            CedulamaskedTextBox.Text = c.Cedula;
            TlfmaskedTextBox.Text = c.Telefono;
            ClmaskedTextBox.Text = c.Telefono;
            DirecciontextBox.Text = c.Direccion;
            EmailtextBox.Text = c.Direccion;
        }
        private Clientes LlenaClase()
        {
            Clientes c = new Clientes();
            c.ClienteId = Convert.ToInt32(IDnumericUpDown.Value);
            c.Fecha = FechadateTimePicker.Value;
            c.Nombres = NombrestextBox.Text;
            c.Cedula = CedulamaskedTextBox.Text;
            c.Telefono = TlfmaskedTextBox.Text;
            c.Celular = ClmaskedTextBox.Text;
            c.Direccion = DirecciontextBox.Text;
            c.Email = EmailtextBox.Text;
            c.UsuarioId = id;
            return c;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes c = Repositorio.Buscar((int)IDnumericUpDown.Value);
            return (c != null);
        }

        public static bool RepetirNombre(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Clientes.Any(p => p.Nombres.Equals(descripcion)))
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
        public static bool RepetirCedula(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Clientes.Any(p => p.Cedula.Equals(descripcion)))
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
                if (db.Clientes.Any(p => p.Telefono.Equals(descripcion)))
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

            if (RepetirNombre(NombrestextBox.Text) || RepetirCedula(CedulamaskedTextBox.Text) || RepetirTelefono(TlfmaskedTextBox.Text))
            {
                MessageBox.Show("Ya existe uno igual, escriba otro.", "Rafa Motor Racing", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                paso = false;
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
            if (!ClmaskedTextBox.MaskCompleted)
            {
                MyErrorProvider.SetError(ClmaskedTextBox, "No puede ser vacio.");
                paso = false;
            }
            if (!CedulamaskedTextBox.MaskCompleted)
            {
                MyErrorProvider.SetError(CedulamaskedTextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyErrorProvider.SetError(EmailtextBox, "No puede ser vacio.");
                paso = false;
            }
            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes c = new Clientes();
            bool paso = false;
            if (!Validar())
                return;

            c = LlenaClase();


            if (IDnumericUpDown.Value == 0)
            {
                if (!ValidarRepeticion())
                    return;
                paso = Repositorio.Guardar(c);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Repositorio.Modificar(c);
            }

            if (paso)
                MessageBox.Show("Guardado", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar", "Rafa Motor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();

            MyErrorProvider.Clear();

            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            if (Repositorio.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                MyErrorProvider.SetError(IDnumericUpDown, "No existe.");
        }

        private void NombrestextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
