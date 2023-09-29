using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAdministrable
    {
        void Agregar<T>(T objeto, List<T> lista) where T : IConsumible;
        void Modificar<T>(T objetoEditado, T objetoAEditar, List<T> lista) where T : IConsumible;
        void Eliminar<T>(T objeto, List<T> lista) where T : IConsumible;
    }
}
