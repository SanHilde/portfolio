namespace Tema_2___Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroIngresadoTexto);


            Console.WriteLine($"El factorial de {numeroIngresado} es {Factorial(numeroIngresado)}");
        }

        static string Factorial (int numero)
        {
            int resultado=numero;
            int bandera = 0;
            string resultadoString=null;

            if (numero == 0)
            {
                resultado = 1;
            } else
            {
                if (numero > 0)
                {
                    for (int i = numero - 1; i != 0; i--)
                    {
                        resultado = resultado * i;
                    }
                } else
                {
                    bandera = 1;
                    resultadoString = "inexistente. La función factorial se define sobre el conjunto de los números naturales";
                }
            }
           if (bandera == 0) 
            { 
                resultadoString = resultado.ToString();
            }

            return resultadoString;
        }
    }
}