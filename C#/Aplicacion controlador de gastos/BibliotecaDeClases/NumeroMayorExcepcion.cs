using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroMayorExcepcion : Exception
    {
        public NumeroMayorExcepcion(string mensaje) : base(mensaje)
        {

        }
        public static int ComprobarNumeroMayorExcepcion (int numero, int numeroMayor, string lugar)
        {
            if (numero > numeroMayor)
            {
                throw new NumeroMayorExcepcion($"El numero ingresado en '{lugar}' es mayor a {numeroMayor}");
            }
            return numero;
        }
    }
}
