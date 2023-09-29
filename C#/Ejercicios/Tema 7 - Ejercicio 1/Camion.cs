using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_1
{
    public class Camion : VehicuoTerrestre
    {
        int pesoCarga;
        short cantidadMarchas;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = pesCarga;
            this.cantidadMarchas = cantidadMarchas;
        }
        public string mostrarDatosVehiculo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Vehiculo: Camion\n");
            sb.Append(base.mostrarDatos());
            sb.Append($"Cantidad de marchas: {this.cantidadMarchas} \n");
            sb.Append($"Peso: {this.pesoCarga} kg \n");
            return sb.ToString();
        }

    }
}
