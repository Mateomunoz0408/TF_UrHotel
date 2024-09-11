using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DUsuario
    {
        public bool IniciarSesion(string usuario, string contraseña)
        {
            List<Usuario> usuarios = new List<Usuario>();
            bool iniciosesion = false;
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuario.ToList();
                    foreach(Usuario user in usuarios)
                    {
                        if (user.Usuario1 == usuario)
                        {
                            if (user.Contraseña == contraseña)
                            {
                                iniciosesion = true;
                            }
                        }
                    }
                }
                return iniciosesion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return iniciosesion;
            }
        }

        public List<Usuario> ListarTodo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuario.ToList();
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return usuarios;
            }
        }

        public List<Usuario> ListarUsuariosConMasReservas()
        {
            List<Usuario> usuariosConMasReservas = new List<Usuario>();
            List<Usuario> usuarios = new List<Usuario>();
            List<Reserva> reservas = new List<Reserva>();
            int maxreservas = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuario.ToList();
                    reservas = context.Reserva.ToList();
                    foreach(Usuario usuario in usuarios)
                    {
                        int reservasUsuario = 0;
                        foreach(Reserva reserva in reservas)
                        {
                            if (reserva.Usuario == usuario.Usuario1)
                            {
                                reservasUsuario++;
                            }
                        }

                        if (reservasUsuario > maxreservas)
                        {
                            usuariosConMasReservas.Clear();
                            usuariosConMasReservas.Add(usuario);
                            maxreservas = reservasUsuario;
                        }
                        else if(reservasUsuario == maxreservas)
                        {
                            usuariosConMasReservas.Add(usuario);
                        }
                    }
                }
                return usuariosConMasReservas;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return usuariosConMasReservas;
            }
        }

        public List<Usuario> ListarUsuariosConMayorRecaudacion()
        {
            List<Usuario> usuariosConMayorRecaudacion = new List<Usuario>();
            List<Usuario> usuarios = new List<Usuario>();
            List<Reserva> reservas = new List<Reserva>();
            decimal maxrecaudacion = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    usuarios = context.Usuario.ToList();
                    reservas = context.Reserva.ToList();
                    foreach (Usuario usuario in usuarios)
                    {
                        decimal recaudacionUsuario = 0;
                        foreach (Reserva reserva in reservas)
                        {
                            if (reserva.Usuario == usuario.Usuario1)
                            {
                                recaudacionUsuario += reserva.Monto_Total;
                            }
                        }

                        if (recaudacionUsuario > maxrecaudacion)
                        {
                            usuariosConMayorRecaudacion.Clear();
                            usuariosConMayorRecaudacion.Add(usuario);
                            maxrecaudacion = recaudacionUsuario;
                        }
                        else if (recaudacionUsuario == maxrecaudacion)
                        {
                            usuariosConMayorRecaudacion.Add(usuario);
                        }
                    }
                }
                return usuariosConMayorRecaudacion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return usuariosConMayorRecaudacion;
            }
        }
    }
}
