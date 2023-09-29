using System.Collections;

namespace Tema_5___Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string producto;
            int numeroIngresado;
            string numeroIngresadoTexto;
            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();

            Producto producto1 = new Producto("Papas", 100);
            Producto producto2 = new Producto("Saladix", 150);
            Producto producto3 = new Producto("Alfajor", 120);
            Producto producto4 = new Producto("Oreo", 125);
            Producto producto5 = new Producto("Chocolate", 110);
            Producto producto6 = new Producto("7up", 120);
            Producto producto7 = new Producto("Fanta", 115);
            Producto producto8 = new Producto("Cereales", 90);
            Producto producto9 = new Producto("Mani con chocolate", 85);
            Producto producto10 = new Producto("Agua", 80);



            maquinaExpendedora.Add(1, producto1);
            maquinaExpendedora.Add(2, producto2);
            maquinaExpendedora.Add(3, producto3);
            maquinaExpendedora.Add(4, producto4);
            maquinaExpendedora.Add(5, producto5);
            maquinaExpendedora.Add(6, producto6);
            maquinaExpendedora.Add(7, producto7);
            maquinaExpendedora.Add(8, producto8);
            maquinaExpendedora.Add(9, producto9);
            maquinaExpendedora.Add(10, producto10);

            MostrarDatos(maquinaExpendedora);
            do
            {
                Console.WriteLine("Ingrese el codigo del producto que desea:");
                numeroIngresadoTexto = Console.ReadLine();
                if (numeroIngresadoTexto!= "S")
                {
                    numeroIngresado = int.Parse(numeroIngresadoTexto);
                    if (maquinaExpendedora.ContainsKey(numeroIngresado) == true)
                    {
                        //producto = maquinaExpendedora.TryGetValue(numeroIngresado, out producto);
                        Console.WriteLine($"Recibio el producto: {maquinaExpendedora[numeroIngresado].GetNombre()}, codigo: {numeroIngresado}");

                        maquinaExpendedora.Remove(numeroIngresado);
                        MostrarDatos(maquinaExpendedora);

                    }
                }
            } while (numeroIngresadoTexto != "S");


        }
        static void MostrarDatos(Dictionary<int, Producto> maquinaExpendedora)
        {
            foreach (var producto in maquinaExpendedora)
            {
                Console.WriteLine($"Producto: {producto.Value.GetNombre()}, precio: ${producto.Value.GetPrecio()}, codigo: {producto.Key}");
            }
            Console.WriteLine("Para 'SALIR' ingrese 'S'\n");


        }
    }
}