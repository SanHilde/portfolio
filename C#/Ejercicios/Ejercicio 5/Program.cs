using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoTexto;
            int numeroIngresado;
            int SumatoriaListaUno = 0;
            int SumatoriaListaDos = 0;
            int contador = 0;
            int i;
            int bandera = 0;
            int PosibleSumatoriaUno = 0;
            int PosibleTopeListaUno = 0;
            int PosibleSumatoriaDos = 0;
            int PosibleTopeListaDos = 0;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresadoTexto = Console.ReadLine();
            numeroIngresado = int.Parse(numeroIngresadoTexto);

            SumatoriaListaDos = numeroIngresado;

            for (i = 1; i <= numeroIngresado; i++)
            {
                if (SumatoriaListaUno > SumatoriaListaDos)
                {
                    do
                    {
                        contador++;
                        SumatoriaListaDos = SumatoriaListaDos + numeroIngresado - contador;
                    } while (SumatoriaListaUno > SumatoriaListaDos);
                    i--;
                }
                else
                {
                    SumatoriaListaUno = SumatoriaListaUno + i;
                }


                if ((numeroIngresado - contador) == i)
                {
                    SumatoriaListaUno = SumatoriaListaUno - i;
                    SumatoriaListaDos = SumatoriaListaDos - i;
                    i = i - 1;
                    contador = numeroIngresado - contador + 1;
                    if (SumatoriaListaUno == SumatoriaListaDos)
                    {
                        Console.WriteLine($"Se sumo del 1 hasta el {i}, dando como resultado = {SumatoriaListaUno}\n" +
                        $"Se sumo del {numeroIngresado} hasta el {contador}, dando como resultado = {SumatoriaListaDos}\n" +
                        $"Por lo tanto, el numero centro es {i + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"Se sumo del 1 hasta el {i}, dando como resultado = {SumatoriaListaUno}\n" +
                                            $"Se sumo del {numeroIngresado} hasta el {contador}, dando como resultado = {SumatoriaListaDos}\n" +
                                            $"En ningun momento hubo coincidencia, por lo tanto, no existe numero centrico");
                        if (bandera == 1)
                        {
                            Console.WriteLine($"Por otra parte, cuando se sumo del 1 hasta el {PosibleTopeListaUno}, dio como resultado = {PosibleSumatoriaUno}\n" +
                                        $"Se sumo del {numeroIngresado} hasta el {PosibleTopeListaDos}, dio como resultado = {PosibleSumatoriaDos}\n" +
                                        $"Por lo tanto, un posible conjunto de numeros centricos es del {PosibleTopeListaUno + 1} al {PosibleTopeListaDos - 1}");
                        }
                    }
                    break;
                }
                if (SumatoriaListaUno == SumatoriaListaDos)
                {
                    bandera = 1;
                    PosibleSumatoriaUno = SumatoriaListaUno;
                    PosibleTopeListaUno = i;
                    PosibleSumatoriaDos = SumatoriaListaDos;
                    PosibleTopeListaDos = numeroIngresado - contador;
                }
            }
        }
    }
}