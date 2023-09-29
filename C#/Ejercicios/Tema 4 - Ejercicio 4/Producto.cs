using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4___Ejercicio_4
{
    public class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;
        
        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }
        public string GetMarca ()
        {
            return this.marca;
        }
        public float GetPrecio ()
        {
            return this.precio;
        }
        public static string MostrarProducto (Producto p)
        {
            return $"Marca: {p.marca}, precio: {p.precio}, codigo de barra: {p.codigoDeBarra}";
        }
        public Producto (string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigo;
        }
        public static bool operator == (Producto p1, Producto p2)
        {
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator == (Producto p1, string s)
        {
            if (p1.marca == s)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool operator !=(Producto p1, string s)
        {
            return !(p1 == s);
        }

    }
}
