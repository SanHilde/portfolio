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
    public sealed class ConsumoFijo:Consumo
    {
        int cantCuotas;
        public ConsumoFijo () : base ()
        {

        }
        public ConsumoFijo(double montoIngresado, string nombre, string categoriaIngresada, DateTime fechaIngresada, int cantCuotasIngresadas, bool pago,int id) : base (montoIngresado,nombre, categoriaIngresada, fechaIngresada, pago, id)
        {
            this.cantCuotas = cantCuotasIngresadas;
        }

        public ConsumoFijo (int cantCuotas, Consumo consumo) : base (consumo.Monto, consumo.Nombre, consumo.Categoria, consumo.Fecha, consumo.PagoRealizado, consumo.Id)
        {
            this.cantCuotas = cantCuotas;
        }
        [FirestoreProperty]
        public int CantCuotas 
        { 
            get
            {
                return this.cantCuotas;
            }
            set
            {
                this.cantCuotas = value;
            }
         }

        public void RestarCuota()
        {
            this.cantCuotas = this.cantCuotas -1;
        }

        /*public override void SetPago (bool pago)
        {
            base.SetPago(pago);
        }*/

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            if (base.PagoRealizado == true)
            {
                sb.AppendLine($"Cant de cuotas por pagar: {this.CantCuotas-1}");
            } else
            {
                sb.AppendLine($"Cant de cuotas por pagar: {this.CantCuotas }");
            }
                return sb.ToString();
        }
    }
}
