using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
        private NUsuario nUsuario = new NUsuario();
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContrasena.Text == "")
            {
                MessageBox.Show("Por favor, complete los campos de inicio de sesión");
                return;
            }

            String usuario = txtUsuario.Text;
            String contraseña = txtContrasena.Text;

            bool inicio = nUsuario.IniciarSesion(usuario, contraseña);
            if (!inicio)
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos. Vuelva a intentar.");
                return;
            }

            List<Usuario> usuarios = nUsuario.ListarTodo();
            Usuario us = usuarios.Find(u => u.Usuario1.Equals(usuario));

            FormMenu f = new FormMenu(us);
            f.Show();
        }
    }
}
