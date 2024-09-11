using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCliente
    {
        private DCliente dCliente = new DCliente();

        public String Registrar(Cliente cliente)
        {
            return dCliente.Registrar(cliente);
        }

        public String Eliminar(string dni)
        {
            return dCliente.Eliminar(dni);
        }

        public List<Cliente> ListarTodo()
        {
            return dCliente.ListarTodo();
        }
    }
}
