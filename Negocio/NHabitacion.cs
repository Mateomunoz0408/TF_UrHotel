using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NHabitacion
    {
        private DHabitacion dHabitacion = new DHabitacion();

        public String Registrar(Habitacion habitacion)
        {
            return dHabitacion.Registrar(habitacion);
        }

        public String Modificar(Habitacion habitacion)
        {
            return dHabitacion.Modificar(habitacion);
        }

        public String Eliminar(string numhabitacion)
        {
            return dHabitacion.Eliminar(numhabitacion);
        }

        public List<Habitacion> ListarTodo()
        {
            return dHabitacion.ListarTodo();
        }

        public List<Habitacion> ListarHabitacionesOcupadas()
        {
            return dHabitacion.ListarHabitacionesOcupadas();
        }

        public String VerHabitacionesDisponibles(DateTime Entrada, DateTime Salida)
        {
            return dHabitacion.VerHabitacionesDisponibles(Entrada, Salida);
        }
    }
}
