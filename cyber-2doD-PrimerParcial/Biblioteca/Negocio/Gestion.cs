using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public abstract class Gestion
    {
        private static List<Cliente> listaClientes = new List<Cliente>();


        public static void GuardarCliente(Cliente cli) 
        {
            if (cli is not null) 
            {
                listaClientes.Add(cli);
            }
        }
        public static string MostrarClientes() 
        {
            StringBuilder sb = new();

            sb.AppendLine("DNI  ---  NOMBRE  ---  APELLIDO  ---  EDAD");
            foreach (Cliente cli in listaClientes)
            {
                sb.AppendFormat("{0} -- ", cli.Apellido);
                sb.AppendFormat("{0} -- ", cli.Nombre);
            }

            return sb.ToString();
        }

    }
}
