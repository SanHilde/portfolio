using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static Interfaz.FormMenuPrincipal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = System.Drawing.Color;

namespace Interfaz
{
    public partial class FormNuevoConsumo:FormHeredable
    {
        Consumo nuevoConsumo;
        string tipoDeGasto;
        int cantCuotas;
        bool vigencia;
        static bool formEditar;
        static int idAEditar;
        static string gastoViejo;
        //static string eleccion;
       // List<string> listaDeCategorias;
        static FormMenuPrincipal formPadre;

        public Consumo NuevoGasto
        {
            get
            {
                return this.nuevoConsumo;
            }
        }

        public string TipoDeGasto
        {
            get
            {
                return this.tipoDeGasto;
            }
        }

        public int CantCuotas
        {
            get
            {
                return this.cantCuotas;
            }
        }
        public bool Vigencia
        {
            get
            {
                return this.vigencia;
            }
        }

        /*public List<string> ListaDeCategorias
        {
            get
            {
                return this.listaDeCategorias;
            }
        }*/
        public int IdAEditar
        {
            get
            {
                return idAEditar;
            }
        }
        public string GastoViejo
        {
            get
            {
                return gastoViejo;
            }
        }

        public FormNuevoConsumo () : base ()
        {
            InitializeComponent();
        }

        /*public event EventHandler GuardarClicked;

        public virtual void OnGuardarClicked(EventArgs e)
        {
            GuardarClicked?.Invoke(this, e);
        }*/

        //public FormNuevoConsumo(List<string> categoriasTraidas, FormMenuPrincipal formPadreTraido) : base(140)
        public FormNuevoConsumo(FormMenuPrincipal formPadreTraido) : base(140)
        {
            InitializeComponent();
            //if (this.ListaDeCategorias == null)
            //{
              //  MessageBox.Show("entre");
                //this.listaDeCategorias = categoriasTraidas;
            //}
            //this.listaDeCategorias = RecibirDatos();
            formPadre = formPadreTraido;
            formEditar = false;
            idAEditar = 0;
            cbo_Descripcion.Visible = false;
        }

        public void SetearFormParaEditar ()
        {
            txt_Descripcion.Visible = false;
            cbo_Descripcion.Visible = true;
            formEditar = true;
            this.EditarBotones("Guardar", "Eliminar", "Salir");
            //cbo_TipoConsumo.SelectedIndex = 0;
            CargarDescripcion();
            CargarValores();

            //Grafica.S
        }
        private void CargarDescripcion()
        {           
            switch (cbo_TipoConsumo.SelectedIndex)
            {
                //case 0://fijo
                default:
                    cbo_Descripcion.Items.Clear();
                    Generics.RecorrerListaConFiltroString(MesActual.ListaConsumosFijos, Generics.FiltroCategoria, AgregarACboBox, cbo_Categorias.Text);
                    break;
                case 1://volatil
                    cbo_Descripcion.Items.Clear();
                    Generics.RecorrerListaConFiltroString(MesActual.ListaConsumosVolatiles, Generics.FiltroCategoria, AgregarACboBox, cbo_Categorias.Text);
                    break;
                case 2://esporadico
                    cbo_Descripcion.Items.Clear();
                    Generics.RecorrerListaConFiltroString(MesActual.ListaConsumosEsporadicos, Generics.FiltroCategoria, AgregarACboBox, cbo_Categorias.Text);
                    break;
            }
        }
        private void CargarValores()
        {          
            switch (cbo_TipoConsumo.SelectedIndex)
            {
                //case 0://fijo
                default:
                    Generics.RecorrerListaConFiltroString(MesActual.ListaConsumosFijos, Generics.FiltroNombre, SetearValores, cbo_Descripcion.Text);
                    break;
                case 1://volatil
                    Generics.RecorrerListaConFiltroString(MesActual.ListaConsumosVolatiles, Generics.FiltroNombre, SetearValores, cbo_Descripcion.Text);
                    break;
                case 2://esporadico
                    Generics.RecorrerListaConFiltroString(MesActual.ListaConsumosEsporadicos, Generics.FiltroNombre, SetearValores, cbo_Descripcion.Text);
                    break;
            }
            gastoViejo = cbo_TipoConsumo.Text;
        }
        private void AgregarACboBox<T>(T consumo) where T : IConsumible
        {
            cbo_Descripcion.Items.Add($"{consumo.Id}-{consumo.Nombre}");
        }
        private void SetearValores<T>(T consumo) where T : IConsumible
        {
            txt_Monto.Clear();
            txt_Monto.Text = consumo.Monto.ToString();
            dte_Fecha.Value = consumo.Fecha;
            if (consumo.PagoRealizado)
            {
                rad_Pagado.Checked = true;
            } else
            {
                rad_NoPagado.Checked = true;
            }
            if (consumo is ConsumoFijo)
            {
                ConsumoFijo consumoFijo = (ConsumoFijo)(object)consumo;
                txt_Cuotas.Text = consumoFijo.CantCuotas.ToString();
            }
            idAEditar = consumo.Id;
        }
        private void FormNuevoGasto_Load(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            var tiposDeConsumo = Enum.GetValues(typeof(Usuario.TiposDeGastos)).Cast<Usuario.TiposDeGastos>().ToList();
            cbo_TipoConsumo.DataSource = tiposDeConsumo;
            lbl_Nota.Text = "Nota: la cuota fija sera aquella que no varie \nmes a mes, mientras que la cuota volatil será \naquella que hay que pagar siempre pero que, \nsegun el mes, va cambiando el valor.";
            if (formEditar)
            {
                lbl_Nota.Text = lbl_Nota.Text + "\nPara actualizar/ver otros consumos, cambiar\n de categoria";
            }
            if (cbo_Categorias.Items.Count == 0)
            {
                foreach (string categoria in ListaDeCategorias)
                {
                    cbo_Categorias.Items.Add(categoria);
                }
            }
            Grafica.UbicacionDeForm(this, formPadre);
            
        }

        public override void btn_GuardarYContinuar_Click(object sender, EventArgs e)
        {
            CrearGasto();
            if (this.nuevoConsumo != null)
            {              
                base.btn_GuardarYContinuar_Click(sender, e);
            }
        }

        public override void btn_GuardarYSalir_Click(object sender, EventArgs e)
        {
            CrearGasto();
            if (this.nuevoConsumo != null)
            {
                base.btn_GuardarYSalir_Click(sender, e);
            }           
        }

    public override void btn_Salir_Click(object sender, EventArgs e)
        {
            base.btn_Salir_Click (sender, e);
        }

        private void CrearGasto()
        {
            double monto;
            bool pago;
            string error = null;
            string categoria;
            string descripcion=null;
            string cadena;
            TextInfo palabra = new CultureInfo("es-ES", false).TextInfo;

            try
            {
                this.nuevoConsumo = null;
                if (rad_NoPagado.Checked)
                {
                    pago = false;
                }
                else
                {
                    pago = true;
                }
                error = "monto";
                monto = double.Parse(txt_Monto.Text);
                error = "categoria";
                categoria = palabra.ToTitleCase(cbo_Categorias.Text.ToLower());
                if (ValidarCategoria(categoria) == false)
                {
                    ListaDeCategorias.Add(categoria);
                    cbo_Categorias.Items.Add(categoria);
                }
                if (cbo_TipoConsumo.Text == Usuario.TiposDeGastos.Fijo.ToString())
                {
                    error = "cuotas";
                    this.cantCuotas = int.Parse(txt_Cuotas.Text);
                }
                if (formEditar)
                {
                    cadena = cbo_Descripcion.Text;
                    int indiceGuion = cbo_Descripcion.Text.IndexOf("-");
                    if (indiceGuion >= 0 && indiceGuion <= 5)
                    { 
                        descripcion = cadena.Substring(indiceGuion + 1);
                    }
                    else
                    {
                        descripcion = cadena;
                    }
                }
                else
                {
                    descripcion = txt_Descripcion.Text;
                }
                this.nuevoConsumo = new Consumo(monto, descripcion, categoria, dte_Fecha.Value, pago, 0);
                this.tipoDeGasto = cbo_TipoConsumo.Text;
                this.vigencia = true;
                
            } catch (FormatException)
            {
                MessageBox.Show($"No ingreso un numero en {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (ArgumentNullException)
            {
                MessageBox.Show($"No ingreso nada en {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    SerializadoraTXT serializadora = new SerializadoraTXT();
                    string textoAEscribir = $"Clase: FormNuevoConsumo\nMetodo: CrearGasto\nError: {ex.Message}\n";
                    Generics.TrabajarArchivo("Errores", "ErrorAlCrearGasto.txt", serializadora.Escribir, textoAEscribir);
                    //Sistema.EscribirArchivo(@"Errores", "ErrorAlCrearGasto.txt", $"Clase: FormNuevoConsumo\n,Metodo: CrearGasto\nError: {ex.Message}");
                } catch (Exception ex2)
                {
                    MessageBox.Show(ex2.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool ValidarCategoria(string categoriaIngresada)
        {
            bool respuesta = false;
            foreach (string categoria in ListaDeCategorias)
            {
                if (categoria == categoriaIngresada)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }

        private void cbo_TipoConsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_TipoConsumo.Text != Usuario.TiposDeGastos.Fijo.ToString())
            {
                txt_Cuotas.Enabled = false;
                txt_Cuotas.BackColor = Sistema.Config.ColorIntermedio;
            } else
            {
                txt_Cuotas.Enabled = true;
                txt_Cuotas.BackColor = Sistema.Config.ColorSeleccionVentana;
            }
            
        }

        private void cbo_Descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarValores();

        }

        private void cbo_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDescripcion();
            CargarValores();
        }

        private void cbo_Descripcion_MouseClick(object sender, MouseEventArgs e)
        {
            CargarDescripcion();
        }
    }
}
