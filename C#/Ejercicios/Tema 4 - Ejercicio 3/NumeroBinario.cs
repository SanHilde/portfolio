using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Tema_2___Ejercicio_3._1;

namespace Tema_4___Ejercicio_3
{
    public class NumeroBinario
    {
        string numero;
        
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroBinario (string nb)
        {
            return new NumeroBinario(nb); 
        }
        public static explicit operator string(NumeroBinario nb)
        {
            return nb.numero;
        }
        
        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            double numeroConvertido;
            double binarioEnDecimal;
            int resultado;

            numeroConvertido = (double) nd;
            binarioEnDecimal = Conversor.ConvertirBinarioADecimal(Int32.Parse(nb.numero));
            resultado =(int) (binarioEnDecimal + numeroConvertido);
            return Conversor.ConvertirDecimalABinario(resultado);
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double numeroConvertido;
            double binarioEnDecimal;
            int resultado;

            numeroConvertido = (double)nd;
            binarioEnDecimal = Conversor.ConvertirBinarioADecimal(Int32.Parse(nb.numero));
            resultado = (int)(binarioEnDecimal - numeroConvertido);
            return Conversor.ConvertirDecimalABinario(resultado);

        }
        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            double numeroConvertido;
            double binarioEnDecimal;
            //int resultado;

            numeroConvertido = (double)nd;
            binarioEnDecimal = Conversor.ConvertirBinarioADecimal(Int32.Parse(nb.numero));
            if (numeroConvertido == binarioEnDecimal) 
            {
                return true; 
            } else
            { 
                return false; 
            }
        }
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }
    }
}
