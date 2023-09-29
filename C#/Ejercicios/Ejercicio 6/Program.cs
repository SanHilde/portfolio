namespace Ejercicio_6
{/*Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            string numeroIngresadoTextoDos;
            int numeroIngresadoDos;


            Console.WriteLine("Ingrese año de inicio:");
            numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroIngresadoTexto);

            Console.WriteLine("Ingrese año de finzalizacion:");
            numeroIngresadoTextoDos = Console.ReadLine();
            numeroIngresadoDos = int.Parse(numeroIngresadoTextoDos);

            for (int i = numeroIngresado; i<= numeroIngresadoDos; i++)
            {
                if (i % 4 == 0)
                {
                    if (i % 100 == 0)
                    {
                        if (i %400 == 0)
                        {
                            Console.WriteLine($"{i} es un año bisiesto");
                        }
                    } else
                    {
                        Console.WriteLine($"{i} es un año bisiesto");
                    }
                }
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}