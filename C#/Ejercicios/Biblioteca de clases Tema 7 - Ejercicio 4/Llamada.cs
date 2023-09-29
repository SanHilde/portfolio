using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    internal class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion 
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public string Mostrar ()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($" Numero de orginal : {this.nroOrigen}, numero de destino: {this.nroDestino}, duracion de la llamada: {this.duracion}");
            return sb.ToString();
        }
        public int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            int resultado;
            if (llamada1.Duracion > llamada2.Duracion) 
            {
                resultado = 1;
            } else
            {
                resultado = 0;
            }
            return resultado;
        }
    }
}
