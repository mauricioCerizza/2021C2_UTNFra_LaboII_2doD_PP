using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class PuestoComputadora
    {
        private static int numeroActual;
        private Computadora computadora;

        public PuestoComputadora() 
        {
            PuestoComputadora.numeroActual = 0;
        }

        public PuestoComputadora(Computadora computadora) 
        {
            this.computadora = computadora;
        }

        public static int NumeroActual 
        {
            get => ++numeroActual;
        }

        public bool Atender(Cliente cli) 
        {
            if (cli is not null)
            {
                Thread.Sleep(30000);
                return true;
            }
            return false;
        }
    }
}
