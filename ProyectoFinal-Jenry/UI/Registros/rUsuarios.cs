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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {

            IDnumericUpDown.Value = 0;
            FechaCreaciondateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            NombreUsuariotextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            ConfirmartextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            MyErrorProvider.Clear();

        }
        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = Convert.ToInt32(IDnumericUpDown.Value);
            usuarios.Nombres = NombrestextBox.Text;
            usuarios.Usuario = NombreUsuariotextBox.Text;
            usuarios.Clave = Eramake.eCryptography.Encrypt(ClavetextBox.Text);
            usuarios.Email = EmailtextBox.Text;
            usuarios.FechaCreacion = FechaCreaciondateTimePicker.Value;

            return usuarios;
        }


        private void LlenaCampo(Usuarios usuarios)
        {
            IDnumericUpDown.Value = usuarios.UsuarioId;
            NombrestextBox.Text = usuarios.Nombres;
            NombreUsuariotextBox.Text = usuarios.Usuario;
            ClavetextBox.Text = Eramake.eCryptography.Decrypt(usuarios.Clave); 
            ConfirmartextBox.Text = Eramake.eCryptography.Decrypt(usuarios.Clave); 
            EmailtextBox.Text = usuarios.Email;
            FechaCreaciondateTimePicker.Value = usuarios.FechaCreacion;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = Repositorio.Buscar((int)IDnumericUpDown.Value);
            return (usuarios != null);
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            Limpiar();

            usuarios = Repositorio.Buscar(id);
            if (usuarios != null)
                LlenaCampo(usuarios);
            else
                MessageBox.Show("No encontrado.");
        }
        
        public static bool RepetirUser(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Usuarios.Any(p => p.Usuario.Equals(descripcion)))
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
                if (db.Usuarios.Any(p => p.Email.Equals(descripcion)))
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
        private bool ValidarRepetir()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (RepetirUser(NombreUsuariotextBox.Text))
            {
                MyErrorProvider.SetError(NombreUsuariotextBox, "No se debe repetir los usuarios.");
                paso = false;
            }
            if (RepetirEmail(EmailtextBox.Text))
            {
                MyErrorProvider.SetError(EmailtextBox, "No se debe usar el mismo email que otro.");
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
            if (string.IsNullOrWhiteSpace(NombreUsuariotextBox.Text))
            {
                MyErrorProvider.SetError(NombreUsuariotextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                MyErrorProvider.SetError(ClavetextBox, "No puede ser vacio.");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                MyErrorProvider.SetError(EmailtextBox, "No puede ser vacio.");
                paso = false;
            }
            if (FechaCreaciondateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaCreaciondateTimePicker, "No se puede registrar esta fecha.");
                paso = false;
            }
            if (ConfirmartextBox.Text != ClavetextBox.Text)
            {
                MyErrorProvider.SetError(ConfirmartextBox, "La clave no coincide.");
                paso = false;
            }
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuarios = new Usuarios();

            bool paso = false;

            if (!Validar())
                return;

            usuarios = LlenaClase();

            if (IDnumericUpDown.Value == 0)
            {
                if (!ValidarRepetir())
                    return;
                paso = Repositorio.Guardar(usuarios);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Repositorio.Modificar(usuarios);
            }

            if (paso)
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();

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
