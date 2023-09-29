using System.Text;

namespace Tema_3___Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNacimientoUno;
            DateTime fechaNacimientoDos;
            DateTime fechaNacimientoTres;


            fechaNacimientoUno = new DateTime(1995, 11, 17);
            Persona personaUno = new Persona("Santiago Hildebrandt", fechaNacimientoUno, 39349706);
            fechaNacimientoDos = new DateTime(1994, 8, 22);
            Persona personaDos = new Persona("Malen Cirulli", fechaNacimientoDos, 99999999);
            fechaNacimientoTres = new DateTime(2018, 9, 21);
            Persona personaTres = new Persona("Benjamin Linsalata", fechaNacimientoTres, 111111111);


            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine(personaUno.EsMayorDeEdad());
            Console.WriteLine(personaDos.Mostrar());
            Console.WriteLine(personaDos.EsMayorDeEdad());
            Console.WriteLine(personaTres.Mostrar());
            Console.WriteLine(personaTres.EsMayorDeEdad());
        }
    }
    internal class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        int dni;

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
        DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaDeNacimiento;
            }
            set
            {
                this.fechaDeNacimiento = value;
            }
        }
        int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public Persona(string nombrePersona, DateTime fechaDeNacimientoPersona, int dniPersona)
        {
            this.Nombre = nombrePersona;
            this.FechaDeNacimiento = fechaDeNacimientoPersona;
            this.Dni = dniPersona;
        }

        private double CalcularEdad()
        {
            double resultado;
            DateTime cantAnios;
            TimeSpan resultadoCuenta;
            DateTime fechaHoy = DateTime.Now;
            DateTime fechaNacimientoPersona = this.FechaDeNacimiento;

            resultadoCuenta = fechaHoy - fechaNacimientoPersona;

            resultado = resultadoCuenta.TotalDays / 365.25;

            return Math.Floor(resultado);
        }

       // public string Mostrar(Persona personaAMostrar)
        public string Mostrar( )
        {
            string resultado;
            resultado = $"La persona es {this.Nombre}, su edad es de {this.CalcularEdad()}, su fecha de nacimiento {this.FechaDeNacimiento.ToShortDateString()} y su dni {this.Dni}.";
            //resultado = $"La persona es {personaAMostrar.Nombre}, su edad es de {CalcularEdad(personaAMostrar)}, su fecha de nacimiento {personaAMostrar.FechaDeNacimiento} y su dni {personaAMostrar.Dni}.";
            return resultado;

        }

        public string EsMayorDeEdad()
        {
            string resultado;

            if (this.CalcularEdad() >= 18)
            {
                resultado = "Es mayor de edad";
            } else
            {
                resultado = "Es menor de edad";
            }
            return resultado;
        }
    }

}