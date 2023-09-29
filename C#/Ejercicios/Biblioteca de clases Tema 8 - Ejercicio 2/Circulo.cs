using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases_Tema_8___Ejercicio_2
{
    public sealed class Circulo : Figura
    {
        float radio;

        public Circulo(float radio) 
        {
            this.radio = radio;
        }
        public override string Dibujar()
        {
            return "Dibujando circulo...";
        }
        public override double CalcularSuperficie()
        {
            return (double) 3.14 * this.radio * this.radio;
        }
        public override double CalcularPerimetro()
        {
            return (double) 3.14 * this.radio *2;
        }
    }
}
