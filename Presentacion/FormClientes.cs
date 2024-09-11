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
    public partial class FormClientes : Form
    {
        private NCliente nCliente = new NCliente();
        public FormClientes()
        {
            InitializeComponent();
            MostrarClientes(nCliente.ListarTodo());
        }

        private void MostrarClientes(List<Cliente> clientes)
        {
            dgClientes.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                dgClientes.DataSource = clientes;
                dgClientes.Columns["Reserva"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtCelular.Text == "")
            {
                MessageBox.Show("Por favor, complete los campos");
                return;
            }

            if (txtDNI.Text.Length < 8)
            {
                MessageBox.Show("Por favor, ingrese un DNI válido");
                return;
            }

            if (txtCelular.Text.Length < 9)
            {
                MessageBox.Show("Por favor, ingrese un número de celular válido");
                return;
            }

            Cliente cliente = new Cliente()
            {
                Dni = txtDNI.Text,
                Nombre = txtNombre.Text + " " + txtApellido.Text,
                Celular = txtCelular.Text
            };

            String mensaje = nCliente.Registrar(cliente);
            MessageBox.Show(mensaje);

            MostrarClientes(nCliente.ListarTodo());

            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione el Cliente que desea eliminar");
                return;
            }

            string dni = dgClientes.SelectedRows[0].Cells[0].Value.ToString();
            String mensaje = nCliente.Eliminar(dni);
            MessageBox.Show(mensaje);

            MostrarClientes(nCliente.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
