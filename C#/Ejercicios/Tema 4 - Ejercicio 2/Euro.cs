using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4___Ejercicio_2
{
    public class Euro
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.17;
            //cotzRespectoDolar = 2;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;

        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
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
        public static explicit operator Dolar(Euro e)
        {
            double cotizacion;
            double resultado;
            Dolar conversion;
            cotizacion = GetCotizacion();
            resultado = e.cantidad * cotizacion;
            conversion = (Dolar)resultado;

            return conversion;
        }

        public static explicit operator Pesos(Euro e)
        {
            double cotizacion;
            double resultado;
            Pesos conversion;
            Dolar conversion2;
            conversion2 = (Dolar)e;
            conversion = (Pesos)conversion2;

            return conversion;
        }

        public static implicit operator Euro(double e)
        {

            Euro conversion;
            conversion = new Euro(e);

            return conversion;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro transformacion;
            transformacion = (Euro)p;
            return (Euro)(e.GetCantidad() - transformacion.GetCantidad());
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro transformacion;
            transformacion = (Euro)d;
            return (Euro)(e.GetCantidad() - transformacion.GetCantidad());
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            Euro transformacion;
            transformacion = (Euro)p;
            return (Euro)(e.GetCantidad() + transformacion.GetCantidad());

        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro transformacion;
            transformacion = (Euro)d;
            return (Euro)(e.GetCantidad() + transformacion.GetCantidad());
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            double resultado;
            double cotizacion;
            double transformacion;

            transformacion = ((Dolar)e).GetCantidad();
            if (transformacion == d.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            double resultado;
            double cotizacion;
            double transformacion;

            transformacion = ((Euro)p).GetCantidad();
            if (transformacion == e.GetCantidad())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !!(e == p);
        }
    }
}

