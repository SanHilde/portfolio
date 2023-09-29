using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace Tema_3___Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto puntoUno;
            Punto puntoDos;
            Rectangulo nuevoRectangulo;


            puntoUno = new Punto();
            puntoDos = new Punto();
            nuevoRectangulo = new Rectangulo();

            puntoUno.CrearPunto(2, 5);
            puntoDos.CrearPunto(4, 10);
            nuevoRectangulo.CrearRectangulo(puntoUno, puntoDos);


            MostrarDatos(nuevoRectangulo);
            Console.WriteLine($"Area: {nuevoRectangulo.CalcularArea()}");
            Console.WriteLine($"Perimetro: {nuevoRectangulo.CalcularPerimetro()}");
        }
        static void MostrarDatos(Rectangulo rectangulo)
        {
            int baseCuadrado;
            int altura;
            int baseUno;
            int baseDos;
            int alturaUno;
            int alturaDos;

            baseUno = rectangulo.Vertice1.GetX();
            baseDos = rectangulo.Vertice4.GetX();
            alturaUno = rectangulo.Vertice1.GetY();
            alturaDos = rectangulo.Vertice2.GetY();

            baseCuadrado = Math.Abs(baseUno - baseDos);
            altura = Math.Abs(alturaUno - alturaDos);

            Console.WriteLine($"Vertice 1: ({rectangulo.Vertice1.GetX()},{rectangulo.Vertice1.GetY()})\n" +
                $"Vertice 2: ({rectangulo.Vertice2.GetX()},{rectangulo.Vertice2.GetY()})\n" +
                $"Vertice 3: ({rectangulo.Vertice3.GetX()},{rectangulo.Vertice3.GetY()})\n" +
                $"Vertice 4: ({rectangulo.Vertice4.GetX()},{rectangulo.Vertice4.GetY()})\n" +
                $"Base: {baseCuadrado}\n" +
                $"Altura: {altura}");
        }
    }
    internal class Punto
    {
        int x;
        int y;

        int Xa
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        int Ya
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int GetX()
        {
            return Xa;
        }
        public int GetY()
        {
            return Ya;
        }
        public void CrearPunto(int x, int y)
        {
            Ya = y;
            Xa = x;
        }
    }
    internal class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public float Perimetro
        {
            get
            {
                return perimetro;
            }
            set
            {
                perimetro = value;
            }
        }

        internal Punto Vertice1
        {
            get
            {
                return vertice1;
            }
            set
            {
                vertice1 = value;
            }
        }
        internal Punto Vertice2
        {
            get
            {
                return vertice2;
            }
            set
            {
                vertice2 = value;
            }
        }
        internal Punto Vertice3
        {
            get
            {
                return vertice3;
            }
            set
            {
                vertice3 = value;
            }
        }
        internal Punto Vertice4
        {
            get
            {
                return vertice4;
            }
            set
            {
                vertice4 = value;
            }
        }

        public float CalcularArea()
        {
            float area;
            int baseCuadrado;
            int altura;
            int baseUno;
            int baseDos;
            int alturaUno;
            int alturaDos;

            if (Area > 0)
            {
                area = Area;

            }
            else
            {

                baseUno = Vertice1.GetX();
                baseDos = Vertice4.GetX();
                alturaUno = Vertice1.GetY();
                alturaDos = Vertice2.GetY();

                baseCuadrado = Math.Abs(baseUno - baseDos);
                altura = Math.Abs(alturaUno - alturaDos);

                area = baseCuadrado * altura;
                Area = area;
            }
            return area;
        }

        public float CalcularPerimetro()
        {
            float perimetro;
            int baseCuadrado;
            int altura;
            int baseUno;
            int baseDos;
            int alturaUno;
            int alturaDos;

            if (Perimetro > 0)
            {
                perimetro = Perimetro;

            }
            else
            {
                baseUno = Vertice1.GetX();
                baseDos = Vertice4.GetX();
                alturaUno = Vertice1.GetY();
                alturaDos = Vertice2.GetY();

                baseCuadrado = Math.Abs(baseUno - baseDos);
                altura = Math.Abs(alturaUno - alturaDos);

                perimetro = (baseCuadrado + altura) * 2;
                Perimetro = perimetro;
            }
            return perimetro;
        }

        public void CrearRectangulo(Punto vertice1, Punto vertice3)
        {
            int vertice1X;
            int vertice1Y;
            int vertice3X;
            int vertice3Y;
            Punto vertice2;
            Punto vertice4;

            Vertice1 = vertice1;
            Vertice3 = vertice3;

            vertice1X = Vertice1.GetX();
            vertice1Y = Vertice1.GetY();
            vertice3X = Vertice3.GetX();
            vertice3Y = Vertice3.GetY();

            vertice2 = new Punto();
            vertice4 = new Punto();

            vertice2.CrearPunto(vertice1X, vertice3Y);
            vertice4.CrearPunto(vertice3X, vertice1Y);

            Vertice2 = vertice2;
            Vertice4 = vertice4;


        }
    }
}