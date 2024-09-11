using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NUsuario
    {
        private DUsuario dUsuario = new DUsuario();
        public bool IniciarSesion(string usuario, string contraseña)
        {
            return dUsuario.IniciarSesion(usuario, contraseña);
        }

        public List<Usuario> ListarTodo()
        {
            return dUsuario.ListarTodo();
        }

        public List<Usuario> ListarUsuariosConMasReservas()
        {
            return dUsuario.ListarUsuariosConMasReservas();
        }

        public List<Usuario> ListarUsuariosConMayorRecaudacion()
        {
            return dUsuario.ListarUsuariosConMayorRecaudacion();
        }
    }
}
