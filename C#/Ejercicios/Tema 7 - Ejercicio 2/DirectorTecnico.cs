using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_2
{
    public class DirectorTecnico: Persona
    {
        DateTime fechaNacimiento;

        DirectorTecnico(string nombre) : base (nombre)
        {
                 
        }

        public DirectorTecnico (string nombre, DateTime fechaNacimiento) : this (nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string mostrarDatos ()
        {
            return $"DT: {this.Nombre}, fecha de nacimiento: {this.fechaNacimiento}";
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            if (d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }

    }
}
