using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_viborita
{
    public enum Direcciones
    {

        Izquierda,
        Derecha,
        Arriba,
        Abajo,
    };
    class Settings
    {
        public static int Ancho { get; set; }
        public static int Altura { get; set; }
        public static int Puntaje { get; set; }
        public static int velocidad { get; set; }
        public static int Puntos { get; set; }
        public static  bool Perdiste { get; set; }
        public static Direcciones Direccion { get; set; }

        public Settings ()
        {
            Ancho = 15;
            Altura = 15;
            Puntaje = 0;
            Puntos = 0;
            velocidad = 15;
            Perdiste = true;
            Direccion = Direcciones.Abajo;
        }
    }
}
