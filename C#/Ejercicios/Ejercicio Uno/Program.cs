namespace Ejercicio_Uno
{

//    Consigna
//Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            int contador = 1;
            int numeroMayor;
            int numeroMenor;
            int sumatoria=0;
            float promedio;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroIngresadoTexto);
            numeroMayor = numeroIngresado;
            numeroMenor = numeroIngresado;
            do
            {
                if (numeroIngresado > numeroMayor)
                {
                    numeroMayor = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado < numeroMenor)
                    {
                        numeroMenor = numeroIngresado;
                    }
                }
                contador += 1;
                sumatoria = sumatoria + numeroIngresado;
                if (contador < 6)
                {
                    Console.WriteLine("Ingrese un numero:");
                    numeroIngresadoTexto = Console.ReadLine();
                    numeroIngresado = int.Parse(numeroIngresadoTexto);
                }

            } while (contador < 7);

            promedio = sumatoria / 5;

            Console.WriteLine("Numero mayor: {0}, numero menor: {1}, promedio:{2}", numeroMayor, numeroMenor, promedio);
        }
    }
}