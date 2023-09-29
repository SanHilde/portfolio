using Biblioteca_de_clases_Tema_8___Ejercicio_2;

namespace Tema_8___Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            List<Figura> lista = new List<Figura>();
            Rectangulo figura1 = new Rectangulo(5,10);
            Circulo figura2 = new Circulo(5);
            Cuadrado figura3 = new Cuadrado(5);

            lista.Add(figura1);
            lista.Add(figura2);
            lista.Add(figura3);
            
            foreach (Figura x in lista)
            {
                contador++;
                Console.WriteLine($"------Figura {contador}------");
                Console.WriteLine(x.GetType());
                Console.WriteLine(x.Dibujar());
                Console.WriteLine($"Area: {x.CalcularSuperficie():N2}");
                Console.WriteLine($"Perimetro: {x.CalcularPerimetro():N2}\n");

            }
            
        }
    }
}