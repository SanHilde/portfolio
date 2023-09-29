using System.Collections;
namespace Tema_5___Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayNumeros = new ArrayList(); 
            int numeroRandom;
            Random rnd = new Random();

            for (int i = 0; i<=20; i++)
            {
                do
                {
                    numeroRandom = rnd.Next(-100,100);
                } while (rnd.Next() == 0);
                arrayNumeros.Add(numeroRandom);
            }

            Console.WriteLine("Arraylist:");
            foreach (int numeroR in arrayNumeros) 
            {
                Console.WriteLine(numeroR);
            }

            Console.WriteLine("Decreciente los positivos:");
            arrayNumeros.Sort();
            arrayNumeros.Reverse();
            foreach (int numeroR in arrayNumeros)
            {
                if (numeroR > 0)
                {
                    Console.WriteLine(numeroR);
                }
            }

            Console.WriteLine("Creciente los negativos:");
            arrayNumeros.Sort();
            foreach (int numeroR in arrayNumeros)
            {
                if (numeroR < 0)
                {
                    Console.WriteLine(numeroR);
                }
            }

            // Console.WriteLine("Hello, World!");
        }
    }
}