using System.Text.Json.Serialization;

namespace Ejercicio_2
{
    internal class Program
    {
        //Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero,
        //caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            int cuadrado;
            int cubo;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroIngresadoTexto);

            if (numeroIngresado > 0)
            {
                cuadrado = numeroIngresado* numeroIngresado;
                cubo = numeroIngresado* numeroIngresado* numeroIngresado;
                Console.WriteLine("El numero ingresado es: {0}, su elevacion al cuadrado: {1}, su elevacion al cubo:{2}", numeroIngresado, cuadrado,cubo);
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

        }
    }
}