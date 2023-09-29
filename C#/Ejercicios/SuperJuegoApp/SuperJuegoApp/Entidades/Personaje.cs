using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Personaje
    {
        private string nombrePersonaje;
        private ClasePersonaje clase;
        private int nivel;

        public string NombrePersonaje
        {
            get => nombrePersonaje;
            set => nombrePersonaje = value;
        }
        public ClasePersonaje Clase
        {
            get => clase;
            set => clase = value;
        }
        public int Nivel
        {
            get => nivel;
            set => nivel = value;
        }
        public Personaje(string nombrePersonaje, ClasePersonaje clase, int nivel)
        {
            this.nombrePersonaje = nombrePersonaje;
            this.clase = clase;
            this.nivel = nivel;
        }


    }
}
