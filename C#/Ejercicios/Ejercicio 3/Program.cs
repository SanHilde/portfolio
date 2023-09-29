using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace Ejercicio_3
{
    internal class Program
    {
        /*Consigna
            Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

            Validar que el dato ingresado por el usuario sea un número.

            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

            Si ingresa "salir", cerrar la consola.

            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
        */
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            bool itsTrue;
            int bandera = 0;
            int banderaNumero = 0;
            //int contador;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresadoTexto = Console.ReadLine();
            itsTrue = int.TryParse(numeroIngresadoTexto, out numeroIngresado);

            do
            {
                if (itsTrue == true && numeroIngresado>0)
                {
                    do
                    {
                        for (int i = 2; i < numeroIngresado ; i++) //Math.Sqrt(numeroIngresado); i++)
                        {
                            if (numeroIngresado % i == 0)
                            {
                                bandera = 1;
                                break;
                            }
                        }
                        if (bandera != 1)
                        {
                            Console.WriteLine("El numero {0} es primo", numeroIngresado);
                        } else
                        {
                            bandera = 0;
                        }
                        numeroIngresado = numeroIngresado - 1;
                    } while (numeroIngresado != 0);
                    banderaNumero = 1;
                }
                else
                {
                    Console.WriteLine("Dato incorrecto, si desea salir, escriba 'salir', si no, reingrese un numero: ");
                    numeroIngresadoTexto = Console.ReadLine();
                    numeroIngresadoTexto = numeroIngresadoTexto.ToLower();
                    itsTrue = int.TryParse(numeroIngresadoTexto, out numeroIngresado);
                }
                if (banderaNumero==1)
                {
                    Console.WriteLine("Si desea ingresar otro numero, escriba 'si':");
                    numeroIngresadoTexto = Console.ReadLine();
                    numeroIngresadoTexto = numeroIngresadoTexto.ToLower();
                    if (numeroIngresadoTexto == "si")
                    {
                        Console.WriteLine("Ingrese un numero o 'salir' si asi lo desea:");
                        numeroIngresadoTexto = Console.ReadLine();
                        itsTrue = int.TryParse(numeroIngresadoTexto, out numeroIngresado);
                    } else
                    {
                        numeroIngresadoTexto = "salir";
                    }
                    banderaNumero = 0;
                }

            } while (numeroIngresadoTexto != "salir");
        }
    }
}