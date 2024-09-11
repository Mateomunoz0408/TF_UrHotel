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
    public partial class FormReportes : Form
    {
        private NReserva nReserva = new NReserva();
        private NCliente nCliente = new NCliente();
        private NHabitacion nHabitacion = new NHabitacion();
        private NUsuario nUsuario = new NUsuario();
        public FormReportes()
        {
            InitializeComponent();
            MostrarNombresClientes(nCliente.ListarTodo());
            MostrarUsuarios(nUsuario.ListarTodo());
        }

        private void MostrarNombresClientes(List<Cliente> clientes)
        {
            cmbNombreCliente.DataSource = null;
            if (clientes.Count == 0)
            {
                return;
            }
            else
            {
                cmbNombreCliente.DataSource = clientes;
                cmbNombreCliente.ValueMember = "Dni";
                cmbNombreCliente.DisplayMember = "Nombre";
            }
        }

        private void MostrarHabitacionesDisponibles(List<Habitacion> habitaciones)
        {
            dgHabitacionesDisponibles.DataSource = null;
            if (habitaciones.Count == 0)
            {
                return;
            }
            else
            {
                dgHabitacionesDisponibles.DataSource = habitaciones;
                dgHabitacionesDisponibles.Columns["Reserva"].Visible = false;
            }
        }

        private void MostrarHabitacionesOcupadas(List<Habitacion> habitaciones)
        {
            dgHabitacionesOcupadas.DataSource = null;
            if (habitaciones.Count == 0)
            {
                return;
            }
            else
            {
                dgHabitacionesOcupadas.DataSource = habitaciones;
                dgHabitacionesOcupadas.Columns["Reserva"].Visible = false;
            }
        }

        private void MostrarUsuarios(List<Usuario> usuarios)
        {
            cmbUsuarios.DataSource = null;
            if (usuarios.Count == 0)
            {
                return;
            }
            else
            {
                cmbUsuarios.DataSource = usuarios;
                cmbUsuarios.ValueMember = "Usuario1";
                cmbUsuarios.DisplayMember = "Usuario1";
            }
        }

        private void MostrarReservasDeUsuario(string user)
        {
            dgReservasDeUsuarios.DataSource = null;
            List<Reserva> reservasUsuario = nReserva.ListarReservasdeUsuario(user);
            if (reservasUsuario.Count == 0)
            {
                return;
            }
            else
            {
                dgReservasDeUsuarios.DataSource = reservasUsuario;
                dgReservasDeUsuarios.Columns["Cliente1"].Visible = false;
                dgReservasDeUsuarios.Columns["Habitacion1"].Visible = false;
                dgReservasDeUsuarios.Columns["Usuario1"].Visible = false;
            }
        }

        private void MostrarUsuariosEnDg(List<Usuario> usuarios)
        {
            dgUsuarios.DataSource = null;
            if (usuarios.Count == 0)
            {
                return;
            }
            else
            {
                dgUsuarios.DataSource = usuarios;
                dgUsuarios.Columns["Contraseña"].Visible = false;
                dgUsuarios.Columns["Reserva"].Visible = false;
            }
        }

        private void btnBuscarPagoTotal_Click(object sender, EventArgs e)
        {
            if(cmbNombreCliente.Text == "")
            {
                MessageBox.Show("Por favor, seleccione un Cliente");
                return;
            }

            string dni = cmbNombreCliente.SelectedValue.ToString();
            List<Cliente> clientes = nCliente.ListarTodo();
            Cliente clientepago = clientes.Find(c => c.Dni.Equals(dni));

            labelPagoTotal.Text = nReserva.PagoTotalDeUnCliente(clientepago).ToString();
        }

        private void btnCalcularCantidadDeClientesHospedados_Click(object sender, EventArgs e)
        {
            DateTime FechaEntrada = dateEntradaCantidadDeClientesHospedados.Value.Date;
            DateTime FechaSalida = dateSalidaCantidadDeClientesHospedados.Value.Date;

            labelCantidadDeClientesHospedados.Text = nReserva.CantidadDeClientesHospedados(FechaEntrada, FechaSalida).ToString();
        }

        private void btnCalcularGananciasDelHotel_Click(object sender, EventArgs e)
        {
            DateTime FechaEntrada = dateEntradaGananciasDelHotel.Value.Date;
            DateTime FechaSalida = dateSalidadGananciasDelHotel.Value.Date;

            labelGananciasDelHotel.Text = nReserva.GananciasDelHotel(FechaEntrada, FechaSalida).ToString();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            DateTime FechaEntrada = dateEntradaHabitaciones.Value.Date;
            DateTime FechaSalida = dateSalidaHabitaciones.Value.Date;

            nHabitacion.VerHabitacionesDisponibles(FechaEntrada, FechaSalida);
            MostrarHabitacionesDisponibles(nHabitacion.ListarTodo());
            MostrarHabitacionesOcupadas(nHabitacion.ListarHabitacionesOcupadas());
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            MostrarReservasDeUsuario(cmbUsuarios.Text);
        }

        private void btnMostrarAlUsuarioQueRealizoMasReservas_Click(object sender, EventArgs e)
        {
            MostrarUsuariosEnDg(nUsuario.ListarUsuariosConMasReservas());
        }

        private void btnMostrarAlUsuarioConMayorRecaudacionEnSusReservas_Click(object sender, EventArgs e)
        {
            MostrarUsuariosEnDg(nUsuario.ListarUsuariosConMayorRecaudacion());
        }
    }
}
