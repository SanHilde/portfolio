using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Cotizador
{
    public class Conversor
    {
        public static double ConvertirBinarioADecimal(int numeroEntero)
        {
            int contador = 0;
            string numeroString;
            double sumatoria=0;

            numeroString = numeroEntero.ToString();
            for (int i= (numeroString.Length) -1; i >= 0;i--)
            {
                if (numeroString[i] == '1')
                {
                    sumatoria = sumatoria + Math.Pow (2, contador);
                }
                contador++;
            }
            return (sumatoria);
        }

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            StringBuilder miCadena = new StringBuilder();
            StringBuilder resultado = new StringBuilder();
            do
            {
                if (numeroEntero % 2 == 1)
                {
                    numeroEntero = numeroEntero - 1;
                    numeroEntero = numeroEntero / 2;
                    miCadena.Append("1");
                }
                else
                {
                    numeroEntero = numeroEntero / 2;
                    miCadena.Append("0");
                }

            } while (numeroEntero != 0);

            while (miCadena.Length % 4 != 0)
            {
                miCadena.Append("0");
            } 

            for (int i = miCadena.Length-1; i >= 0; i--)
            {
               resultado.Append(miCadena[i]);
            }
            return resultado.ToString();
        }

    }
}
