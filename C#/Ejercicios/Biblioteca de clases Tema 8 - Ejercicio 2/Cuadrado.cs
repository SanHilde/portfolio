using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases_Tema_8___Ejercicio_2
{
    public sealed class Cuadrado: Rectangulo
    {
        int baseCuadrado;

        public Cuadrado(int cara): base (cara, cara)
        {
            this.baseCuadrado = cara;
        }

        public override string Dibujar()
        {
            return "Dibujando cuadrado...";
        }

        /*
        public override double CalcularSuperficie()
        {
            return this.baseCuadrado*this.baseCuadrado;
        }
        public override double CalcularPerimetro()
        {
            return this.baseCuadrado * 4; 
        }
        */
    }
}
