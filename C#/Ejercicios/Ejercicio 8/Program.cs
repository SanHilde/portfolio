namespace Ejercicio_8
{
    /*Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            char asterisco = '*';
            int contador = 1;

            do
            {
                Console.WriteLine("Ingrese la altura del triangulo que desea:");
                numeroIngresadoTexto = Console.ReadLine();
                numeroIngresado = int.Parse(numeroIngresadoTexto);
                if (numeroIngresado < 0)
                {
                    Console.WriteLine("ERROR, debe ingresar un numero positivio.");
                }
            } while (numeroIngresado < 0);

            for (int i = 0; i< numeroIngresado; i++)
            {
                    Console.WriteLine("".PadRight (contador,asterisco));//primero que imprime , el "", despues el len que tendra la cadena y por ultimo con que rellenar la cadena
                contador = contador + 2;

            }
        }
    }
}