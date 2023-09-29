using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5___Ejercicio_4
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;

        private Equipo ()
        {
            jugadores = new List<Jugador> ();
        }
        public Equipo (short cantidad, string nombre):this ()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.cantidadDeJugadores > e.jugadores.Count && e.jugadores.IndexOf(j)==-1)
            {
                e.jugadores.Add(j);
                return true;
            }else
            {
                return false;
            }
        }
        public string MostrarEquipo()
        {
            Console.WriteLine("Jugadores:");
            foreach (Jugador jugador in this.jugadores)
            {
                Console.WriteLine(jugador.MostrarDatos());
            }
            return "----------";
        }
    }
}
