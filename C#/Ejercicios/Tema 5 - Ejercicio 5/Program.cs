namespace Tema_5___Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Competencia TC200 = new Competencia(30, 5);

            AutoF1 auto1 = new AutoF1(25, "Ferrari");
            AutoF1 auto2 = new AutoF1(10, "Audi");
            AutoF1 auto3 = new AutoF1(20, "BMW");
            AutoF1 auto4 = new AutoF1(13, "McClaren");
            AutoF1 auto5 = new AutoF1(25, "Ferrari");
            AutoF1 auto6 = new AutoF1(26, "Ferrari");
            AutoF1 auto7 = new AutoF1(11, "Audi");

            Console.WriteLine("Datos de los autos sin competir:");
            Console.WriteLine(auto1.MostrarDatos());
            Console.WriteLine(auto2.MostrarDatos());
            Console.WriteLine(auto5.MostrarDatos());

            _ = TC200 + auto1;
            _ = TC200 + auto1;
            Console.WriteLine("Se intento agregar el mismo auto dos veces a la competencia\n");
            _ = TC200 + auto2;
            _= TC200 + auto3;
            Console.WriteLine("\nLista incompleta:");
            Console.WriteLine(TC200.MostrarDatos());
            _ = TC200 + auto4;
            _ = TC200 + auto5;
            Console.WriteLine("Se intento agregar un auto igual a otro a la competencia\n");
            _ = TC200 + auto6;
            _ = TC200 + auto7;
            Console.WriteLine("Se intento agregar un auto cuando la lista esta llena\n");
            Console.WriteLine("\nLista completa:");
            Console.WriteLine(TC200.MostrarDatos());
            _ = TC200 - auto7;
            Console.WriteLine("Se intento eliminar un auto que no esta en competencia\n");
            _ = TC200 - auto6;
            _= TC200 + auto7;
            Console.WriteLine("Se elimino un auto y se agrego un nuevo\n");


            Console.WriteLine("\nDatos de los autos al competir:");
            Console.WriteLine (auto1.MostrarDatos());
            Console.WriteLine(auto2.MostrarDatos());
            Console.WriteLine(auto5.MostrarDatos());
            Console.WriteLine("\nLista completa:");
            Console.WriteLine(TC200.MostrarDatos());

        }
    }
}