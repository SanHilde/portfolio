using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5___Ejercicio_5
{
    public class AutoF1
    {
        string escuderia;
        short numero;
        short vueltasRestantes;
        short cantidadCombustible;
        bool enCompetencia;

        public AutoF1(short numero, string escuderia)
        {
            this.escuderia = escuderia;
            this.numero = numero;  
            this.vueltasRestantes = 0;
            this.cantidadCombustible= 0;
            this.enCompetencia = false;
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
        }
        public short VueltasRestantes 
        { 
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }


        public string MostrarDatos ()
        {
            StringBuilder sb = new StringBuilder ();
            string datos;
            string datoAgregado;
            datos = $"El auto de escuderia {this.escuderia}, con el numero {this.numero}: " ;
            sb.Append(datos);
            if (this.EnCompetencia)
            {
                datoAgregado = $"le quedan {this.vueltasRestantes} vueltas y {cantidadCombustible} de combustible";
            }
            else 
            {
                datoAgregado = "no esta compitiendo";
            }
            sb.Append(datoAgregado);
            return sb.ToString();
        }
        public static bool operator == (AutoF1 a1, AutoF1 a2)
        {
            if (a1.escuderia ==  a2.escuderia && a1.numero == a2.numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
