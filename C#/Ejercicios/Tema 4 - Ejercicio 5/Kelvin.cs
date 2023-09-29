using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4___Ejercicio_5
{
    public class Kelvin
    {
        float temperatura;
        //F = C* (9/5) + 32
        //C = (F-32) * 5/9
        //F = K* 9/5 – 459.67
        //K = (F + 459.67) * 5/9

        public Kelvin(float temperatura)
        {
            this.temperatura = temperatura;
        }
        public static explicit operator float(Kelvin numero)
        {
            return numero.temperatura;
        }
        public static explicit operator Kelvin(Celcius tempCelcius)
        {
            return new Kelvin(((float)tempCelcius) + (float)273.15);
        }
        public static explicit operator Kelvin(Fahrenheit tempFahrenheit)
        {
            return new Kelvin(((float)tempFahrenheit + (float)459.67) * 5 / 9);
        }
        public static Kelvin operator +(Kelvin tempKelvin, Celcius tempCelcius)
        {
            return new Kelvin(tempKelvin.temperatura + ((Kelvin)tempCelcius).temperatura);
        }
        public static Kelvin operator +(Kelvin tempKelvin, Fahrenheit temp2)
        {
            return new Kelvin(tempKelvin.temperatura + ((Kelvin)temp2).temperatura);
        }
        public static Kelvin operator -(Kelvin tempKelvin, Celcius tempCelcius)
        {
            return new Kelvin(tempKelvin.temperatura - ((Kelvin)tempCelcius).temperatura);
        }
        public static Kelvin operator -(Kelvin tempKelvin, Fahrenheit temp2)
        {
            return new Kelvin(tempKelvin.temperatura - ((Kelvin)temp2).temperatura);
        }
    }
}
