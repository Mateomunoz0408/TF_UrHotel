using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCliente
    {
        public String Registrar(Cliente cliente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                }
                return "Cliente registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(string dni)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Cliente clientetemp = context.Cliente.Find(dni);
                    context.Cliente.Remove(clientetemp);
                    context.SaveChanges();
                }
                return "Cliente eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Cliente> ListarTodo()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    clientes = context.Cliente.ToList();
                }
                return clientes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return clientes;
            }
        }
    }
}
