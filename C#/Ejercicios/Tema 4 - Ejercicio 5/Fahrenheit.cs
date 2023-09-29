using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4___Ejercicio_5
{
    public class Fahrenheit
    {
        float temperatura;
        //F = C* (9/5) + 32
        //C = (F-32) * 5/9
        //F = K* 9/5 – 459.67
        //K = (F + 459.67) * 5/9

        public Fahrenheit(float temperatura)
        {
            this.temperatura = temperatura;
        }
        public static explicit operator float(Fahrenheit numero)
        {
            return numero.temperatura;
        }
        public static explicit operator Fahrenheit (Celcius tempCelcius)
        {
            return new Fahrenheit((((float)tempCelcius)*9/5)+32);
        }
        public static explicit operator Fahrenheit (Kelvin tempKelvin)
        {
            return new Fahrenheit((((float)tempKelvin) * 9 / 5) - (float)459.67);
        }
        public static Fahrenheit operator +(Fahrenheit temp1, Celcius temp2)
        {
            return new Fahrenheit(temp1.temperatura + ((Fahrenheit)temp2).temperatura);
        }
        public static Fahrenheit operator +(Fahrenheit temp1, Kelvin temp2)
        {
            return new Fahrenheit(temp1.temperatura + ((Fahrenheit)temp2).temperatura);
        }
        public static Fahrenheit operator -(Fahrenheit temp1, Celcius temp2)
        {
            return new Fahrenheit(temp1.temperatura - ((Fahrenheit)temp2).temperatura);
        }
        public static Fahrenheit operator -(Fahrenheit temp1, Kelvin temp2)
        {
            return new Fahrenheit(temp1.temperatura - ((Fahrenheit)temp2).temperatura);
        }
    }
}
