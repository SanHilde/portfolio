using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases_Tema_8___Ejercicio_2
{
    public abstract class Figura
    {
        public virtual string Dibujar ()
        {
            return "Dibujando forma...";
        }
        public abstract double CalcularSuperficie();
        public abstract double CalcularPerimetro();

    }
}
