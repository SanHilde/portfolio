using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema_2___Ejercicio_3._1;

namespace Tema_4___Ejercicio_3
{
    public class NumeroDecimal
    {
        double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroDecimal(double nd)
        {
            return new NumeroDecimal(nd);
        }
        public static explicit operator double(NumeroDecimal nd)
        {
            return nd.numero;
        }
        //

        public static int operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            string numeroConvertido;
            double binarioEnDecimal;
            int resultado;

            numeroConvertido = (string)nb;
            binarioEnDecimal = Conversor.ConvertirBinarioADecimal(Int32.Parse(numeroConvertido));
            resultado = (int)(binarioEnDecimal + nd.numero);
            return resultado;
        }
        public static int operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            string numeroConvertido;
            double binarioEnDecimal;
            int resultado;

            numeroConvertido = (string)nb;
            binarioEnDecimal = Conversor.ConvertirBinarioADecimal(Int32.Parse(numeroConvertido));
            resultado = (int)(nd.numero- binarioEnDecimal);
            return resultado;
        }
        
        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            string numeroConvertido;
            double binarioEnDecimal;
            //int resultado;

            numeroConvertido = (string)nb;
            binarioEnDecimal = Conversor.ConvertirBinarioADecimal(Int32.Parse(numeroConvertido));
            if ((double) nd == binarioEnDecimal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nb == nd);
        }
        
    }
}
