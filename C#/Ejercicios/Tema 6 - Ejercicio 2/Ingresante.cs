using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_6___Ejercicio_2
{
    public class Ingresante
    {
        string[] cursos;
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public Ingresante (string nombre, string direccion, string genero,string pais, string[] cursos,int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }
        public string Mostrar ()
        {
            StringBuilder sb = new StringBuilder ();

            sb.Append($"Nombre: {this.nombre}\n");
            sb.Append($"Dirección: {this.direccion}\n");
            sb.Append($"Edad: {this.edad}\n");
            sb.Append($"Género: {this.genero}\n");
            sb.Append($"País: {this.pais}\n");
            sb.Append($"Cursos:\n");
            for (int i=0; i<this.cursos.Length;i++) 
            {
                sb.Append($"{this.cursos[i]}\n");
            }
            
            return sb.ToString ();

        }
    }
}
