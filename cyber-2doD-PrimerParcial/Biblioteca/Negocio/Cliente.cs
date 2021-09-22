using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(string nombre, int numero)
        {
            Nombre = nombre;
            Numero = numero;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
