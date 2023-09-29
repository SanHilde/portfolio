using System.Diagnostics;

namespace Tema_2___Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            int contador = 1;
            int numeroMayor=0;
            int numeroMenor=0;
            int sumatoria = 0;
            float promedio;
            int valorMinimo = -100;
            int valorMaximo = 100;
            int bandera = 0;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero:");
                    numeroIngresadoTexto = Console.ReadLine();
                    numeroIngresado = int.Parse(numeroIngresadoTexto);
                    if (Validador.Validar(numeroIngresado, valorMinimo, valorMaximo) == false)
                    {
                        Console.WriteLine($"Incorrecto, el valor debe estar entre {valorMinimo} y {valorMaximo}.");
                    }

                } while (Validador.Validar(numeroIngresado, -100, 100) == false);

                if (bandera == 0)
                {
                    numeroMayor = numeroIngresado;
                    numeroMenor = numeroIngresado;
                    bandera = 1;
                }

                if (numeroIngresado > numeroMayor)
                {
                    numeroMayor = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado < numeroMenor)
                    {
                        numeroMenor = numeroIngresado;
                    }
                }
                contador += 1;
                sumatoria = sumatoria + numeroIngresado;

            } while (contador <= 10);

            promedio = sumatoria / contador;

            Console.WriteLine("Numero mayor: {0}, numero menor: {1}, promedio:{2}", numeroMayor, numeroMenor, promedio);
        }
    }
    internal class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor < max && valor>min)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}