using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4___Ejercicio_5
{
    public class Celcius
    {
        float temperatura;
        //F = C* (9/5) + 32
        //C = (F-32) * 5/9
        //F = K* 9/5 – 459.67
        //K = (F + 459.67) * 5/9

        public Celcius(float temperatura)
        {
            this.temperatura = temperatura;
        }
        public static explicit operator float(Celcius numero)
        {
            return numero.temperatura;
        }

        public static explicit operator Celcius (Kelvin tempKelvin)
        {
            float conversion;
            conversion = ((float) tempKelvin)-(float) 273.15;
            return new Celcius (conversion);
        }
        public static explicit operator Celcius(Fahrenheit tempFarenheit)
        {
            float conversion;
            conversion = ((float)tempFarenheit - 32 )*5/9;
            return new Celcius (conversion);
        }
        public static Celcius operator +(Celcius temp1, Kelvin temp2)
        {
            return new Celcius(temp1.temperatura + ((Celcius)temp2).temperatura);
        }
        public static Celcius operator +(Celcius temp1, Fahrenheit temp2)
        {
            return new Celcius(temp1.temperatura + ((Celcius)temp2).temperatura);
        }
        public static Celcius operator -(Celcius temp1, Kelvin temp2)
        {
            return new Celcius(temp1.temperatura - ((Celcius)temp2).temperatura);
        }
        public static Celcius operator -(Celcius temp1, Fahrenheit temp2)
        {
            return new Celcius(temp1.temperatura - ((Celcius)temp2).temperatura);
        }
    }
}
