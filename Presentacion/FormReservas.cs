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
    public partial class FormReservas : Form
    {
        Usuario usuario;
        private NReserva nReserva = new NReserva();
        private NCliente nCliente = new NCliente();
        private NHabitacion nHabitacion = new NHabitacion();
        public FormReservas(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            MostrarClientes(nCliente.ListarTodo());
            MostrarReservas(nReserva.ListarTodo());
            if (dateFechaDeEntrada.Value == null || dateFechaDeSalida.Value == null)
            {
                return;
            }
            else
            {
                nHabitacion.VerHabitacionesDisponibles(dateFechaDeEntrada.Value, dateFechaDeSalida.Value);
                MostrarHabitaciones(nHabitacion.ListarTodo());
            }
        }

        private void MostrarClientes(List<Cliente> clientes)
        {
            cmbCliente.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                cmbCliente.DataSource = clientes;
                cmbCliente.ValueMember = "Dni";
                cmbCliente.DisplayMember = "Nombre";
            }
        }

        private void MostrarHabitaciones(List<Habitacion> habitaciones)
        {
            List<String> habitacionesTemp = new List<string>();
            cmbHabitacion.Items.Clear();

            foreach (Habitacion habitacion in habitaciones)
            {
                string NumeroHabitacion = habitacion.Numero.ToString();
                habitacionesTemp.Add(NumeroHabitacion);
            }

            foreach (String habitacion in habitacionesTemp)
            {
                cmbHabitacion.Items.Add(habitacion);
            }
        }

        private void MostrarReservas(List<Reserva> reservas)
        {
            dgReservas.DataSource = null;
            if (reservas.Count == 0)
            {
                return;
            }
            else
            {
                dgReservas.DataSource = reservas;
                dgReservas.Columns["Cliente1"].Visible = false;
                dgReservas.Columns["Habitacion1"].Visible = false;
                dgReservas.Columns["Usuario1"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || cmbCliente.Text == "" || cmbHabitacion.Text == "")
            {
                MessageBox.Show("Por favor, complete los campos");
                return;
            }

            int codigo = 0;

            try
            {
                codigo = int.Parse(txtCodigo.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Por favor, ingrese un valor numérico");
                return;
            }

            List<Habitacion> habitaciones = nHabitacion.ListarTodo();
            Habitacion habitacion = habitaciones.Find(h => h.Numero.Equals(cmbHabitacion.Text));
            decimal Precio = habitacion.Precio;
            DateTime FechaEntrada = dateFechaDeEntrada.Value.Date;
            DateTime FechaSalida = dateFechaDeSalida.Value.Date;

            TimeSpan tSpan = FechaSalida - FechaEntrada;

            decimal Dias = tSpan.Days;

            decimal MontoTemp = Precio * Dias;

            string cliente1 = cmbCliente.SelectedValue.ToString();
            string habitacion1 = cmbHabitacion.Text;
            string usuario1 = usuario.Usuario1.ToString();

            Reserva reserva = new Reserva()
            {
                Codigo = txtCodigo.Text,
                Cliente = cliente1,
                Habitacion = habitacion1,
                Fecha_Entrada = DateTime.Parse(dateFechaDeEntrada.Text),
                Fecha_Salida = DateTime.Parse(dateFechaDeSalida.Text),
                Monto_Total = MontoTemp,
                Usuario = usuario1
            };

            String mensaje = nReserva.Registrar(reserva);
            MessageBox.Show(mensaje);

            MostrarReservas(nReserva.ListarTodo());
            habitacion.Estado = "Ocupada";
            nHabitacion.Modificar(habitacion);
            MostrarHabitaciones(nHabitacion.ListarTodo());

            txtCodigo.Text = "";
            cmbCliente.Text = "";
            cmbHabitacion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione la reserva que desea eliminar");
                return;
            }

            string codigoReserva = dgReservas.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar la reserva con el Código: " + codigoReserva, "", MessageBoxButtons.YesNo);

            if (dialog.Equals(DialogResult.Yes))
            {
                String mensaje = nReserva.Eliminar(codigoReserva);
                MessageBox.Show(mensaje);

                MostrarReservas(nReserva.ListarTodo());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateFechaDeEntrada_ValueChanged(object sender, EventArgs e)
        {
            dateFechaDeSalida.MinDate = dateFechaDeEntrada.Value;
            if (dateFechaDeEntrada.Value == null || dateFechaDeSalida.Value == null)
            {
                return;
            }
            else
            {
                nHabitacion.VerHabitacionesDisponibles(dateFechaDeEntrada.Value, dateFechaDeSalida.Value);
                MostrarHabitaciones(nHabitacion.ListarTodo());
            }
        }

        private void dateFechaDeSalida_ValueChanged(object sender, EventArgs e)
        {
            if (dateFechaDeEntrada.Value == null || dateFechaDeSalida.Value == null)
            {
                return;
            }
            else
            {
                nHabitacion.VerHabitacionesDisponibles(dateFechaDeEntrada.Value, dateFechaDeSalida.Value);
                MostrarHabitaciones(nHabitacion.ListarTodo());
            }
        }
    }
}
