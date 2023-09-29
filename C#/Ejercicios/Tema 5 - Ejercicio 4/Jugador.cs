using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tema_5___Ejercicio_4
{
    public class Jugador
    {
        int dni;
        string? nombre;
        int partidosJugados;
        float promedioGoles;
        int totalGoles;

        public float GetPromediosGoles ()
        {
            this.promedioGoles = (float) this.partidosJugados / this.totalGoles;
            return this.promedioGoles;
        }

        Jugador ()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador (int dni, string nombre): this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
        public string MostrarDatos ()
        {
            return $"Jugador: {this.nombre}, DNI {this.dni}, partidos jugados {this.partidosJugados}, total de goles {this.totalGoles}, promedio de goles {this.GetPromediosGoles()}";
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            if (j1.dni == j2.dni) 
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
