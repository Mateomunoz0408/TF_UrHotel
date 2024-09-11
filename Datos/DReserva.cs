using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReserva
    {
        public String Registrar(Reserva reserva)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Reserva.Add(reserva);
                    context.SaveChanges();
                }
                return "Reserva registrada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(string codigo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Reserva reservatemp = context.Reserva.Find(codigo);
                    context.Reserva.Remove(reservatemp);
                    context.SaveChanges();
                }
                return "Reserva eliminada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Reserva> ListarTodo()
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reservas = context.Reserva.ToList();
                }
                return reservas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return reservas;
            }
        }

        public decimal PagoTotalDeUnCliente(Cliente cliente)
        {
            List<Reserva> reservas = new List<Reserva>();
            decimal MontoTotal = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reservas = context.Reserva.ToList();                    
                    foreach (Reserva reserva in reservas)
                    {
                        if (reserva.Cliente == cliente.Dni)
                        {
                            MontoTotal += Convert.ToDecimal(reserva.Monto_Total);
                        }
                    }                  
                }
                return MontoTotal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return MontoTotal;
            }
        }

        public int CantidadDeClientesHospedados(DateTime FechaEntrada, DateTime FechaSalida)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Reserva> reservas = new List<Reserva>();
            int contador = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.ToList();
                    reservas = context.Reserva.ToList();
                    foreach (Cliente cliente in clientes)
                    {
                        foreach (Reserva reserva in reservas)
                        {
                            if (reserva.Cliente == cliente.Dni)
                            {
                                if (FechaEntrada <= reserva.Fecha_Salida && FechaSalida >= reserva.Fecha_Salida) contador++;
                                else if (FechaEntrada <= reserva.Fecha_Entrada && FechaSalida >= reserva.Fecha_Entrada) contador++;
                            }
                        }
                    }                    
                }
                return contador;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return contador;
            }
        }

        public decimal GananciasDelHotel(DateTime FechaEntrada, DateTime FechaSalida)
        {
            decimal MontoTotal = 0;
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reservas = context.Reserva.ToList();
                    foreach (Reserva reserva in reservas)
                    {
                        if (FechaEntrada <= reserva.Fecha_Salida && FechaSalida >= reserva.Fecha_Salida)
                        {
                            MontoTotal += Convert.ToDecimal(reserva.Monto_Total);
                        }
                        else if (FechaEntrada <= reserva.Fecha_Entrada && FechaSalida >= reserva.Fecha_Entrada)
                        {
                            MontoTotal += Convert.ToDecimal(reserva.Monto_Total);
                        }
                    }                    
                }
                return MontoTotal;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return MontoTotal;
            }
        }

        public List<Reserva> ListarReservasdeUsuario(string usuario)
        {
            List<Reserva> reservasDeUsuario = new List<Reserva>();
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    reservas = context.Reserva.ToList();
                    foreach(Reserva reserva in reservas)
                    {
                        if (reserva.Usuario == usuario)
                        {
                            reservasDeUsuario.Add(reserva);
                        }
                    }
                }
                return reservasDeUsuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return reservasDeUsuario;
            }
        }
    }
}
