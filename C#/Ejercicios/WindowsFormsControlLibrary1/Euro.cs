using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaMoneda
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
        public static void SetCotizacion(double cotizacion)
        {
            cotzRespectoDolar = cotizacion;
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
            return this.cantidad;
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
            cotizacion = Euro.GetCotizacion();
            resultado = e.cantidad * cotizacion;
            conversion = (Dolar)(resultado);

            return conversion;
        }

        public static explicit operator Pesos(Euro e)
        {
            //double cotizacion;
            //double resultado;
            Pesos conversion;
            Dolar conversion2;
            conversion2 = (Dolar)(e);
            conversion = (Pesos)(conversion2);

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
            //double resultado;
            //double cotizacion;
            double transformacion;
            bool retorno;

            transformacion = ((Dolar)e).GetCantidad();
            if (transformacion == d.GetCantidad())
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
           // double resultado;
           // double cotizacion;
            double transformacion;
            bool retorno;

            transformacion = ((Euro)p).GetCantidad();
            if (transformacion == e.GetCantidad())
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !!(e == p);
        }
    }
}
