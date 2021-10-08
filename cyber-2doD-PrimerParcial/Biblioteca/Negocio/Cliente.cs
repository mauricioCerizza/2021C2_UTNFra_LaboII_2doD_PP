
namespace Biblioteca.Negocio
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;

        public Cliente(string nombre, string apellido, string strDNI, decimal dEdad)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = strDNI;
            Edad = (int)dEdad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string DNI 
        { 
            set
            {
                dni = validarDNI(value);
            }
        }
        public int Edad 
        {
            set
            {
                edad = value;
            }
        }

        private int validarDNI(string strDNI) 
        {
            return !int.TryParse(strDNI, out int dni) || strDNI is null ? 0 : dni;
        }

    }
}
