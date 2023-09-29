using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_1
{
    public class Moto : VehicuoTerrestre
    {
        short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color )
        {
            this.cilindrada = cilindrada;
        }

        public string mostrarDatosVehiculo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Vehiculo: Moto\n");
            sb.Append(base.mostrarDatos());
            sb.Append ($"Cilindrada: {this.cilindrada} \n");
            return sb.ToString();
        }
    }
}
