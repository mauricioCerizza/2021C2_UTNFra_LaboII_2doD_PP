namespace Biblioteca
{
    public class EspecificacionHardware
    {
        private string procesador;
        private string ram;
        private string placaVideo;

        public EspecificacionHardware(string procesador, string ram, string placaVideo)
        {
            this.procesador = procesador;
            this.ram = ram;
            this.placaVideo = placaVideo;
        }
    }
}