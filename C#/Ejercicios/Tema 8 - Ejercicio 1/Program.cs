namespace Tema_8___Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sobreescrito objeto = new Sobreescrito();
             Sobreescrito objeto2 = new Sobreescrito();
             Object objeto3 = new Object();

             Console.WriteLine(objeto.ToString());
             Console.WriteLine($"El objeto uno y el dos son iguales: {objeto.Equals(objeto)}");
             Console.WriteLine($"El objeto uno y el dos son iguales: {objeto.Equals(objeto3)}");
             Console.WriteLine($"Comparacion de sobrecargas: {objeto.Equals(objeto3)}");*/

            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobreescrito objetoSobrescrito = new SobreSobreescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine(objetoSobrescrito.MiMetodo());

            Console.ReadKey();

        }
    }
}