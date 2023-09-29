using System.Text;

namespace Tema_3___Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    internal class Duenio
    {
        string domicilio;
        string nombre;
        int telefono;
        List<Mascota> Mascotas { get; } = new List<Mascota>();

        public void AgregarMascota(Mascota mascota)
        {
            Mascotas.Add(mascota);
        }



        public string Domicilio 
        { 
            get
            {
                return this.domicilio;
            }
            set
            {
                this.domicilio = value;
            }
        }
        public string Nombre
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

        public int Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        internal Mascota Mascota
        {
            get
            {
                return this.mascota;
            }
            set
            {
                this.mascota = value;
            }
        }

    }
    internal class Mascota
    {
        string especie;
        string nombre;
        DateTime fechaDeNacimiento;
        string historialVacunacion;

        public string Especie
        {
            get
            {
                return this.especie;
            }
            set
            {
                this.especie = value;
            }
        }

        public string Nombre
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

        public DateTime FechaDeNacimiento
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

        public string HistorialVacunacion
        {
            get
            {
                return this.historialVacunacion;
            }
            set
            {
                this.historialVacunacion = value;
            }
        }
    }
}