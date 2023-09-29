using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMoneda
{
    public class Dolar
    {
        private double cantidad;
        static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            double cotizacion;
            double resultado;
            Euro conversion;
            cotizacion = Euro.GetCotizacion();
            resultado = d.cantidad / cotizacion;
            conversion = new Euro(resultado);

            return conversion;
        }

        public static explicit operator Pesos(Dolar d)
        {
            double cotizacion;
            double resultado;
            Pesos conversion;
            cotizacion = Pesos.GetCotizacion();
            resultado = d.cantidad * cotizacion;
            conversion = new Pesos(resultado);

            return conversion;
        }
        public static implicit operator Dolar(double d)
        {

            Dolar conversion;
            conversion = new Dolar(d);

            return conversion;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar transformacion;
            transformacion = (Dolar)e;
            return (Dolar)(d.GetCantidad() - transformacion.GetCantidad());
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar transformacion;
            transformacion = (Dolar)p;
            return (Dolar)(d.GetCantidad() - transformacion.GetCantidad());
        }
        public static Dolar operator +(Dolar d, Euro e)
        {

            Dolar transformacion;
            transformacion = (Dolar)e;
            return (Dolar)(d.GetCantidad() + transformacion.GetCantidad());
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar transformacion;
            transformacion = (Dolar)p;
            return (Dolar)(d.GetCantidad() + transformacion.GetCantidad());

        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            //double resultado;
            //double cotizacion;
            double transformacion;
            bool retorno;

            transformacion = ((Dolar)p).GetCantidad();
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
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            //double resultado;
            bool retorno;
            double transformacion;

            transformacion = ((Dolar)e).GetCantidad();
            if (transformacion == d.GetCantidad())
            {
                retorno= true;
            }
            else
            {
                retorno =false;
            }
            return retorno;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            bool retorno;
            if (d1.GetCantidad() == d2.GetCantidad())
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
    }
}
