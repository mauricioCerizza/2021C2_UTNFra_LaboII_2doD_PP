using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Computadora
    {
        private string identificador;
        private List<Software> software;
        private List<Periferico> perifericos;
        private List<Juego> juegos;
        private EspecificacionHardware especificacion;

        public Computadora(string identificador, List<Software> software, List<Periferico> perifericos, List<Juego> juegos, EspecificacionHardware especificacion)
        {
            this.identificador = identificador;
            this.software = software;
            this.perifericos = perifericos;
            this.juegos = juegos;
            this.especificacion = especificacion;
        }
    }
}
