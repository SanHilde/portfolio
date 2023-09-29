using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4___Ejercicio_1
{
    public class Sumador
    {
        int cantidadSumas;
        public static explicit operator int(Sumador s)
        {
            int resultado;
            resultado = s.cantidadSumas;
            return resultado;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantidadSumas != s2.cantidadSumas) 
            { 
                return false; 
            }
            else 
            { 
                return true; 
            }
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public Sumador (): this(0)
        {
        }
        public Sumador (int cantidadSumas)//: this ()
        {
            this.cantidadSumas = cantidadSumas;
        }
        public long Sumar (long a, long b)
        {
            long resultado;
            resultado = a + b;
            this.cantidadSumas++;
            return resultado;
        }

        public string Sumar (string a, string b) 
        {
            string resultado;
            resultado = $"{a} {b}";
            this.cantidadSumas++;
            return resultado;

        }


    }
}
