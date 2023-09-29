using System.Text;

namespace Tena_2___Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            StringBuilder miCadena = new StringBuilder();

            Console.WriteLine("Ingrese un numero:");
            numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroIngresadoTexto);
            miCadena.Append($"Tabla de multiplicar del número {numeroIngresado}\n");

            for (int i = 1;i <= 9; i++)
            {
                miCadena.Append($"{numeroIngresado} x {i} = {i*numeroIngresado}\n");
            }

            Console.WriteLine(miCadena.ToString()) ;
        }
    }
}