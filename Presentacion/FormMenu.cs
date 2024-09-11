using Datos;
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
    public partial class FormMenu : Form
    {
        Usuario usuario;
        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FormReservas fr = new FormReservas(usuario);
            fr.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes fc = new FormClientes();
            fc.Show();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            FormHabitaciones fh = new FormHabitaciones();
            fh.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes frp = new FormReportes();
            frp.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
