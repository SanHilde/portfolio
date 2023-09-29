namespace Tema_2___Ejercicio_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            string numeroEnBinario;
            double numeroDecimal;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroIngresadoTexto);
            numeroEnBinario = Conversor.ConvertirDecimalABinario(numeroIngresado);

            Console.WriteLine($"El numero {numeroIngresado} en binario es: {numeroEnBinario}");

            //Console.WriteLine("Ingrese un numero binario:");
            //numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroEnBinario);
            numeroDecimal = Conversor.ConvertirBinarioADecimal(numeroIngresado);

            Console.WriteLine($"El numero binario {numeroIngresado} en decimal es: {numeroDecimal}");
        }
    
    }

}