namespace Tema_7___Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colores colores = (Colores) 1;

            Moto moto1 = new Moto(2, 0, colores , 150);
            Automovil auto1 = new Automovil(4,3,Colores.Blanco,5,5);
            Camion camion1 = new Camion(12, 2, Colores.Rojo, 12, 10000);


            Console.WriteLine(moto1.mostrarDatosVehiculo());
            Console.WriteLine(auto1.mostrarDatosVehiculo());
            Console.WriteLine(camion1.mostrarDatosVehiculo());
        }
    }
}