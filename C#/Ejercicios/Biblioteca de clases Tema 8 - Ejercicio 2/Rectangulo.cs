using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases_Tema_8___Ejercicio_2
{
    public class Rectangulo : Figura
    {
        int baseRec;
        int altura;

        public Rectangulo(int baseRec, int altura)
        {
            this.baseRec = baseRec;
            this.altura = altura;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo...";
        }
        public override double CalcularSuperficie()
        {
            return this.baseRec * this.altura;
        }
        public override double CalcularPerimetro()
        {
            return this.baseRec * 2 + this.altura * 2;
        }


    }
}
