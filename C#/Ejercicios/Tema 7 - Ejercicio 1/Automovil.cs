using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_1
{
    public class Automovil : VehicuoTerrestre
    {
        int cantidadPasajeros;
        short cantidadMarchas;


        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantPasajeros) : base (cantidadRuedas,cantidadPuertas,color) 
        {
            this.cantidadPasajeros = cantPasajeros;
            this.cantidadMarchas = cantidadMarchas; 
        }

        public string mostrarDatosVehiculo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Vehiculo: Auto\n");
            sb.Append(base.mostrarDatos());
            sb.Append($"Cantidad de marchas: {this.cantidadMarchas}\n");
            sb.Append($"Cantidad de pasajeros: {this.cantidadPasajeros}\n");
            return sb.ToString();
        }
    }
}
