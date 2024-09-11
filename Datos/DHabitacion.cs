using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DHabitacion
    {
        public String Registrar(Habitacion habitacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Habitacion.Add(habitacion);
                    context.SaveChanges();
                }
                return "Habitación registrada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Habitacion habitacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Habitacion habitaciontemp = context.Habitacion.Find(habitacion.Numero);
                    habitaciontemp.Numero = habitacion.Numero;
                    habitaciontemp.Estado = habitacion.Estado;
                    habitaciontemp.Tipo = habitacion.Tipo;
                    habitaciontemp.Precio = habitacion.Precio;
                    context.SaveChanges();
                }
                return "Modificado Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(string numhabitacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Habitacion habitaciontemp = context.Habitacion.Find(numhabitacion);
                    context.Habitacion.Remove(habitaciontemp);
                    context.SaveChanges();
                }
                return "Habitación eliminada Correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Habitacion> ListarTodo()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    habitaciones = context.Habitacion.Where(h => h.Estado.Equals("Disponible")).ToList();
                }
                return habitaciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return habitaciones;
            }
        }

        public List<Habitacion> ListarHabitacionesOcupadas()
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    habitaciones = context.Habitacion.Where(h => h.Estado.Equals("Ocupada")).ToList();
                }
                return habitaciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return habitaciones;
            }
        }

        public String VerHabitacionesDisponibles(DateTime Entrada, DateTime Salida)
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            List<Habitacion> habitacionesTemp = new List<Habitacion>();
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    habitaciones = context.Habitacion.ToList();
                    reservas = context.Reserva.ToList();
                    foreach (Habitacion habitacion in habitaciones)
                    {
                        foreach (Reserva reserva in reservas)
                        {
                            if (habitacion.Numero == reserva.Habitacion)
                            {
                                if (Entrada <= reserva.Fecha_Entrada && Salida <= reserva.Fecha_Salida)
                                {
                                    habitacion.Estado = "Ocupada";
                                    Modificar(habitacion);
                                }
                                if (Entrada <= reserva.Fecha_Entrada && Salida >= reserva.Fecha_Salida)
                                {
                                    habitacion.Estado = "Ocupada";
                                    Modificar(habitacion);
                                }
                                if (Entrada >= reserva.Fecha_Entrada && Salida <= reserva.Fecha_Salida)
                                {
                                    habitacion.Estado = "Ocupada";
                                    Modificar(habitacion);
                                }
                                if (Entrada >= reserva.Fecha_Entrada && Entrada <= reserva.Fecha_Salida && Salida >= reserva.Fecha_Salida)
                                {
                                    habitacion.Estado = "Ocupada";
                                    Modificar(habitacion);
                                }
                                if (Entrada < reserva.Fecha_Entrada && Salida < reserva.Fecha_Entrada)
                                {
                                    habitacion.Estado = "Disponible";
                                    Modificar(habitacion);
                                }
                                if (Entrada > reserva.Fecha_Salida && Salida > reserva.Fecha_Salida)
                                {
                                    habitacion.Estado = "Disponible";
                                    Modificar(habitacion);
                                }
                            }
                        }
                    }
                }
                return "Cambio de Estado de Habitación exitoso";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
