using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Cabina : Puesto
    {
        private Modelo modeloTelefono;
        private Marca marcaTelefono;

        public enum Modelo 
        {
            A_DISCO,
            A_TECLADO
        }

        public enum Marca
        { 
            PHILIPS,
            ATMA,
            SONY,
            ELECTRO_LUX
        }

        public Cabina(string id, Modelo modeloTelefono, Marca marcaTelefono)
            : base(id) 
        {
            this.identificaficador = id;
            this.tipo = Tipo.CABINA_TELEFONICA;
            this.modeloTelefono = modeloTelefono;
            this.marcaTelefono = marcaTelefono;
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CABINA:");
            sb.AppendLine("MODELO_TELEFONO: " + modeloTelefono);
            sb.AppendLine("MARCA_TELEFONO: " + marcaTelefono);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
