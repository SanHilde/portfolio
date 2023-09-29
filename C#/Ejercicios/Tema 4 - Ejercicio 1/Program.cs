namespace Tema_4___Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumadorDos = new Sumador(3);

            Console.WriteLine(sumador.Sumar(1, 5));
            Console.WriteLine(sumador.Sumar("pepe", "argento"));
            Console.WriteLine(sumador+sumadorDos);
            Console.WriteLine(sumador | sumadorDos);
            Console.WriteLine(sumador.Sumar(5, 8));
            Console.WriteLine(sumador | sumadorDos);

        }
    }
}