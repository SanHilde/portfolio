using System.Data.Common;
using System.Reflection.Metadata.Ecma335;

namespace Tema_4___Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar dolarUno = new Dolar(6);
            Euro euroUno = new Euro(3);
            Pesos pesoUno = new Pesos(1000);
            Dolar dolarDos = new Dolar(12);
            Euro euroDos = new Euro(5);
            Pesos pesoDos = new Pesos(600);
            Dolar resultado;
            Pesos resultadoPesos;
            Euro resultadoEuro;

            resultado = dolarUno - euroUno;
            Console.WriteLine($"{dolarUno.GetCantidad()} dolares - {euroUno.GetCantidad()} euros (que equivalen a {((Dolar)euroUno).GetCantidad()} dolares) = {resultado.GetCantidad()} dolares");
            resultado = dolarUno - pesoUno;
            Console.WriteLine($"{dolarUno.GetCantidad()} dolares - {pesoUno.GetCantidad()} pesos (que equivalen a {((Dolar)pesoUno).GetCantidad()} dolares) = {resultado.GetCantidad()} dolares");
            resultado = dolarUno + pesoUno;
            Console.WriteLine($"{dolarUno.GetCantidad()} dolares + {pesoUno.GetCantidad()} pesos (que equivalen a {((Dolar)pesoUno).GetCantidad()} dolares) = {resultado.GetCantidad()} dolares");
            resultado = dolarUno + euroUno;
            Console.WriteLine($"{dolarUno.GetCantidad()} dolares + {euroUno.GetCantidad()} euros (que equivalen a {((Dolar)euroUno).GetCantidad()} dolares) = {resultado.GetCantidad()} dolares");
            Console.WriteLine($"{dolarUno.GetCantidad()} dolares == {pesoUno.GetCantidad()} pesos (que equivalen a {((Dolar)pesoUno).GetCantidad()} dolares) = {dolarUno == pesoUno}");
            Console.WriteLine($"{dolarUno.GetCantidad()} dolares != {pesoUno.GetCantidad()} pesos (que equivalen a {((Dolar)pesoUno).GetCantidad()} dolares) = {dolarUno != pesoUno}");
            Console.WriteLine($"{dolarUno.GetCantidad()} dolares == {euroUno.GetCantidad()} euros (que equivalen a {((Dolar)euroUno).GetCantidad()} dolares) = {dolarUno == euroUno}");
            Console.WriteLine($"{dolarUno.GetCantidad()} dolares != {euroUno.GetCantidad()} euros (que equivalen a {((Dolar)euroUno).GetCantidad()} dolares) = {dolarUno != euroUno}");

            resultadoPesos = pesoUno - euroUno;
            Console.WriteLine($"{pesoUno.GetCantidad()} pesos - {euroUno.GetCantidad()} euros (que equivalen a {((Pesos)euroUno).GetCantidad()} pesos) = {resultadoPesos.GetCantidad()} pesos");
            resultadoPesos = pesoUno - dolarUno;
            Console.WriteLine($"{pesoUno.GetCantidad()} pesos - {dolarUno.GetCantidad()} dolares (que equivalen a {((Pesos)dolarUno).GetCantidad()} pesos) = {resultadoPesos.GetCantidad()} pesos");
            resultadoPesos = pesoUno + euroUno;
            Console.WriteLine($"{pesoUno.GetCantidad()} pesos + {euroUno.GetCantidad()} euros (que equivalen a {((Pesos)euroUno).GetCantidad()} pesos) = {resultadoPesos.GetCantidad()} pesos");
            resultadoPesos = pesoUno + dolarUno;
            Console.WriteLine($"{pesoUno.GetCantidad()} pesos + {dolarUno.GetCantidad()} dolares (que equivalen a {((Pesos)dolarUno).GetCantidad()} pesos) = {resultadoPesos.GetCantidad()} pesos");

            resultadoEuro = euroUno - pesoUno;
            Console.WriteLine($"{euroUno.GetCantidad()} euro - {pesoUno.GetCantidad()} pesos (que equivalen a {((Euro)pesoUno).GetCantidad()} euro) = {resultadoEuro.GetCantidad()} euro");
            resultadoEuro = euroUno - dolarUno;
            Console.WriteLine($"{euroUno.GetCantidad()} euro - {dolarUno.GetCantidad()} dolares (que equivalen a {((Euro)dolarUno).GetCantidad()} euro) = {resultadoEuro.GetCantidad()} euro");
            resultadoEuro = euroUno + pesoUno;
            Console.WriteLine($"{euroUno.GetCantidad()} euro + {pesoUno.GetCantidad()} pesos (que equivalen a {((Euro)pesoUno).GetCantidad()} euro) = {resultadoEuro.GetCantidad()} euro");
            resultadoEuro = euroUno + dolarUno;
            Console.WriteLine($"{euroUno.GetCantidad()} euro + {dolarUno.GetCantidad()} dolares (que equivalen a {((Euro)dolarUno).GetCantidad()} euro) = {resultadoEuro.GetCantidad()} euro");

            Console.WriteLine($"Euro1==Euro1: {euroUno == euroUno}");
            Console.WriteLine($"Euro1==Dolar1: {euroUno == dolarUno}");
            Console.WriteLine($"Euro1==Peso1: {euroUno == pesoUno}");
            Console.WriteLine($"Euro1==Euro2: {euroUno == euroDos}");

            Console.WriteLine($"Dolar1==Euro1: {dolarUno == euroUno}");
            Console.WriteLine($"Dolar1==Dolar1: {dolarUno == dolarUno}");
            Console.WriteLine($"Dolar1==Peso2: {dolarUno == pesoDos}");
            Console.WriteLine($"Dolar1==Dolar2: {dolarUno == dolarDos}");

            Console.WriteLine($"Peso1==Euro1: {pesoUno == euroUno}");
            Console.WriteLine($"Peso1==Dolar1: {pesoUno == dolarUno}");
            Console.WriteLine($"Peso1==Peso1: {pesoUno == pesoUno}");
            Console.WriteLine($"Peso1==Peso2: {pesoUno == pesoDos}");




        }
    }
}
