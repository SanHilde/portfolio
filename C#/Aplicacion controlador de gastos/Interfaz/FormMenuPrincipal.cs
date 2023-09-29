using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LiveCharts.WinForms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing.Text;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts;
//using System.Drawing;
using System.Drawing.Imaging;
//using System.Windows;
using System.Reflection;
//using System.Windows.Controls;


namespace Interfaz
{
    public partial class FormMenuPrincipal : Form
    {
        static Usuario usuarioLogeado;
        static Mes mesActual;
        static List<string> listaDeCategoriasDelUsuario;
        static Dictionary<string, double> diccionarioDeConsumos;
        static double gastosTotales;
        static DateTime diaHoy;
        static int finDeCiclo;
        static bool datosGuardados;
        static Queue<string> listaConsumosNoPagos;

        public static Mes MesActual { get => mesActual; }

        public delegate void DatosEnviadosDelegate(List<string> usuarioLogeado);

        public event EventHandler EventoObjetivoSuperado;
        public event EventHandler EventoSueldoSuperado;
        public event DatosEnviadosDelegate EventoDatosEnviados;

        private void EnviarDatosAlFormSecundario()
        {
            EventoDatosEnviados?.Invoke(listaDeCategoriasDelUsuario);
        }
        protected virtual void OnObjetivoSuperado(EventArgs e)
        {
            EventoObjetivoSuperado?.Invoke(this, e);
        }
        protected virtual void OnSueldoSuperado(EventArgs e)
        {
            EventoSueldoSuperado?.Invoke(this, e);
        }
        private void VerificarObjetivo()
        {
            if (mesActual != null)
            {
                if (mesActual.ObjtivoCumplido == false)
                {
                    if (gastosTotales <= mesActual.SueldoCobrado)
                    {
                        OnObjetivoSuperado(EventArgs.Empty);
                    }
                    else
                    {
                        OnSueldoSuperado(EventArgs.Empty);
                    }
                }
            }
        }
        private void ObjetivoSuperado(object sender, EventArgs e)
        {
            string mensaje = "Superaste el objetivo de ahorro, si queres podes modificar el objetivo";
            DialogResult respuesta;
            respuesta = MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                mnu_EditarObjetivo_Click(sender, e);
            }
            mensaje = "¿Desea desactivar esta notificacion? Sera hasta el cierre de sesion";
            respuesta = MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                this.EventoObjetivoSuperado -= ObjetivoSuperado;
            }
        }
        private void SueldoSuperado(object sender, EventArgs e)
        {
            string mensaje = "Superaste tu sueldo, todo lo que sumes ahora va a ser deuda, si gustas, puedes cambiar el sueldo cobrado";
            DialogResult respuesta;
            respuesta = MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            /*if (respuesta == DialogResult.Yes)
            {
                mnu_EditarSueldo(sender, e);
            }*/
            mensaje = "¿Desea desactivar esta notificacion? Sera hasta el cierre de sesion";
            respuesta = MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (respuesta == DialogResult.Yes)
            {
                this.EventoSueldoSuperado -= SueldoSuperado;
            }          
        }
        public FormMenuPrincipal(Usuario usuarioIngresado)
        {
            diaHoy = DateTime.Now;
            gastosTotales = 0;
            InitializeComponent();
            usuarioLogeado = usuarioIngresado;
            InicializarMes();
            InicializarCategorias();
            InicializarDirectorioConsumos();
            datosGuardados = true;
            listaConsumosNoPagos = new Queue<string>();
            finDeCiclo = 0;
          
            this.EventoObjetivoSuperado += ObjetivoSuperado;
            this.EventoSueldoSuperado += SueldoSuperado;
            VerificarObjetivo();
            //int contador=0;
            //foreach (Mes mes in usuarioIngresado.ListaDeMeses)
            //{
              //  contador++;
                //mes.Id = contador;
            //}
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            int diasMes;
            this.BackgroundImage = Image.FromFile(Sistema.Config.Fondo);
            Grafica.SetearMenuStrip(mnu_MenuPrincipal, this, true);
            if (mesActual != null)
            {
                finDeCiclo = (mesActual.FinDeCliclo - diaHoy).Days;
                if (finDeCiclo < 0)
                {
                    finDeCiclo = 0;
                }
                diasMes = DateTime.DaysInMonth(mesActual.FinDeCliclo.Year, mesActual.FinDeCliclo.Month);
                CalcularGastos();
                Grafica.CrearGrafico(crt_GraficoTorta, diccionarioDeConsumos, "Consumos del mes", mesActual.SueldoCobrado);
                CargarTextos();
                
                //prb_Consumo.BackColor = Color.White;
                if (gastosTotales > mesActual.SueldoCobrado)
                {
                    prb_Consumo.Value = 100;
                } else
                {
                    prb_Consumo.Value = (int)((mesActual.SueldoCobrado - diccionarioDeConsumos["Disponible"]) * 100 / mesActual.SueldoCobrado);
                }
                prb_Mes.Value = (diasMes - finDeCiclo) * 100 / diasMes;
               // prb_Mes.Value = 1;
            }
            while (mesActual == null)
            {
                MessageBox.Show("Bienvenido por primera vez, para empezar, deberá registrar el primer mes", "Bienvendio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mnu_ComenzarMes_Click(sender, e);
            }

        }

        private void mnu_ComenzarMes_Click(object sender, EventArgs e)
        {
            FormNuevoMes formNuevoMes = new FormNuevoMes(this);
            Sistema.SetearConfiguracion(formNuevoMes);
            CambiarColorDeMenu();
            if (MesActual != null)
            {
                formNuevoMes.MesCreado = MesActual;
            }
            
            DialogResult dg = formNuevoMes.ShowDialog();
            if (dg == DialogResult.OK)
            {       
                mesActual = formNuevoMes.MesCreado;
                usuarioLogeado.AgregarMes(mesActual);
                datosGuardados = false;
                Menu_Principal_Load(sender, e);

            }
            CambiarColorDeMenu();

        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = DialogResult.No;
            if (datosGuardados == false)
            {
                dg = MessageBox.Show("¿Desea salir sin guardar??", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.No)
                {
                    guardarCambiosToolStripMenuItem_Click(sender, e);
                }
            } else
            {
                dg = MessageBox.Show("¿Esta seguro que desea salir?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
            }

        }
        private void CargarMenu(object sender, EventArgs e)
        {
            Menu_Principal_Load(sender, e);
        }

        private void mnu_ConsumoNuevo_Click(object sender, EventArgs e)
        {
            Consumo consumoNuevo;
            ConsumoFijo consumoFijo;
            ConsumoVolatil consumoVolatil;
            VerificarObjetivo();           
            FormNuevoConsumo formNuevoGasto = new FormNuevoConsumo(this);
            formNuevoGasto.GuardarClicked += mnu_ConsumoNuevo_Click;
            formNuevoGasto.SuscribirseAlEventoDelFormPrincipal(this);
            EnviarDatosAlFormSecundario();
            Sistema.SetearConfiguracion(formNuevoGasto);
            CambiarColorDeMenu();                
                DialogResult dg = formNuevoGasto.ShowDialog();
                if (dg == DialogResult.OK)
                {
                    MessageBox.Show("Gasto cargado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    consumoNuevo = formNuevoGasto.NuevoGasto;
                    if (formNuevoGasto.TipoDeGasto == (Usuario.TiposDeGastos.Fijo).ToString())
                    {
                        consumoFijo = new ConsumoFijo(formNuevoGasto.CantCuotas, consumoNuevo);
                        mesActual.Agregar(consumoFijo, mesActual.ListaConsumosFijos);
                        //mesActual.AgregarConsumo(consumoFijo);
                    }
                    else
                    {
                        if (formNuevoGasto.TipoDeGasto == (Usuario.TiposDeGastos.Volatil).ToString())
                        {

                            consumoVolatil = new ConsumoVolatil(consumoNuevo);
                            //mesActual.AgregarConsumo(consumoVolatil);
                            mesActual.Agregar(consumoVolatil, mesActual.ListaConsumosVolatiles);
                        }
                        else
                        {
                            //mesActual.AgregarConsumo(consumoNuevo);
                            mesActual.Agregar(consumoNuevo, mesActual.ListaConsumosEsporadicos);
                        }
                    }
                    datosGuardados = false;
                    Menu_Principal_Load(sender, e);                
                }

                listaDeCategoriasDelUsuario = formNuevoGasto.ListaDeCategorias;
                if (formNuevoGasto.Eleccion == 1)
                {
                    formNuevoGasto.OnGuardarClicked(EventArgs.Empty);
                } else
                {
                    formNuevoGasto.OnSalirClicked (EventArgs.Empty);
                }
            //} while (formNuevoGasto.Eleccion == 1);
            CambiarColorDeMenu();
        }

        private void mnu_ConsumoPagado_Click(object sender, EventArgs e)
        {
            VerificarObjetivo();
            FormNuevoPago formNuevoPago = new FormNuevoPago(usuarioLogeado, mesActual, listaDeCategoriasDelUsuario, this);
            formNuevoPago.GuardarClicked += mnu_ConsumoPagado_Click;
            formNuevoPago.SuscribirseAlEventoDelFormPrincipal(this);
            EnviarDatosAlFormSecundario();
            Sistema.SetearConfiguracion(formNuevoPago);
            CambiarColorDeMenu();
            DialogResult dg = formNuevoPago.ShowDialog();
            if (dg == DialogResult.OK)
            {
                MessageBox.Show("Se guardo el cambio con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datosGuardados = false;
                Menu_Principal_Load(sender, e);
            }
            
            if (formNuevoPago.Eleccion == 1)
            {
                formNuevoPago.OnGuardarClicked(EventArgs.Empty);
            }
            CambiarColorDeMenu();
        }

        private void InicializarMes()
        {
            DateTime ultimaFecha = new DateTime(1 / 1 / 1900);
            if (usuarioLogeado.ListaDeMeses.Count != 0)
            {
                //mesActual = usuarioLogeado.ListaDeMeses.Last();
                foreach (Mes mes in usuarioLogeado.ListaDeMeses)
                {
                    if (mes.FechaDeInicio > ultimaFecha)
                    {
                        ultimaFecha = mes.FechaDeInicio;
                        mesActual = mes;
                    }
                }
            }
        }
        private void InicializarCategorias()
        {
            if (usuarioLogeado.ListaDeCategorias.Count != 0)
            {
                listaDeCategoriasDelUsuario = usuarioLogeado.ListaDeCategorias;
            } else
            {
                listaDeCategoriasDelUsuario = new List<string>();
            }
        }

        private void InicializarDirectorioConsumos()
        {
            diccionarioDeConsumos = new Dictionary<string, double>();
        }

        private void mnu_EditarCategorias_Click(object sender, EventArgs e)
        {
            FormEditarCategorias formEditarCategorias = new FormEditarCategorias(listaDeCategoriasDelUsuario, this);
            Sistema.SetearConfiguracion(formEditarCategorias);
            CambiarColorDeMenu();
            DialogResult dg = formEditarCategorias.ShowDialog();
            
            if (dg == DialogResult.OK)
            {
                MessageBox.Show("Se guardo el cambio con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuarioLogeado.ActualizarCategoria(formEditarCategorias.CategoriaVieja, formEditarCategorias.CategoriaNueva, mesActual);
                listaDeCategoriasDelUsuario = formEditarCategorias.ListaDeCategorias;
                datosGuardados = false;
                Menu_Principal_Load(sender, e);
            }
            CambiarColorDeMenu();
        }

        private void mnu_EditarObjetivo_Click(object sender, EventArgs e)
        {
            FormNuevoObjetivoAhorro formNuevoObjetivoAhorro = new FormNuevoObjetivoAhorro(this);
            Sistema.SetearConfiguracion(formNuevoObjetivoAhorro);
            CambiarColorDeMenu();
            formNuevoObjetivoAhorro.SueldoCobrado = mesActual.SueldoCobrado;
            DialogResult dg = formNuevoObjetivoAhorro.ShowDialog();
            if (dg == DialogResult.OK)
            {
                MessageBox.Show("Se guardo el cambio con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mesActual.AhorroPropuesto = formNuevoObjetivoAhorro.ObjetivoNuevo;
                datosGuardados = false;
                Menu_Principal_Load(sender, e);
            }
            CambiarColorDeMenu();
        }


        private void detallesDelMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormDetallesDelMes formDetallesDelMes = new FormDetallesDelMes(mesActual, usuarioLogeado.ListaDeCategorias);
            FormDetallesDelMes formDetallesDelMes = new FormDetallesDelMes(mesActual);
            Sistema.SetearConfiguracion(formDetallesDelMes);
            this.EventoDatosEnviados += formDetallesDelMes.RecibirDatos;
            //formDetallesDelMes.SuscribirseAlEventoDelFormPrincipal(this);
            EnviarDatosAlFormSecundario();
            formDetallesDelMes.ShowDialog();
        }


        private void CalcularGastos()
        {
            //double sumatoriaDeGastos = 0;
            double resto;
            double objetivoDeAhorro;
            gastosTotales = 0;
            diccionarioDeConsumos.Clear();
            listaConsumosNoPagos.Clear();
            foreach (string categoria in listaDeCategoriasDelUsuario)
            {
                diccionarioDeConsumos.Add(categoria, 0);
                Generics.RecorrerListaConFiltroString(mesActual.ListaConsumosEsporadicos, Generics.FiltroCategoria, SumarGasto, categoria, categoria);
                Generics.RecorrerListaConFiltroString(mesActual.ListaConsumosVolatiles, Generics.FiltroCategoria, SumarGasto, categoria, categoria);
                Generics.RecorrerListaConFiltroString(mesActual.ListaConsumosFijos, Generics.FiltroCategoria, SumarGasto, categoria, categoria);

            }
            resto = mesActual.SueldoCobrado - gastosTotales;
            //gastosTotales = sumatoriaDeGastos;
            objetivoDeAhorro = mesActual.SueldoCobrado * mesActual.AhorroPropuesto / 100;
            if (resto > objetivoDeAhorro)
            {
                diccionarioDeConsumos.Add("Objetivo de ahorro", objetivoDeAhorro);
                diccionarioDeConsumos.Add("Disponible", resto - objetivoDeAhorro);
                mesActual.ObjtivoCumplido = true;
            } else
            {
                if (resto >= 0)
                {
                    diccionarioDeConsumos.Add("Disponible", resto);
                    mesActual.ObjtivoCumplido = false;
                } else
                {
                    diccionarioDeConsumos.Add("Deuda", resto);
                    mesActual.ObjtivoCumplido = false;
                }
            }
        }


        private void SumarGasto(Consumo consumo, string categoria)
        {
            //double resultado = 0;
            //if (categoria == consumo)
            //{
            if (consumo.PagoRealizado == true)
            {
                diccionarioDeConsumos[categoria] = diccionarioDeConsumos[categoria] + consumo.Monto;
                gastosTotales = gastosTotales + consumo.Monto;
            }
            else
            {
                listaConsumosNoPagos.Enqueue($"{consumo.Id}-{consumo.Nombre}");
            }
            //}
            //return resultado;
        }

        private async void guardarCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            if (datosGuardados == false)
            {
                respuesta = MessageBox.Show("¿Esta seguro que desea guardar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    SerializadoraJSON serializadora = new SerializadoraJSON();
                    Generics.TrabajarArchivo("Configuracion", "config.json", serializadora.Escribir, Sistema.Config);
                    //SerializadoraJSON.Escribir("Configuracion","config.json", Sistema.Config);
                    if (await Sistema.GuardarDatos(usuarioLogeado, mesActual, listaDeCategoriasDelUsuario) != null)

                    {
                        MessageBox.Show("Se guardo exitosamente", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datosGuardados = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        datosGuardados = false;
                    }
                }

            }
        }
        private void CargarTextos()
        {
            StringBuilder sbLista = new StringBuilder();

            rch_Datos.Clear(); // Limpiar el contenido previo del RichTextBox
            rch_Datos.BackColor = Sistema.Config.ColorPrincipal;
            rch_Pagos.BackColor = Sistema.Config.ColorPrincipal;

            lbl_Saludo.Text = $"¡Bienvenido\n{usuarioLogeado.NombreDeUsuario}!";
            lbl_Saludo.ForeColor = Sistema.Config.ColorDetalles;
            lbl_Ciclo.ForeColor = Sistema.Config.ColorContraste;
            lbl_Progreso.ForeColor = Sistema.Config.ColorContraste;

            TextoConDosColores(rch_Datos, Sistema.Config.ColorDetalles, "Sueldo de este mes: ", $"${mesActual.SueldoCobrado}\n");
            TextoConDosColores(rch_Datos, Sistema.Config.ColorDetalles, "Objetivo de ahorro: ", $"%{mesActual.AhorroPropuesto} ");
            rch_Datos.AppendText($"(${mesActual.SueldoCobrado * mesActual.AhorroPropuesto / 100})\nDia de inicio ciclo: {mesActual.InicioDeCiclo}\n");

            if (finDeCiclo != 1)
            {
                TextoConDosColores(rch_Datos, Sistema.Config.ColorDetalles, "¡Faltan ", $"{finDeCiclo}");
                rch_Datos.AppendText(" dias para terminar el ciclo!\n");
            } else
            {
                TextoConDosColores(rch_Datos, Sistema.Config.ColorDetalles, "¡Falta ", $"{finDeCiclo}");
                rch_Datos.AppendText(" dia para terminar el ciclo!\n");
            }


            if (mesActual.ObjtivoCumplido == true)
            {
                TextoConDosColores(rch_Datos, Sistema.Config.ColorDetalles, "Tu objetivo de ahorro esta en estado: ", "OK\n");
            } else
            {
                TextoConDosColores(rch_Datos, Color.Red, "Tu objetivo de ahorro esta en estado: ", "SUPERADO\n");
            }

            if (diccionarioDeConsumos.Count != 0)
            {
                if (mesActual.ObjtivoCumplido)
                {
                    TextoConDosColores(rch_Datos, Sistema.Config.ColorDetalles, "Consumo actual: ", $"${gastosTotales}\n");
                    TextoConDosColores(rch_Datos, Sistema.Config.ColorDetalles, "Disponible para antes de llegar al objetivo: ", $"${diccionarioDeConsumos["Disponible"]}");
                }
                else
                {
                    if (diccionarioDeConsumos.Last().Key == "Disponible")
                    {
                        TextoConDosColores(rch_Datos, Color.Orange, "Consumo actual: ", $"${gastosTotales}\n");
                        TextoConDosColores(rch_Datos, Color.Orange, "Disponible para gastar ya sin cumplir el objetivo: ", $"${diccionarioDeConsumos["Disponible"]}");
                    } else
                    {
                        TextoConDosColores(rch_Datos, Color.Red, "Consumo actual: ", $"${gastosTotales}\n");
                        TextoConDosColores(rch_Datos, Color.Red, "Deuda ", $"${diccionarioDeConsumos["Deuda"]}");                    
                    }
                }
            }

            rch_Pagos.Clear();
            if (listaConsumosNoPagos.Count != 0)
            {
                foreach (string consumo in listaConsumosNoPagos)
                {
                    sbLista.AppendLine(consumo.ToString());
                }
                TextoConDosColores(rch_Pagos, Color.Red, "", "Gastos por pagar:\n");
                TextoConDosColores(rch_Pagos, Color.Red, sbLista.ToString(), "");
            }
            else
            {
                TextoConDosColores(rch_Pagos, Sistema.Config.ColorDetalles, "Gastos por pagar: ", "NINGUNO");
            }
        }

        private void TextoConDosColores(System.Windows.Forms.RichTextBox rch, Color segundoColor, string textoPrimerColor, string textoSegundoColor)
        {
            rch.SelectionColor = Sistema.Config.ColorContraste;
            rch.AppendText(textoPrimerColor);
            rch.SelectionColor = segundoColor;
            rch.AppendText(textoSegundoColor);
            rch.SelectionColor = Sistema.Config.ColorContraste;
        }

        private void restaurarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Esta por restaurar los datos cuando inicio el programa por ultima vez, esta seguro que desea realizarlo?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Mes mesHueco = null;
                //mesActual = SerializadoraXML.Leer("Backup", "backupMes.xml");
                SerializadoraXML serializadora = new SerializadoraXML();
                mesHueco = Generics.TrabajarArchivo("Backup", "backupMes.xml", serializadora.Leer, mesHueco);
                if (mesHueco != null)
                {
                    mesActual = mesHueco;
                }
                Menu_Principal_Load(sender, e);
            }

        }

        private void mnu_SubMenuVerde_Click(object sender, EventArgs e)
        {
            Sistema.Config.SetearColorDetalle(Color.FromArgb(0, 153, 41), "verde");
            datosGuardados = false;
            Menu_Principal_Load(sender, e);
        }

        private void mnu_SubMenuRojo_Click(object sender, EventArgs e)
        {
            Sistema.Config.SetearColorDetalle(Color.FromArgb(205, 92, 92), "rojo");
            datosGuardados = false;
            Menu_Principal_Load(sender, e);
        }

        private void mnu_SubMenuAzul_Click(object sender, EventArgs e)
        {
            Sistema.Config.SetearColorDetalle(Color.FromArgb(28, 180, 199), "azul");
            datosGuardados = false;
            Menu_Principal_Load(sender, e);
        }

        private void mnu_SubMenuClaro_Click(object sender, EventArgs e)
        {
            Sistema.Config.CambiarTema("claro");
            datosGuardados = false;
            Menu_Principal_Load(sender, e);
        }

        private void mnu_SubMenuOscuro_Click(object sender, EventArgs e)
        {
            Sistema.Config.CambiarTema("oscuro");
            datosGuardados = false;
            Menu_Principal_Load(sender, e);
        }
        private void consumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consumo consumoNuevo;
            ConsumoFijo consumoFijo;
            ConsumoVolatil consumoVolatil;
            FormNuevoConsumo formNuevoGasto = new FormNuevoConsumo(this);

            Sistema.SetearConfiguracion(formNuevoGasto);
            formNuevoGasto.SetearFormParaEditar();
            formNuevoGasto.GuardarClicked += mnu_ConsumoNuevo_Click;
            formNuevoGasto.SuscribirseAlEventoDelFormPrincipal(this);
            EnviarDatosAlFormSecundario();
            CambiarColorDeMenu();
            DialogResult dg = formNuevoGasto.ShowDialog();

            if (dg == DialogResult.OK)
            {
                consumoNuevo = formNuevoGasto.NuevoGasto;

                switch (formNuevoGasto.TipoDeGasto)
                {
                    case "Fijo":
                        consumoFijo = new ConsumoFijo(formNuevoGasto.CantCuotas, consumoNuevo);
                        consumoFijo.Id = formNuevoGasto.IdAEditar;
                        if (formNuevoGasto.Eleccion == 1)
                        {
                            if (formNuevoGasto.TipoDeGasto == formNuevoGasto.GastoViejo)
                            {
                                Generics.RecorrerListaConFiltroString(mesActual.ListaConsumosFijos, Generics.FiltroId, mesActual.Modificar, consumoFijo.Id, consumoFijo);
                            }
                            else
                            {
                                EliminarSegunEleccion(formNuevoGasto.GastoViejo, consumoFijo);
                               /* {
                                    case "Fijo":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosFijos, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                    case "Volatil":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosVolatiles, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                    case "Esporadico":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosEsporadicos, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                }*/
                                mesActual.Agregar(consumoFijo, mesActual.ListaConsumosFijos);

                            }
                        }
                        else
                        {
                            Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosFijos, Generics.FiltroId, mesActual.Eliminar, consumoFijo.Id);
                        }
                        break;
                    case "Volatil":
                        consumoVolatil = new ConsumoVolatil(consumoNuevo);
                        consumoVolatil.Id = formNuevoGasto.IdAEditar;
                        
                        if (formNuevoGasto.Eleccion == 1)
                        {
                            if (formNuevoGasto.TipoDeGasto == formNuevoGasto.GastoViejo)
                            {
                                Generics.RecorrerListaConFiltroString(mesActual.ListaConsumosVolatiles, Generics.FiltroId, mesActual.Modificar, consumoVolatil.Id, consumoVolatil);
                            }
                            else
                            {
                                EliminarSegunEleccion(formNuevoGasto.GastoViejo, consumoVolatil);
                               /* {
                                    case "Fijo":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosFijos, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                    case "Volatil":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosVolatiles, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                    case "Esporadico":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosEsporadicos, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                }*/
                                mesActual.Agregar(consumoVolatil, mesActual.ListaConsumosVolatiles);
                            }
                            
                        }
                        else
                        {
                            Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosVolatiles, Generics.FiltroId, mesActual.Eliminar, consumoVolatil.Id);
                        }
                        break;
                    case "Esporadico":
                        consumoNuevo.Id = formNuevoGasto.IdAEditar;
                        if (formNuevoGasto.Eleccion == 1)
                        {
                            if (formNuevoGasto.TipoDeGasto == formNuevoGasto.GastoViejo)
                            {
                                Generics.RecorrerListaConFiltroString(mesActual.ListaConsumosEsporadicos, Generics.FiltroId, mesActual.Modificar, consumoNuevo.Id, consumoNuevo);
                            }
                            else
                            {
                                EliminarSegunEleccion(formNuevoGasto.GastoViejo, consumoNuevo);
                                /*{
                                    case "Fijo":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosFijos, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                    case "Volatil":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosVolatiles, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                    case "Esporadico":
                                        Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosEsporadicos, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                                        break;
                                }*/
                                mesActual.Agregar(consumoNuevo, mesActual.ListaConsumosEsporadicos);
                            }
                        }
                        else
                        {
                            Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosEsporadicos, Generics.FiltroId, mesActual.Eliminar, consumoNuevo.Id);
                        }
                        break;
                }
            }
            listaDeCategoriasDelUsuario = formNuevoGasto.ListaDeCategorias;
            CambiarColorDeMenu();
            datosGuardados = false;
            Menu_Principal_Load(sender, e);
        }
        private void EliminarSegunEleccion (string eleccion, IConsumible consumo)
        {
            switch (eleccion)
            {
                case "Fijo":
                    Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosFijos, Generics.FiltroId, mesActual.Eliminar, consumo.Id);
                    break;
                case "Volatil":
                    Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosVolatiles, Generics.FiltroId, mesActual.Eliminar, consumo.Id);
                    break;
                case "Esporadico":
                    Generics.RecorrerListaConFiltroInt(mesActual.ListaConsumosEsporadicos, Generics.FiltroId, mesActual.Eliminar, consumo.Id);
                    break;
            }           
        }
        private void CambiarColorDeMenu ()
        {
            if (mnu_MenuPrincipal.BackColor != Sistema.Config.ColorSeleccionVentana)
            {
                mnu_MenuPrincipal.BackColor = Sistema.Config.ColorSeleccionVentana;
            } else
            {
                mnu_MenuPrincipal.BackColor = Sistema.Config.ColorPrincipal;
            }
            
        }

        private void sueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoObjetivoAhorro formNuevoObjetivoAhorro = new FormNuevoObjetivoAhorro(this, "Nuevo sueldo", "$");
            Sistema.SetearConfiguracion(formNuevoObjetivoAhorro);
            CambiarColorDeMenu();
            DialogResult dg = formNuevoObjetivoAhorro.ShowDialog();
            if (dg == DialogResult.OK)
            {
                MessageBox.Show("Se guardo el cambio con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mesActual.SueldoCobrado = formNuevoObjetivoAhorro.ObjetivoNuevo;
                datosGuardados = false;
                Menu_Principal_Load(sender, e);
            }
            CambiarColorDeMenu();
        }
    }                          
}
