namespace Tema_2___Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            int numeroEnBinario;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroIngresadoTexto);
            numeroEnBinario = Conversor.ConvertirDecimalABinario(numeroIngresado);

            Console.WriteLine($"El numero {numeroIngresado} en binario es: {numeroEnBinario}");
        }

    }

  
}