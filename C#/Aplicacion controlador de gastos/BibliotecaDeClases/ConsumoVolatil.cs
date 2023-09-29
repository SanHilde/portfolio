using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Entidades
{
    [FirestoreData]

    public sealed class ConsumoVolatil : Consumo
    {
        bool vigencia;
        [FirestoreProperty]
        public bool Vigencia 
        {
            get
            {
                return this.vigencia;
            }

            set
            {
                vigencia = value;
            }
        }
        public ConsumoVolatil() : base()
        {

        }
        public ConsumoVolatil(double montoIngresado, string nombreIngresado, string categoriaIngresada, DateTime fechaIngresada, bool vigencia, bool pago, int id) : base(montoIngresado, nombreIngresado, categoriaIngresada, fechaIngresada, pago, id)
        {
            this.Vigencia = vigencia;
        }


        public void CambiarPropiedad(bool estado)
        {
            this.Vigencia = estado;
        }

        public override string ToString()
        {
            string respuesta = "NO";
            if (this.Vigencia == true)
            {
                respuesta = "SI";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Este consumo se va a pagar este mes: {respuesta}");
            return sb.ToString();
        }
        public ConsumoVolatil(Consumo consumo) : base(consumo.Monto, consumo.Nombre, consumo.Categoria, consumo.Fecha, consumo.PagoRealizado, consumo.Id)
        {
            this.Vigencia = true;
        }
    }
}
