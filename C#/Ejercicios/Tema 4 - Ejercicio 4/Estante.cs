using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4___Ejercicio_4
{
    public class Estante
    {
        Producto[] productos;
        int ubiacionEstante;

        Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubiacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Estante: {estante.ubiacionEstante}, productos:\n ");
            for (int i = 0; i < estante.productos.Length; i++)
            {
                //if ((estante.productos[i]) != null)
                //{
                    sb.Append("\n");
                    sb.Append(Producto.MostrarProducto(estante.productos[i]));
                //}
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto productoDeFor in e.GetProductos())
            {
                if (productoDeFor == p)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        /*
        public static Estante operator -(Estante e, Producto p)
        {
            int indexEnNombreABorrar;
            for (int i = 0; i < e.productos.Length; i++)
                if (e == p)
                {
                    //indexEnNombreABorrar = (e.GetProductos()).IndexOf(e.GetProductos(), p);
                    //e.productos = e.GetProductos().Where((j, i) => i != indexEnNombreABorrar).ToArray();
                    //e.productos. ()
                    //e.productos.
                    newArray = new Estante[miArray.Length - 1];

                    // Copiar los elementos antes del elemento que deseas eliminar
                    Array.Copy(miArray, 0, newArray, 0, index);

                    // Copiar los elementos después del elemento que deseas eliminar
                    Array.Copy(miArray, index + 1, newArray, index, miArray.Length - index - 1);
                }
        }
        */
        public static bool operator +(Estante e, Producto p)
        {
            Console.WriteLine(e.productos.GetEnumerator());
            //if (e.productos.Count >= e.productos.Length)
            for (int i=0; i < e.productos.Length; i++)   
            {
                if (e.productos[i] == null)
                {
                    e.productos[i] = p;
                    return true;
                }
                //e.productos.Add(p);
            }
            return false;
        }
    }
}
