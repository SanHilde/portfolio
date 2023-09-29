namespace Tema_2___Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroIngresadoUno;
            string operador;
            float numeroIngresadoDos;
            string resultado;
            string respuesta=null;
            bool esNumero;

            do
            {
                numeroIngresadoUno = Calculadora.PedirNumero();


                Console.WriteLine("Ingrese operador '+', '-', '*' o '/':"); ;
                operador = Console.ReadLine();

                numeroIngresadoDos = Calculadora.PedirNumero();

                resultado = Calculadora.Calcular(numeroIngresadoUno, numeroIngresadoDos, operador);
                Console.WriteLine($"{numeroIngresadoUno} {operador} {numeroIngresadoDos} = {resultado}");
                Console.WriteLine("¿Desea realizar otra operacion? (S/N):");
                respuesta = Console.ReadLine();
            } while (Calculadora.ValidarRespuesta(respuesta) == true);

        }
    }
}