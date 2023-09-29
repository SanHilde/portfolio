using System;
using System.Text;

namespace Tema_3___Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteUno;
            Estudiante estudianteDos;
            Estudiante estudianteTres;

            estudianteUno = new Estudiante("Santiago", "Hildebrandt", "3342");
            estudianteUno.SetNotaPrimerParcial(10);
            estudianteUno.SetNotaSegundoParcial(8);
            Console.WriteLine(estudianteUno.Mostrar());

            estudianteDos = new Estudiante("Malen", "Cirulli", "2938");
            estudianteDos.SetNotaPrimerParcial(4);
            estudianteDos.SetNotaSegundoParcial(4);
            Console.WriteLine(estudianteDos.Mostrar());

            estudianteTres = new Estudiante("Martin", "Linsalatta", "3558");
            estudianteTres.SetNotaPrimerParcial(10);
            estudianteTres.SetNotaSegundoParcial(2);
            Console.WriteLine(estudianteTres.Mostrar());

        }
    }
    internal class Estudiante
    {
        string apellido;
        string legajo;
        string nombre;
        int notaPrimerParcial;
        int notaSegundoParcial;
        Random random = new Random();

        string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        string Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }
        string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        int NotaPrimerParcial
        {
            get
            {
                return this.notaPrimerParcial;
            }
            set
            {
                this.notaPrimerParcial = value;
            }
        }
        int NotaSegundoParcial
        {
            get
            {
                return this.notaSegundoParcial;
            }
            set
            {
                this.notaSegundoParcial = value;
            }
        }
      /*  Random Random
        {
            get
            {
                return this.random;
            }
            set
            {
                this.random = value;
            }
        }*/

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Legajo = legajo;
        }
        //private Estudiante ()
        //  {

        // }
        public double CalcularNotaFinal()
        {
            double resultado;
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                resultado = random.Next(6, 10);
                //resultado = this.Random;
                //this.Random = resultado;
            }
            else
            {
                resultado = -1;
            }
            return resultado;
        }

        private float CalcularPromedio()
        {
            float resultado;
            resultado = (this.NotaPrimerParcial + this.NotaSegundoParcial) / 2;
            return resultado;
        }

        public string Mostrar()
        {
            StringBuilder resultado = new StringBuilder();
            string primerOracion;
            string segundaOracion;
            string tercerOracion;
            string cuartaOracion;

            primerOracion = $"{this.Nombre} {this.Apellido}, legajo {this.Legajo}: \n";
            resultado.Append(primerOracion);
            segundaOracion = $"Nota primer parcial: {this.NotaPrimerParcial}, nota segundo parcial: {this.notaSegundoParcial}.\n";
            resultado.Append(segundaOracion);
            tercerOracion = $"Promedio: {this.CalcularPromedio()}.\n";
            resultado.Append(tercerOracion);
            if (this.CalcularNotaFinal() != -1)
            {
                cuartaOracion = $"Nota final: {this.CalcularNotaFinal()}\n";
            } else
            {
                cuartaOracion = "Alumno desaprobado\n";
            }
            resultado.Append(cuartaOracion);
            return resultado.ToString ();
        }

        public void SetNotaPrimerParcial(int nota)
            {
                this.NotaPrimerParcial = nota;
            }

            public void SetNotaSegundoParcial(int nota)
            {
                this.NotaSegundoParcial = nota;
            }
        }
    }