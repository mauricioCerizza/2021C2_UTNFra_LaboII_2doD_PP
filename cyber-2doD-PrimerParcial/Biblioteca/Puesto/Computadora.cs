using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Computadora : Puesto
    {
        private List<Software> softwares;
        private List<Periferico> perifericos;
        private List<Juego> juegos;

        public List<Software> Softwares { get => softwares; }
        public List<Periferico> Perifericos { get => perifericos; }
        public List<Juego> Juegos { get => juegos; }

        public enum Software
        {
            OFFICE,
            MESSENGER,
            ICQ,
            ARES
        }

        public enum Periferico
        {
            CAMARA,
            AURICULARES,
            MICROFONO
        }

        public enum Juego
        {
            DIABLO,
            LINEAGE,
            COUNTER_STRIKE,
            SIMS
        }

        public Computadora(string id) : base(id)
        {
            softwares = new List<Software>();
            perifericos = new List<Periferico>();
            juegos = new List<Juego>();

        }

        public Computadora(string id, List<Software> softwares, List<Periferico> perifericos, List<Juego> juegos)
            : base(id)
        {
            this.identificaficador = id;
            this.tipo = Tipo.COMPUTADORA;
            this.softwares = softwares;
            this.perifericos = perifericos;
            this.juegos = juegos;
        }

        public static bool operator ==(Computadora instalados, Computadora alquiler)
        {
            bool softwareEncontrado = false;
            bool perifericoEncontrado = false;
            bool juegoEncontrado = false;

            foreach (Software item in alquiler.softwares)
            {
                if (EncontrarLibre(instalados, item)) 
                {
                    softwareEncontrado = true;
                }
            }

            foreach (Periferico item in alquiler.perifericos)
            {
                if (EncontrarLibre(instalados, item))
                {
                    perifericoEncontrado = true;
                }
            }

            foreach (Juego item in alquiler.juegos)
            {
                if (EncontrarLibre(instalados, item))
                {
                    juegoEncontrado = true;
                }
            }

            if (softwareEncontrado && perifericoEncontrado && juegoEncontrado) 
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Computadora instalados, Computadora alquiler) 
        {
            return !(instalados == alquiler);
        }

        private static bool EncontrarLibre(Computadora computadores, Software softwareBuscado) 
        {
            foreach (Software item in computadores.softwares)
            {
                if (item == softwareBuscado) 
                {
                    return true;
                }
            }
            return false;
        }

        private static bool EncontrarLibre(Computadora computadores, Periferico perifericoBuscado)
        {
            foreach (Periferico item in computadores.perifericos)
            {
                if (item == perifericoBuscado)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool EncontrarLibre(Computadora computadores, Juego juegoBuscado)
        {
            foreach (Juego item in computadores.juegos)
            {
                if (item == juegoBuscado)
                {
                    return true;
                }
            }
            return false;
        }

        public override sealed string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("COMPUTADORA:");
            sb.AppendLine("Softwares intalados:");
            foreach (Software item in softwares)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Perifericos intalados:");
            foreach (Periferico item in perifericos)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Juegos intalados:");
            foreach (Juego item in juegos)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("---------------------");

            return sb.ToString();
        } 

    }
}
