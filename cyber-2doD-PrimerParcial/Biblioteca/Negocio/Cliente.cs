
namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;

        public Cliente(string nombre, string apellido, string strDNI, decimal dEdad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = validarDNI(strDNI);
            this.edad = (int)dEdad;
        }


        private int validarDNI(string strDNI) 
        {
            return !int.TryParse(strDNI, out int dni) || strDNI is null ? 0 : dni;
        }

    }
}
