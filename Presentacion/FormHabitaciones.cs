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
    public partial class FormHabitaciones : Form
    {
        private NHabitacion nHabitacion = new NHabitacion();
        public FormHabitaciones()
        {
            InitializeComponent();
            MostrarHabitaciones(nHabitacion.ListarTodo());
        }

        private void MostrarHabitaciones(List<Habitacion> habitaciones)
        {
            dgHabitaciones.DataSource = null;
            if (habitaciones.Count == 0)
            {
                return;
            }
            else
            {
                dgHabitaciones.DataSource = habitaciones;
                dgHabitaciones.Columns["Reserva"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNumeroHabitacion.Text == "" || cmbTipoHabitacion.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Por favor, complete los campos");
                return;
            }

            Decimal precio = 0;

            try
            {
                precio = Decimal.Parse(txtPrecio.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Por favor, ingrese un valor numérico válido");
                return;
            }

            Habitacion habitacion = new Habitacion()
            {
                Numero = txtNumeroHabitacion.Text,
                Tipo = cmbTipoHabitacion.Text,
                Precio = precio,
                Estado = "Disponible"
            };

            String mensaje = nHabitacion.Registrar(habitacion);
            MessageBox.Show(mensaje);

            MostrarHabitaciones(nHabitacion.ListarTodo());

            txtNumeroHabitacion.Text = "";
            cmbTipoHabitacion.Text = "";
            txtPrecio.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgHabitaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione la habitación que desea eliminar");
                return;
            }

            string numeroHabitacion = dgHabitaciones.SelectedRows[0].Cells[0].Value.ToString();
            String mensaje = nHabitacion.Eliminar(numeroHabitacion);
            MessageBox.Show(mensaje);

            MostrarHabitaciones(nHabitacion.ListarTodo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
