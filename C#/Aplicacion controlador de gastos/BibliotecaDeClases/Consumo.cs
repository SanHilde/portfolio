using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [FirestoreData]
    //[Serializable]
    //[XmlInclude(typeof(ConsumoFijo))]
    //[XmlInclude(typeof(ConsumoVolatil))]
    public class Consumo : IConsumible
    {

        string nombre;
        double monto;   
        string categoria;
        DateTime fecha;
        bool pagoRealizado;
        int id;

        public Consumo ()
        {

        }
        public Consumo(double monto, string nombre, string categoria, DateTime fecha, bool pagoRealizado, int id)
        {
            this.nombre = nombre;
            this.monto = monto;
            this.categoria = categoria;
            this.fecha = fecha.ToUniversalTime() ;
            this.pagoRealizado = pagoRealizado;
            this.id = id;
        }
        [FirestoreProperty]
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        [FirestoreProperty]
        public double Monto
        {
            get
            {
                return this.monto;
            }
            set
            {
                this.monto = value;
            }
        }
        [FirestoreProperty]
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        [FirestoreProperty]
        public string Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }
        [FirestoreProperty]
        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }
        [FirestoreProperty]
        public virtual bool PagoRealizado
        {
            get
            {
                return this.pagoRealizado;
            }set
            {
                this.pagoRealizado = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string pagado = "NO";
            if (this.PagoRealizado == true)
            {
                pagado = "SI";
            }
            sb.AppendLine($"Gasto: {this.Nombre}");
            sb.AppendLine($"Monto: ${this.Monto}");
            sb.AppendLine($"Categoria: {this.Categoria}");
            sb.AppendLine($"Fecha: {this.Fecha.Day}/{this.Fecha.Month}/{this.Fecha.Year}");
            sb.AppendLine($"Pagado:{pagado}");
            return sb.ToString();
        }
       /* public virtual void SetPago(bool pago)
        {
            this.pagoRealizado = pago;
        }
        public virtual void SetCategoria(string categoriaNueva)
        {
            this.categoria = categoriaNueva;
        }
        public void SetId(int id)
        {
            this.id = id;
        }*/
        public static bool operator ==(string categoria, Consumo consumoDos)
        {
            bool resultado = false;
            if (categoria == consumoDos.Categoria)
            {
                resultado = true;
            }
            return resultado;
        }

        public static bool operator !=(string categoria, Consumo consumoDos)
        {
            return ! (categoria == consumoDos);
        }
        public static double operator +(Consumo consumoUno, Consumo consumoDos)
        {
            double resultado = 0;
            if (consumoUno != null && consumoDos != null)
            {
                resultado = consumoUno.Monto + consumoDos.Monto;
            }     
            return resultado;
        }
    }
}
