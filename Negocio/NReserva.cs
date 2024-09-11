using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReserva
    {
        private DReserva dReserva = new DReserva();

        public String Registrar(Reserva reserva)
        {
            return dReserva.Registrar(reserva);
        }

        public String Eliminar(string codigo)
        {
            return dReserva.Eliminar(codigo);
        }

        public List<Reserva> ListarTodo()
        {
            return dReserva.ListarTodo();
        }

        public decimal PagoTotalDeUnCliente(Cliente cliente)
        {
            return dReserva.PagoTotalDeUnCliente(cliente);
        }

        public int CantidadDeClientesHospedados(DateTime FechaEntrada, DateTime FechaSalida)
        {
            return dReserva.CantidadDeClientesHospedados(FechaEntrada, FechaSalida);
        }

        public decimal GananciasDelHotel(DateTime FechaEntrada, DateTime FechaSalida)
        {
            return dReserva.GananciasDelHotel(FechaEntrada, FechaSalida);
        }

        public List<Reserva> ListarReservasdeUsuario(string usuario)
        {
            return dReserva.ListarReservasdeUsuario(usuario);
        }
    }
}
