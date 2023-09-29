using System.Reflection;

namespace Ejercicio_4
{
    internal class Program
    {
        /*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

    El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

    Escribir una aplicación que encuentre los 4 primeros números perfectos.
        */
        static void Main(string[] args)
        {
            int sumatoria;
            int contador=0;

            for (int i = 1; ; i++)
            {
                if (esPrimo(i) == false)
                {
                    sumatoria = 0;
                    //Console.WriteLine("entre aca");
                    //Console.WriteLine("i es igual a {0} y j es igual a ", i);
                    for (int j = (i-1); j >= 1; j--)
                    {
                        //Console.WriteLine("i es igual a {0} y j es igual a {1}", i,j);
                        if (i % j == 0)
                        {
                            sumatoria = sumatoria + j;
                           // Console.WriteLine("sumatoria es igual a{0} ",sumatoria);
                        }

                    }
                    if (sumatoria == i)
                    {
                        Console.WriteLine("{0} es un numero perfecto", i);
                        contador = contador + 1;
                    }
                }
                if (contador == 4)
                {
                    break;
                }
            }
            


            


        }
        static bool esPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}



