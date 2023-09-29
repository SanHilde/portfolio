using System.Collections;
namespace Tema_5___Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object[] array = new Object[20];
            //ArrayList array = new ArrayList();
            int[] array;
            Stack pila = new Stack();
            Queue<int> queue = new Queue<int>();
            List <int> lista = new List<int>();
            int numeroRandom;
            Random rnd = new Random();

            for (int i = 0; i <= 20; i++)
            {
                do
                {
                    numeroRandom = rnd.Next(-100, 100);
                } while (rnd.Next() == 0);
                pila.Push(numeroRandom);
                queue.Enqueue(numeroRandom);
                lista.Add(numeroRandom);
            }

            Console.WriteLine("Pila o stack:");
            foreach (int numeroR in pila)
            {
                Console.WriteLine(numeroR);
            }

            array= pila.ToArray().Cast<int>().ToArray();
            Array.Sort(array);
            Array.Reverse(array);
            pila.Clear();
            foreach (int numeroR in array)
            {
                if (numeroR < 0)
                {
                    pila.Push(numeroR);
                }
            }

            Array.Sort(array);
            foreach (int numeroR in array)
            {
                if (numeroR > 0)
                {
                    pila.Push(numeroR);
                }
            }

            Console.WriteLine("Stack ordenada:");
            foreach (int numeroR in pila)
            {
                Console.WriteLine(numeroR);
            }

            Console.WriteLine("\n\nLimpieza de array:");
            Array.Clear(array);
            foreach (int numeroR in array)
            {
                Console.WriteLine(numeroR);
            }

            Console.WriteLine("\n\nCola o queue:");
            foreach (int numeroR in queue)
            {
                Console.WriteLine(numeroR);
            }

            array = queue.ToArray();
            Array.Sort(array);
            Array.Reverse(array);
            queue.Clear();
            foreach (int numeroR in array)
            {
                if (numeroR > 0)
                {
                    queue.Enqueue(numeroR);
                }
            }

            Array.Sort(array);
            foreach (int numeroR in array)
            {
                if (numeroR < 0)
                {
                    queue.Enqueue(numeroR);
                }
            }

            Console.WriteLine("Queue ordenada:");
            foreach (int numeroR in queue)
            {
                Console.WriteLine(numeroR);
            }





            Console.WriteLine("\n\nLista:");
            foreach (int numeroR in lista)
            {
                Console.WriteLine(numeroR);
            }
            Console.WriteLine("Positivos decreciente:");
            lista.Sort();
            lista.Reverse();
            foreach (int numeroR in lista)
            {
                if (numeroR > 0)
                {
                    Console.WriteLine(numeroR);
                }
            }
            Console.WriteLine("Negativos creciente:");
            lista.Sort();
            foreach (int numeroR in lista)
            {
                if (numeroR < 0)
                {
                    Console.WriteLine(numeroR);
                }
            }
        }
    }
}