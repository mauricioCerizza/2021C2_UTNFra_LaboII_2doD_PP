using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class UsoComputadora : Puesto
    {
        private const float MIN_30 = 0.5F;
        private Tiempo tiempo;
        private Computadora computadora;

        public enum Tiempo
        { 
            DEFINIDO,
            LIBRE
        }

        public UsoComputadora(string id, Computadora computadora) : base(id)
        {
            this.identificaficador = id;
            this.computadora = computadora;
        }



    }
}
