﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4___Ejercicio_2
{
    public class Pesos
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Pesos()
        {
            cotzRespectoDolar = 102.65;
            //cotzRespectoDolar = 100;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        public static explicit operator Dolar(Pesos p)
        {
            double cotizacion;
            double resultado;
            Dolar conversion;
            cotizacion = GetCotizacion();
            resultado = p.cantidad / cotizacion;
            conversion = (Dolar)resultado; ;

            return conversion;
        }

        public static explicit operator Euro(Pesos p)
        {
            double cotizacion;
            double resultado;
            Euro conversion;
            Dolar conversion2;
            conversion2 = (Dolar)p;
            conversion = (Euro)conversion2;

            return conversion;
        }
        public static implicit operator Pesos(double p)
        {

            Pesos conversion;
            conversion = new Pesos(p);

            return conversion;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos transformacion;
            transformacion = (Pesos)e;
            return (Pesos)(p.GetCantidad() - transformacion.GetCantidad());
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos transformacion;
            transformacion = (Pesos)d;
            return (Pesos)(p.GetCantidad() - transformacion.GetCantidad());
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos transformacion;
            transformacion = (Pesos)e;
            return (Pesos)(p.GetCantidad() + transformacion.GetCantidad());
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos transformacion;
            transformacion = (Pesos)d;
            return (Pesos)(p.GetCantidad() + transformacion.GetCantidad());
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            double resultado;
            double cotizacion;
            double transformacion;

            transformacion = ((Pesos)d).GetCantidad();
            if (transformacion == p.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            double resultado;
            double cotizacion;
            double transformacion;

            transformacion = ((Pesos)e).GetCantidad();
            if (transformacion == p.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !!(p == e);
        }
    }
}
