using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_8___Ejercicio_1
{
    public abstract class Sobreescrito
    {
        private string miAtributo;

        public string MiAtributo
        {
            get
            {
                return this.miAtributo;
            }
        }
        public abstract string miPropiedad {get;}

        public abstract string MiMetodo();

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public override string ToString()
        {
            return "Este es mi metodo ToString sobreescrito!";
        }
        
        public override bool Equals(object? obj)
        {
            bool respuesta;
            if (obj == this)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }
        public override int GetHashCode() 
        {
            return 1142510181;
        }

    }
}
