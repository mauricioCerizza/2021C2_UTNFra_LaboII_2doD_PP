using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Gestion
    {
        private List<Computadora> listaComputadores;
        private Queue<Puesto> computadoresEnUso;
        private Queue<Puesto> computadoresEnEspera;
        private int puestoComputadoraDisponible;

        private Gestion()
        {
            this.listaComputadores = new List<Computadora>();
            this.computadoresEnUso = new Queue<Puesto>();
            this.computadoresEnEspera = new Queue<Puesto>();
        }

        public Gestion(int computadorasDisponibles)
            : this()
        {
            this.puestoComputadoraDisponible = computadorasDisponibles;
        }





        public string MostrarComputadorasEnUso() 
        {
            StringBuilder sb = new();

            sb.AppendLine("DNI  ---  NOMBRE  ---  APELLIDO  ---  EDAD");

            return sb.ToString();
        }

    }
}
