using Tema_2___Ejercicio_3._1;

namespace Tema_4___Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 5;
            NumeroDecimal objDecimal2 = 9;


            Console.WriteLine($"{(string) objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string) objBinario)))})+ {(double) objDecimal} = {objBinario+objDecimal} o {Conversor.ConvertirBinarioADecimal(Int32.Parse((objBinario + objDecimal)))}");
            Console.WriteLine($"{(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))})+ {(double)objDecimal} = {objBinario - objDecimal} o {Conversor.ConvertirBinarioADecimal(Int32.Parse((objBinario - objDecimal)))}");
            Console.WriteLine($"{(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))}) == {(double)objDecimal}: {objBinario == objDecimal}");
            Console.WriteLine($"{(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))}) != {(double)objDecimal}: {objBinario != objDecimal}");
            Console.WriteLine($"{(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))}) == {(double)objDecimal2}: {objBinario == objDecimal2}");
            Console.WriteLine($"{(double)objDecimal} + {(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))})= {objDecimal + objBinario}");
            Console.WriteLine($"{(double)objDecimal} - {(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))})= {objDecimal - objBinario}");
            Console.WriteLine($"{(double)objDecimal2} - {(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))})= {objDecimal2 - objBinario}");
            Console.WriteLine($"{(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))}) == {(double)objDecimal}: {objDecimal == objBinario}");
            Console.WriteLine($"{(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))}) != {(double)objDecimal}: {objDecimal != objBinario}");
            Console.WriteLine($"{(string)objBinario} (que es {Conversor.ConvertirBinarioADecimal(Int32.Parse(((string)objBinario)))}) == {(double)objDecimal2}: {objDecimal2 == objBinario}");
        }
    }
}