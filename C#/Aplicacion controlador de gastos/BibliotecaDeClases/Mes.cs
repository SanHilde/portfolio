using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Entidades
{
    [FirestoreData]
    public class Mes
    {
        double sueldoCobrado;
        int inicioDeCiclo;
        DateTime fechaDeInicio;
        DateTime finDeCiclo;
        int ahorroPropuesto;
        bool objetivoCumplido;
        List<ConsumoFijo> listaConsumosFijos;
        List<ConsumoVolatil> listaConsumosVolatiles;
        List<Consumo> listaConsumosEsporadicos;
        int id;

        
        public Mes()
        {
            this.objetivoCumplido = true;
            this.listaConsumosFijos = new List<ConsumoFijo>();
            this.listaConsumosVolatiles = new List<ConsumoVolatil>();
            this.listaConsumosEsporadicos = new List<Consumo>();
        }

        public Mes(double sueldoCobrado, int inicioDeCiclo, DateTime fechaDeInicio, int ahorroPropuesto, int idExterno) : this()
        {
            this.sueldoCobrado = sueldoCobrado;
            this.inicioDeCiclo = inicioDeCiclo;
            this.fechaDeInicio = fechaDeInicio.ToUniversalTime();
            this.ahorroPropuesto = ahorroPropuesto;
            this.id = idExterno;
            this.finDeCiclo = new DateTime (fechaDeInicio.Year, fechaDeInicio.Month, inicioDeCiclo).AddMonths(1).ToUniversalTime();
        }
        [FirestoreProperty]
        public List<ConsumoFijo> ListaConsumosFijos
        {
            get
            {
                return this.listaConsumosFijos;
            }
            set
            {
                this.listaConsumosFijos = value;
            }
        }
        [FirestoreProperty]
        public List<ConsumoVolatil> ListaConsumosVolatiles
        {
            get
            {
                return this.listaConsumosVolatiles;
            }
            set
            {
                this.listaConsumosVolatiles = value;
            }
        }
        [FirestoreProperty]
        public List<Consumo> ListaConsumosEsporadicos
        {
            get
            {
                return this.listaConsumosEsporadicos;
            }
            set
            {
                this.listaConsumosEsporadicos = value;
            }
        }
        [FirestoreProperty]
        public double SueldoCobrado
        {
            get
            {
                return this.sueldoCobrado;
            }
            set
            {
                this.sueldoCobrado = value;
            }
        }
        [FirestoreProperty]
        public int InicioDeCiclo
        {
            get
            {
                return this.inicioDeCiclo;
            }
            set
            {
                this.inicioDeCiclo = value;
            }
        }
        [FirestoreProperty]
        public DateTime FechaDeInicio
        {
            get
            {
                return this.fechaDeInicio;
            }
            set
            {
                this.fechaDeInicio = value;
            }
        }
        [FirestoreProperty]
        public DateTime FinDeCliclo
        {
            get
            {
                return this.finDeCiclo;
            }
            set
            {
                this.finDeCiclo = value;
            }
        }
        [FirestoreProperty]
        public int AhorroPropuesto
        {
            get
            {
                return this.ahorroPropuesto;
            }
            set
            {
                this.ahorroPropuesto = value;
            }
        }
        [FirestoreProperty]
        public bool ObjtivoCumplido
        {
            get
            {
                return this.objetivoCumplido;
            }
            set
            {
                this.objetivoCumplido = value;
            }
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

        /*public void AgregarConsumo(Consumo consumo)
        {
            int id;
            id = listaConsumosVolatiles.Count + 1;
            consumo.Id = id;
            listaConsumosEsporadicos.Add(consumo);
        }
        public void AgregarConsumo(ConsumoFijo consumo)
        {
            int id;
            id = listaConsumosVolatiles.Count + 1;
            consumo.Id = id;
            listaConsumosFijos.Add(consumo);
        }
        public void AgregarConsumo(ConsumoVolatil consumo)
        {
            int id;
            id = listaConsumosVolatiles.Count + 1;
            consumo.Id = id;
            listaConsumosVolatiles.Add(consumo);

        }*/
        public void Agregar<T>(T objeto, List<T> lista) where T : IConsumible
        {
            int id;
            id = lista.Count + 1;
            objeto.Id = id;
            lista.Add(objeto);
        }
       /* public void Modificar<T>(T objetoEditado, T objetoAEditar, List<T> lista) where T : IConsumible
        {
            foreach (T objeto in lista)
            {
                if (objeto.Id == objetoAEditar.Id)
                {
                    objeto.Id = objetoEditado.Id;
                    objeto.PagoRealizado = objetoEditado.PagoRealizado;
                    objeto.Nombre = objetoEditado.Nombre;
                    objeto.Monto = objetoEditado.Monto;
                    objeto.Categoria = objetoEditado.Categoria;
                    objeto.Fecha = objetoEditado.Fecha;

                    if (objeto is ConsumoFijo && objetoEditado is ConsumoFijo)
                    {
                        ConsumoFijo objetoEnFijo = (ConsumoFijo)(object)objeto;
                        ConsumoFijo objetoEditadoEnFijo = (ConsumoFijo)(object)objetoEditado;
                        objetoEnFijo.CantCuotas = objetoEditadoEnFijo.CantCuotas;
                    }
                    if (objeto is ConsumoVolatil && objetoEditado is ConsumoVolatil)
                    {
                        ConsumoVolatil objetoEnVolatil = (ConsumoVolatil)(object)objeto;
                        ConsumoVolatil objetoEditadoEnVolatil = (ConsumoVolatil)(object)objetoEditado;
                        objetoEnVolatil.Vigencia = objetoEditadoEnVolatil.Vigencia;
                    }
                    MessageBox.Show(objeto.ToString());
                }
            }
        }*/
            public void Modificar<T,V>(T objetoAEditar, V objetoEditado, List<T> lista) where T : IConsumible where V : IConsumible
            {
                objetoAEditar.PagoRealizado = objetoEditado.PagoRealizado;
                objetoAEditar.Nombre = objetoEditado.Nombre;
                objetoAEditar.Monto = objetoEditado.Monto;
                objetoAEditar.Categoria = objetoEditado.Categoria;
                objetoAEditar.Fecha = objetoEditado.Fecha;

                if (objetoAEditar is ConsumoFijo && objetoEditado is ConsumoFijo)
                {
                    ConsumoFijo objetoEnFijo = (ConsumoFijo)(object)objetoAEditar;
                    ConsumoFijo objetoEditadoEnFijo = (ConsumoFijo)(object)objetoEditado;
                    objetoEnFijo.CantCuotas = objetoEditadoEnFijo.CantCuotas;
                }
                if (objetoAEditar is ConsumoVolatil && objetoEditado is ConsumoVolatil)
                {
                    ConsumoVolatil objetoEnVolatil = (ConsumoVolatil)(object)objetoAEditar;
                    ConsumoVolatil objetoEditadoEnVolatil = (ConsumoVolatil)(object)objetoEditado;
                    objetoEnVolatil.Vigencia = objetoEditadoEnVolatil.Vigencia;
                }


                MessageBox.Show("Gasto editado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        public void Eliminar<T>(T objeto, List<T> lista) where T : IConsumible
        {
            lista.Remove(objeto);
            MessageBox.Show("Gasto eliminado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void AgregarConsumo(double monto, string nombre, string categoria, DateTime fecha, bool pagoRealizado)
        {
            int id;
            id = listaConsumosEsporadicos.Count + 1;
            Consumo consumo = new Consumo(monto, nombre, categoria, fecha, pagoRealizado, id);
            listaConsumosEsporadicos.Add(consumo);
        }
        public void AgregarConsumo(double monto, string nombre, string categoria, DateTime fecha, bool pagoRealizado, int cuotas)
        {
            int id;
            id = listaConsumosFijos.Count + 1;
            ConsumoFijo consumo = new ConsumoFijo(monto, nombre, categoria, fecha, cuotas, pagoRealizado, id);
            listaConsumosFijos.Add(consumo);
        }
        public void AgregarConsumo(double monto, string nombre, string categoria, DateTime fecha, bool pagoRealizado, bool vigencia)
        {
            int id;
            id = listaConsumosVolatiles.Count + 1;
            ConsumoVolatil consumo = new ConsumoVolatil(monto, nombre, categoria, fecha, vigencia, pagoRealizado, id);
            listaConsumosVolatiles.Add(consumo);

        }
        /*public string ListaDeGastos(List<Consumo> lista)
        {
            StringBuilder sb = new StringBuilder();    

            foreach (var consumo in lista)
            {
                sb.AppendLine(consumo.ToString());
            }

            return sb.ToString();
        }
        
        public string ListaDeGastos(List<ConsumoFijo> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var consumo in lista)
            {
                sb.AppendLine(consumo.ToString());
            }

            return sb.ToString();
        }
        public string ListaDeGastos(List<ConsumoVolatil> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var consumo in lista)
            {
                sb.AppendLine(consumo.ToString());
            }

            return sb.ToString();
        }*/
    }
}
