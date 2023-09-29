using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_7___Ejercicio_2
{
    public class Persona
    {
        long dni;
        string nombre;


        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(long dni, string nombre): this (nombre)
        {
            this.dni = dni;
        }

        public long Dni
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
        
        public string MostrarDatosPersona ()
        {
            StringBuilder sb = new StringBuilder ();
            sb.Append ($"Nombre de la persona: {this .nombre}, DNI: {this.dni}.\n");
            return sb.ToString ();
        }
    }
}
