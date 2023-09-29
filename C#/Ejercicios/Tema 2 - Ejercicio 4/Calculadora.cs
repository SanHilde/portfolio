using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tema_2___Ejercicio_4
{
    internal class Calculadora
    {
        public static string Calcular(float numeroUno,float NumeroDos,string operador) 
        {
            float resultado=0;
            string devolucion=null;
            int bandera = 0;
            switch (operador)
            {
                case "+":
                    resultado = numeroUno + NumeroDos;
                    break;
                case "-":
                    resultado = numeroUno - NumeroDos;
                    break;
                case "*":
                    resultado = numeroUno * NumeroDos;
                    break;
                case "/":
                    if (Validar (NumeroDos) == true)
                    { 
                        resultado = (numeroUno) / NumeroDos; 
                    } else
                    {
                        bandera = 1;
                        devolucion = "No se puede dividir por 0";
                    }
                    break;
                default:
                    bandera = 1;
                    devolucion = "No ingreso un operador solicitado";
                    break;
            }
            if (bandera == 0)
            {
                devolucion = resultado.ToString();
            }
            return devolucion;
        }
        private static bool Validar(float numero)
        {
            if (numero == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static float PedirNumero()
        {
            string numeroIngresadoTexto;
            bool esNumero;
            float numeroIngresado=0;

            Console.WriteLine("Ingrese numero:");
            numeroIngresadoTexto = Console.ReadLine();
            esNumero = float.TryParse(numeroIngresadoTexto, out numeroIngresado);
            while (esNumero != true)
            {
                Console.WriteLine("Lo ingresado no es un numero, ingrese un numero:");
                numeroIngresadoTexto = Console.ReadLine();
                esNumero = float.TryParse(numeroIngresadoTexto, out numeroIngresado);
            }
            return numeroIngresado;
        }
    }
}
