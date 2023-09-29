using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_8___Ejercicio_1
{
    public class SobreSobreescrito : Sobreescrito
    {
        public override string miPropiedad
        {
            get
            {
                return base.MiAtributo;
            }
        }

        public override string MiMetodo()
        {
            return this.miPropiedad;
        }
    }
}
