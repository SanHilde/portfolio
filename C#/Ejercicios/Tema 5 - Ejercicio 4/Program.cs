namespace Tema_5___Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Jugador jugador1 = new Jugador(39349706, "Santiago Hildebrandt", 10, 8);
            Jugador jugador2 = new Jugador(11111111, "Cristiano Ronaldo", 5, 10);
            Jugador jugador3 = new Jugador(22222222, "Lio Messi", 20, 10);
            Jugador jugador4 = new Jugador(123123123, "Paredes Leandro");
            Jugador jugador5 = new Jugador(44444222, "asdasd weweq");
            Equipo argentina = new Equipo(4, "argentina");

            Console.WriteLine(argentina + jugador1);
            Console.WriteLine(argentina + jugador2);
            Console.WriteLine(argentina + jugador3);
            Console.WriteLine(argentina + jugador4);
            Console.WriteLine(argentina + jugador5);

            Console.WriteLine(jugador1 == jugador1);
            Console.WriteLine(jugador1 == jugador2);

            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(argentina.MostrarEquipo());

        }
    }
}