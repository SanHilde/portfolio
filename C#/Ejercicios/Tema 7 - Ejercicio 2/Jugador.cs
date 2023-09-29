using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Tema_7___Ejercicio_2;

namespace Tema_7___Ejercicio_2
{
    public class Jugador: Persona
    {

        int partidosJugados;
        int totalGoles;

        public int PartidosJugados
        { get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }

        public float PromedioDeGoles ()
        {
            return (float)this.PartidosJugados / this.TotalGoles;
        }

        public Jugador(int dni, string nombre) : base (dni, nombre)
        {
            this.PartidosJugados = 0;
            this.TotalGoles = 0;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this (dni, nombre)
        {
            this.PartidosJugados = partidosJugados;
            this.TotalGoles = totalGoles;
        }
        public string MostrarDatos ()
        {
            StringBuilder sb = new StringBuilder ();
            sb.Append(this.MostrarDatosPersona());
            sb.Append($"Partidos jugados {this.PartidosJugados}, total de goles {this.TotalGoles}, promedio de goles {this.PromedioDeGoles()}");
            return sb.ToString ();
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            if (j1.Dni == j2.Dni) 
            {
                return true ;
            } else
            {
                return false ; 
            }
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
