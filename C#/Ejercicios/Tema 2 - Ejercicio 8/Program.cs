using System;

namespace Tema_2___Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int dia;
            int anio;
            int mes;
            DateTime diaIngresado;
            DateTime diaHoy= DateTime.Now;
            TimeSpan resultado;



            Console.WriteLine("Ingrese fecha de nacimiento:");
            numeroIngresadoTexto = Console.ReadLine();
            dia = int.Parse(numeroIngresadoTexto);

            Console.WriteLine("Ingrese mes de nacimiento:");
            numeroIngresadoTexto = Console.ReadLine();
            mes = int.Parse(numeroIngresadoTexto);

            Console.WriteLine("Ingrese año de nacimiento:");
            numeroIngresadoTexto = Console.ReadLine();
            anio = int.Parse(numeroIngresadoTexto);

            diaIngresado = new DateTime (anio, mes, dia, 0, 0,0);

            resultado = (diaHoy - diaIngresado);
            Console.WriteLine($"Usted a vivio {resultado.TotalDays:N0} dias");
        }
    }
}