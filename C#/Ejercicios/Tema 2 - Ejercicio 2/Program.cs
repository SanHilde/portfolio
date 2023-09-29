namespace Tema_2___Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            int sumatoria = 0;
            string respuesta;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroIngresadoTexto = Console.ReadLine();
                numeroIngresado = int.Parse(numeroIngresadoTexto);
                sumatoria = sumatoria + numeroIngresado;
                Console.WriteLine("¿Desea continuar? (S/N):");
                respuesta = Console.ReadLine();
              
            } while (Validador.ValidarRespuesta(respuesta) == true);

            Console.WriteLine($"La sumatoria fue de {sumatoria}");
        }
    }
    internal class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "S")
            {
                return true;
            } else
            {
                return false;  
            }
        }
    }
}