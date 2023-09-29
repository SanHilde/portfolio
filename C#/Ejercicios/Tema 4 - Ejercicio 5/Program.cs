namespace Tema_4___Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Kelvin temK1 = new Kelvin (100);
            Kelvin temK2 = new Kelvin(85);
            Celcius temC1 = new Celcius(50);
            Celcius temC2 = new Celcius(35);
            Fahrenheit temF1 = new Fahrenheit(200);
            Fahrenheit temF2 = new Fahrenheit(250);

            
            Console.WriteLine($"{(float)temK1} °K + {(float)temC1} °C (que equivale a {(float)((Kelvin)temC1)}°K) = {(float)(temK1 + temC1)}°K");
            Console.WriteLine($"{(float)temK1} °K + {(float)temF2} °F (que equivale a {(float)((Kelvin)temF2)}°K) = {(float)(temK1 + temF2)}°K");
            Console.WriteLine($"{(float)temK1} °K - {(float)temC1} °C (que equivale a {(float)((Kelvin)temC1)}°K) = {(float)(temK1 - temC1)}°K");
            Console.WriteLine($"{(float)temK1} °K - {(float)temF2} °F (que equivale a {(float)((Kelvin)temF2)}°K) = {(float)(temK1 - temF2)}°K");

            Console.WriteLine($"{(float)temC1} °C + {(float)temK1} °K (que equivale a {(float)((Celcius)temK1)}°C) = {(float)(temC1 + temK1)}°C");
            Console.WriteLine($"{(float)temC1} °C + {(float)temF2} °F (que equivale a {(float)((Celcius)temF2)}°C) = {(float)(temC1 + temF2)}°C");
            Console.WriteLine($"{(float)temC1} °C - {(float)temK1} °K (que equivale a {(float)((Celcius)temK1)}°C) = {(float)(temC1 - temK1)}°C");
            Console.WriteLine($"{(float)temC1} °C - {(float)temF2} °F (que equivale a {(float)((Celcius)temF2)}°C) = {(float)(temC1 - temF2)}°C");

            Console.WriteLine($"{(float)temF2} °F + {(float)temC1} °C (que equivale a {(float)((Fahrenheit)temC1)}°F) = {(float)(temF2 + temC1)}°F");
            Console.WriteLine($"{(float)temF2} °F + {(float)temK1} °K (que equivale a {(float)((Fahrenheit)temK1)}°F) = {(float)(temF2 + temK1)}°F");
            Console.WriteLine($"{(float)temF2} °F - {(float)temC1} °C (que equivale a {(float)((Fahrenheit)temC1)}°F) = {(float)(temF2 - temC1)}°F");
            Console.WriteLine($"{(float)temF2} °F - {(float)temK1} °K (que equivale a {(float)((Fahrenheit)temK1)}°F) = {(float)(temF2 - temK1)}°F");

            

        }
    }
}