namespace Tema_2___Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            double alturaTriangulo;
            double baseTriangulo;
            double resultado;

            Console.WriteLine("Ingrese la altura de un triangulo:");
            numeroIngresadoTexto = Console.ReadLine();
            alturaTriangulo = double.Parse(numeroIngresadoTexto);
            Console.WriteLine("Ingrese la base de un triangulo:");
            numeroIngresadoTexto = Console.ReadLine();
            baseTriangulo = double.Parse(numeroIngresadoTexto);

            resultado = Math.Sqrt(Math.Pow(alturaTriangulo, 2) + Math.Pow(baseTriangulo, 2));
            Console.WriteLine($"Segun pitagoras, √({alturaTriangulo}^2 + {baseTriangulo}^2) = {resultado:N2} (la hipotenusa)");
        }
    }
}