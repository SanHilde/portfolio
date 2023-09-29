using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_1
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro
    }   

    public class VehicuoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;

        public VehicuoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public string mostrarDatos ()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cantidad de ruedas: {this.cantidadRuedas}\n");
            sb.Append($"Cantidad de puertas: {this.cantidadPuertas}\n");
            sb.Append($"Color: {this.color}\n");
            return sb.ToString();

        }
    }


}



