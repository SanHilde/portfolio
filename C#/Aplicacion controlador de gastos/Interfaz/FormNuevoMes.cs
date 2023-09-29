using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Interfaz
{
    //public partial class FormNuevoMes : FormHeredable
    public sealed partial class FormNuevoMes : FormHeredableDosBotones
    {
        private Mes mesCreado;
        static FormMenuPrincipal formPadre;

        public Mes MesCreado
        {
            get
            {
                return this.mesCreado;
            }
            set
            {
                this.mesCreado = value;
            }

        }

        public FormNuevoMes(FormMenuPrincipal formPadreTraido) : base (70)
        {
            InitializeComponent();
            //if (Sistema.UsuarioLogeado.ListaDeMeses.Count!=0)
            //{
             //   mesCreado = Sistema.UsuarioLogeado.ListaDeMeses.Last();
              
            //}
            formPadre = formPadreTraido;
            
        }

        private void FormNuevoMes_Load(object sender, EventArgs e)
        {
            CargaCheckList();
            Grafica.UbicacionDeForm(this, formPadre);
            if (Sistema.UsuarioLogeado.ListaDeMeses.Count == 0)
            {
                
                this.Width = 1050;
                this.CenterToScreen();
                CrearTexto("Controlador de gastos", new Point(300, 10), 12);
                CrearTexto("Comenzar mes", new Point(300, 170), 12);
                CrearTexto("Nuestra aplicación de control de gastos es una herramienta fácil de usar que te permite" +
                    " llevar un registro detallado de tus \ngastos mensuales. Con esta aplicación, podrás organizar tus consumos en" +
                    " diferentes categorías, como: \n"+
                    "-Fijos, aquellos que no variaran mes a mes y que poseen una cantidad de cuotas.\n"+
                    "-Volatiles, aquellos que deberas pagar todos los meses pero que varian su precio segun el mes (ej: impuestos).\n"+
                    "-Esporadicos, aquellos que son casuales y no es repetitivo mes a mes.\n "+
                    " Te ayudará a comprender mejor tus patrones de gasto y tomar decisiones infornmadas sobre tus finanzas personales." +
                    "\n\n\n\nPodrás elegir el día del ciclo en el que deseas que comience" +
                    " a contar, ingresar el " +
                    "sueldo cobrado en ese mes y establecer tu \nobjetivo de ahorro. Los casilleros vacíos que encuentres " +
                    "representarán los consumos que aún no has registrado pero que \nse esperan que aparezcan en los próximos " +
                    "meses, ya sea como consumos volátiles o fijos, que podras tildarlo si ya estan pagados desde este menu", new Point(300, 40), 10);
                
                PictureBox pictureBox = new PictureBox();
                string imagePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\Imagenes\Login.png"));
                Image image = Image.FromFile(imagePath);
                pictureBox.Image = image;
                pictureBox.Location = new Point(300, 300);
                pictureBox.Size = new Size(735,250);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                this.Controls.Add(pictureBox);
                DesactivarBarra();
                
            }
        }

        public override void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            double sueldo;
            int inicioDeCiclo;
            int objetivoAhorro;
            string error=null;
            DateTime fecha;
            int cantidadDias;
            try
            {
                error = "sueldo";
                //txt_SueldoCobrado = null;
                sueldo = double.Parse(txt_SueldoCobrado.Text);
                error = "objetivo de ahorro";
                objetivoAhorro = NumeroMayorExcepcion.ComprobarNumeroMayorExcepcion(int.Parse(txt_ObjetivoAhorro.Text),100,"Objetivo de ahorro");          
                error = "fecha";
                fecha = dte_Fecha.Value.ToUniversalTime();         
                //this.mesCreado = new Mes(sueldo, inicioDeCiclo, dte_Fecha.Value, objetivoAhorro);
                error = "inicio de ciclo";
                cantidadDias = DateTime.DaysInMonth(dte_Fecha.Value.Year, dte_Fecha.Value.Month);
                foreach (ConsumoFijo consumo in mesCreado.ListaConsumosFijos)
                {
                    if (consumo.PagoRealizado == true)
                    {
                        consumo.RestarCuota();
                    }
                }
                inicioDeCiclo = NumeroMayorExcepcion.ComprobarNumeroMayorExcepcion(int.Parse(txt_InicioDeCiclo.Text), cantidadDias, "Inicio de ciclo");
                Mes nuevoMes = new Mes(sueldo, inicioDeCiclo, dte_Fecha.Value, objetivoAhorro, 0);
                nuevoMes.ListaConsumosFijos = mesCreado.ListaConsumosFijos;
                nuevoMes.ListaConsumosVolatiles = mesCreado.ListaConsumosVolatiles;
                nuevoMes.ListaConsumosEsporadicos = mesCreado.ListaConsumosEsporadicos;
                mesCreado = nuevoMes;
                MessageBox.Show("Mes creado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.btn_Guardar_Click(sender, e);         
            } catch (FormatException)
            {
                MessageBox.Show($"No ingreso un numero en {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (NumeroMayorExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    SerializadoraTXT serializadora = new SerializadoraTXT();
                    string textoAEscribir = $"Clase: FormNuevoMes\nMetodo: btn_Guardar_Click\nError: {ex.Message}\n";
                    Generics.TrabajarArchivo("Errores", "ErrorAlCrearMes.txt", serializadora.Escribir, textoAEscribir);
                    //Sistema.EscribirArchivo(@"Errores", "ErrorAlCrearMes.txt", $"Clase: FormNuevoConsumo\n,Metodo: CrearGasto\nError: {ex.Message}");
                }
                catch (Exception ex2)
                {
                    MessageBox.Show (ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        public override void btn_Cancelar_Click(object sender, EventArgs e)
        {;
            base.btn_Cancelar_Click(sender, e);
        }

        private void CargaCheckList()
        {
            if (mesCreado != null)
            {
                CargarListaFijos();
                CargarListaVolatiles();
                CargarListaEsporadicos();
            }
        }

        private void chkl_ConsumosMensualesFijos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool isChecked = e.NewValue == CheckState.Checked;

            if (isChecked)
            {
                mesCreado.ListaConsumosFijos[e.Index].PagoRealizado = true;
            }
            else
            {
                mesCreado.ListaConsumosFijos[e.Index].PagoRealizado = false;
            }

        }

        private void chkl_ConsumosMensualesVolatil_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bool isChecked = e.NewValue == CheckState.Checked;

            if (isChecked)
            {
                mesCreado.ListaConsumosVolatiles[e.Index].PagoRealizado = true;
            } else
            {
                mesCreado.ListaConsumosVolatiles[e.Index].PagoRealizado = false;
            }
        }
        private void RevertirLista() 
        {
            List<string> listaItems = chkl_ConsumosMensualesFijos.Items.Cast<string>().ToList();

            listaItems.Reverse();

            chkl_ConsumosMensualesFijos.Items.Clear();
            chkl_ConsumosMensualesFijos.Items.AddRange(listaItems.ToArray());
        }
        private void CargarListaFijos()
        {
            string gasto;

            for (int i = mesCreado.ListaConsumosFijos.Count - 1; i >= 0; i--)
            {
                ConsumoFijo consumoFijo = mesCreado.ListaConsumosFijos[i];
                consumoFijo.Fecha = DateTime.Now.ToUniversalTime();
                if (consumoFijo.PagoRealizado == true)
                {
                    consumoFijo.RestarCuota();
                }
                consumoFijo.PagoRealizado = false;
                if (consumoFijo.CantCuotas <= 0)
                {
                    mesCreado.ListaConsumosFijos.RemoveAt(i);//sobrecargar operador
                }
                else
                {
                    gasto = $"${consumoFijo.Monto}, {Grafica.AbreviarTexto(consumoFijo.Nombre, 10)}" ;
                    chkl_ConsumosMensualesFijos.Items.Add(gasto);
                }
            }
            RevertirLista();
        }
        private void CargarListaVolatiles ()
        {
            string gasto;

            foreach (ConsumoVolatil consumoVolatil in mesCreado.ListaConsumosVolatiles)
            {
                consumoVolatil.Fecha = DateTime.Now.ToUniversalTime();
                consumoVolatil.PagoRealizado = false;
                gasto = $"${consumoVolatil.Monto}, {Grafica.AbreviarTexto(consumoVolatil.Nombre, 10)}";
                chkl_ConsumosMensualesVolatil.Items.Add(gasto);
            }
        }
        private void CargarListaEsporadicos()
        {
            string gasto;
            int bandera = 0;
            DialogResult dg=DialogResult.No;
            List<Consumo> listaNueva= new List<Consumo> ();

            foreach (Consumo consumoEsporadico in mesCreado.ListaConsumosEsporadicos)
            {
                if (consumoEsporadico.PagoRealizado == false)
                {
                    if (bandera == 0)
                    {
                        dg = MessageBox.Show("Tienes consumos esporadicos sin pagar del mes pasado ¿Quieres pasarlos a este mes?",
                        "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    }
                    if (dg == DialogResult.Yes) 
                    {
                        bandera = 1;
                        listaNueva.Add(consumoEsporadico);
                    }
                }
            }
            if (bandera ==1)
            {
                mesCreado.ListaConsumosEsporadicos = listaNueva;
            }
        }
        private void CrearTexto(string texto, Point ubicacion, int tamaño)
        {
            Label label = new Label();
            label.Text = texto;
            label.Location = ubicacion;
            label.AutoSize = true;
            label.Font = new Font("Calibri", tamaño, FontStyle.Bold);
            label.ForeColor = Sistema.Config.ColorContraste;
            this.Controls.Add(label);
        }

    }
}
