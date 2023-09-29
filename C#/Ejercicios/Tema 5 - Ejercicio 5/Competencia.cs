using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5___Ejercicio_5
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVuelta, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVuelta;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public string MostrarDatos()
        {
            string datos;
            datos = $"Cantidad maxima de competidores: {this.cantidadCompetidores}, cantidad de competidores actuales: {this.competidores.Count} cantidad de vueltas: {this.cantidadVueltas}";
            foreach (AutoF1 competidor in this.competidores)
            {
                Console.WriteLine(($"Competidor de la escuderia {competidor.Escuderia} con el numero {competidor.Numero}"));
            }

            return datos;
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool respuesta;
            Random rnd = new Random();
           //int bandera = 0;
            short combustible;

            if ((short)c.competidores.Count != c.cantidadCompetidores )
            {
                if (c == a) 
                {
                    Console.WriteLine($"Ya fue ingreado el competidor de la escuderia {a.Escuderia} con el numero {a.Numero}, solicitud de ingreso rechazada");
                    respuesta = false;
                }
                else
                {
                    combustible = (short)rnd.Next(15, 100);
                    c.competidores.Add(a);
                    a.EnCompetencia = true;
                    a.CantidadCombustible = combustible;
                    a.VueltasRestantes = c.cantidadVueltas;
                    respuesta = true;
                }
            }
            else
            {
                Console.WriteLine($"No hay espacio para el competidor de la escuderia {a.Escuderia} con el numero {a.Numero}, solicitud de ingreso rechazada");
                respuesta = false;
            }
            return respuesta;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool respuesta;
            int bandera = 0;
            int contador = 0;


            foreach (AutoF1 competidor in c.competidores)
            {
                if (competidor == a)
                {
                    bandera = 1;
                    break;
                }
                contador++;
            }
            if (bandera == 1)
            {
                c.competidores.RemoveAt(contador);
                a.EnCompetencia = false;
                a.CantidadCombustible = 0;
                a.VueltasRestantes = 0;
                respuesta = true;
            }
            else
            {
                Console.WriteLine(a.MostrarDatos());
                respuesta = false;
            }

            return respuesta;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 competidor in c.competidores)
            {
                if (competidor == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
