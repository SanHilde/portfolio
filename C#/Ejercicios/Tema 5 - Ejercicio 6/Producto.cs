using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_5___Ejercicio_6
{
    public class Producto
    {
        int precio;
        string nombre;

        public Producto (string nombre, int precio)
        {
            this.precio = precio;
            this.nombre = nombre;
        }
        public string GetNombre ()
        { 
            return this.nombre;
        }
        public int GetPrecio()
        {
            return this.precio;
        }
    }
}
