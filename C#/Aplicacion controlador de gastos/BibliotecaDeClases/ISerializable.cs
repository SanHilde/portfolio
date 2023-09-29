using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializable
    {
          T Escribir<T>(string ruta, T miMes);
          T Leer<T>(string ruta, T miMes);
    }
}
