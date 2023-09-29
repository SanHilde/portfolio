namespace Tema_2___Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            double ladoCuadrado;
            double alturaTriangulo;
            double baseTriangulo;
            double radioCirculo;

            Console.WriteLine("Ingrese el lado de un cuadrado:");
            numeroIngresadoTexto = Console.ReadLine();
            ladoCuadrado = double.Parse(numeroIngresadoTexto);

            Console.WriteLine("Ingrese la altura de un triangulo:");
            numeroIngresadoTexto = Console.ReadLine();
            alturaTriangulo = double.Parse(numeroIngresadoTexto);
            Console.WriteLine("Ingrese la base de un triangulo:");
            numeroIngresadoTexto = Console.ReadLine();
            baseTriangulo = double.Parse(numeroIngresadoTexto);

            Console.WriteLine("Ingrese el radio de un circulo:");
            numeroIngresadoTexto = Console.ReadLine();
            radioCirculo = double.Parse(numeroIngresadoTexto);

            

            Console.WriteLine($"El area del cuadrado es {CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado)}");
            Console.WriteLine($"El area del triangulo es {CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo)}");
            Console.WriteLine($"El area del circulo es {CalculadoraDeArea.CalcularAreaCirculo(radioCirculo)}");

        }
    }

    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double resultado;
            resultado = longitudLado * longitudLado;
            return resultado;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            double resultado;
            resultado = baseTriangulo * altura / 2;
            return resultado;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            double resultado;
            resultado = radio * radio * 3.14;
            return resultado;
        }


    }
}