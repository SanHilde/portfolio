using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Entidades.Usuario;
using OfficeOpenXml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Interfaz
{
    public partial class FormDetallesDelMes : Form
    {
        Mes mesIngresado;
        static List<string>  listaDeCategorias;
        static List<TiposDeGastos> listaDeTipos;
        //public FormDetallesDelMes(Mes mesPasado, List<string>listaDeCategoriasTraida)
            public FormDetallesDelMes(Mes mesPasado)
        {
            InitializeComponent();
            this.mesIngresado = mesPasado;
            //listaDeCategorias = listaDeCategoriasTraida;
            listaDeTipos = Enum.GetValues(typeof(Usuario.TiposDeGastos)).Cast<Usuario.TiposDeGastos>().ToList();
            dtaGrid_Detalles.ClearSelection();

        }
        
        private void FormDetallesDelMes_Load(object sender, EventArgs e)
        {
            SetearDataGrid();
            SetearDatosDataGrid();
            btn_Exportar = Grafica.SetearBoton(btn_Exportar);

         
        }

        /* private bool CumpleFiltro(Consumo consumo, int filtroAplicar, string tipo)
         {
             bool respuesta = false;
             switch (filtroAplicar)
             {
                 case 1:
                     respuesta = (consumo.Categoria == cbo_Categorias.Text);
                     break;
                 case 2:
                     respuesta =(tipo == cbo_Tipos.Text);
                     break;
                 case 3:
                     respuesta = (consumo.Categoria == cbo_Categorias.Text && tipo == cbo_Tipos.Text) ;
                     break;
                 default:
                     respuesta = true; // Sin filtro, se agrega la fila siempre
                     break;
             }
             return respuesta;
         }
       
        private void AñadirFila(int id, string nombre, string tipo, string categoria, string cantCuotas, string monto, bool pago, DateTime fecha)
         {
             string pagoRealizado;
             string fechaString;
             if (pago)
             {
                 pagoRealizado = "SI";
             }
             else
             {
                 pagoRealizado = "NO";
             }
             if (fecha.Day <= 9)
             {
                 fechaString = $"0{fecha.Day}/{fecha.Month}/{fecha.Year}";
             }
             else
             {
                 fechaString = $"{fecha.Day}/{fecha.Month}/{fecha.Year}";
             }
             dtaGrid_Detalles.Rows.Add(id, nombre, tipo, categoria, cantCuotas, monto, pagoRealizado, fechaString);
         }*/

        private void dtaGrid_Detalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtaGrid_Detalles.ClearSelection();
            int indiceCeldaSeleccionada = e.RowIndex;
            if (indiceCeldaSeleccionada >= 0)
            {
                DataGridViewRow resaltar = dtaGrid_Detalles.Rows[indiceCeldaSeleccionada];                
                resaltar.Selected = true;
            }
        }
        private void AñadirFila<T>(T consumo, string tipo) where T:IConsumible
        {
            string pagoRealizado;
            string fechaString;
            string cantCuotas;
            if (consumo.PagoRealizado)
            {
                pagoRealizado = "SI";
            }
            else
            {
                pagoRealizado = "NO";
            }
            if (consumo.Fecha.Day <= 9)
            {
                fechaString = $"0{consumo.Fecha.Day}/{consumo.Fecha.Month}/{consumo.Fecha.Year}";
            }else
            {
                fechaString = $"{consumo.Fecha.Day}/{consumo.Fecha.Month}/{consumo.Fecha.Year}";
            }
            if (tipo == "Esporadico" || tipo == "Volatil")
            {
                cantCuotas = "-";
            } else
            {
                ConsumoFijo consumoFijo = (ConsumoFijo)(object)consumo;
                cantCuotas = (consumoFijo.CantCuotas).ToString();
            }
            dtaGrid_Detalles.Rows.Add(consumo.Id, consumo.Nombre, tipo, consumo.Categoria, cantCuotas, $"${consumo.Monto}", pagoRealizado, fechaString);
        }


        private void FormDetallesDelMes_SizeChanged(object sender, EventArgs e)
        {       
            dtaGrid_Detalles.Location = new Point (dtaGrid_Detalles.Location.X,50);
            int columnWidth = dtaGrid_Detalles.Width / dtaGrid_Detalles.Columns.Count;
            foreach (DataGridViewColumn column in dtaGrid_Detalles.Columns)
            {
                column.Width = columnWidth;
            }
            dtaGrid_Detalles.Height = this.Height - 90;
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            /*string datosExportados = "";
            foreach (DataGridViewRow fila in dtaGrid_Detalles.Rows)
            {
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    datosExportados += celda.Value.ToString() + ",";
                }
                datosExportados = datosExportados.TrimEnd(',') + Environment.NewLine;
            }
            try
            {
                SerializadoraTXT serializadora = new SerializadoraTXT();
                Generics.TrabajarArchivo("Datos exportados", "Datos.csv", serializadora.Escribir, datosExportados);
                MessageBox.Show("Exportacion existosa, archivo creado en el escritorio", "Exportacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information );
                //Sistema.EscribirArchivo(@"Datos exportados", "Datos.csv", datosExportados);
            } catch (Exception ex) 
            {
                MessageBox.Show($"{ex}");
            }   */

            //LicenseContext lic = LicenseContext.NonCommercial;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Datos exportados");
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }

            string ruta = Path.Combine(carpeta, "Consumos exportados.xlsx");
            var newFile = new FileInfo(ruta);

            // Eliminar el archivo existente si es que hay uno
            if (newFile.Exists)
            {
                newFile.Delete();
            }

            // Crear el paquete de trabajo de Excel
            using (var package = new ExcelPackage(newFile))
            {
                
                // Agregar una nueva hoja de cálculo al paquete
                var worksheet = package.Workbook.Worksheets.Add("Datos");

                // Obtener los encabezados del DataGridView
                for (int i = 0; i < dtaGrid_Detalles.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dtaGrid_Detalles.Columns[i].HeaderText;
                }

                // Obtener los datos de las filas del DataGridView
                for (int i = 0; i < dtaGrid_Detalles.Rows.Count; i++)
                {
                    for (int j = 0; j < dtaGrid_Detalles.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dtaGrid_Detalles.Rows[i].Cells[j].Value;
                    }
                }

                // Autoajustar el ancho de las columnas
                worksheet.Cells.AutoFitColumns(0);

                // Guardar el paquete de trabajo de Excel
                package.Save();
                MessageBox.Show("Exportacion existosa, archivo creado en el escritorio", "Exportacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void SuscribirseAlEventoDelFormPrincipal(FormMenuPrincipal formPrincipal)
        {
            formPrincipal.EventoDatosEnviados += RecibirDatos;
        }

        public void RecibirDatos(List<string> lista)
        {
            listaDeCategorias = lista;
        }
        private void SetearDataGrid()
        {
            dtaGrid_Detalles.ColumnHeadersDefaultCellStyle.ForeColor = Sistema.Config.ColorDetalles;
            dtaGrid_Detalles.RowHeadersDefaultCellStyle.ForeColor = Sistema.Config.ColorContraste;
            dtaGrid_Detalles.ColumnHeadersDefaultCellStyle.BackColor = Sistema.Config.ColorPrincipal;
            dtaGrid_Detalles.RowHeadersDefaultCellStyle.BackColor = Sistema.Config.ColorPrincipal;
            dtaGrid_Detalles.DefaultCellStyle.SelectionForeColor = Sistema.Config.ColorDetalles; // Color de selección de fuente personalizado
            dtaGrid_Detalles.DefaultCellStyle.SelectionBackColor = Sistema.Config.ColorContraste; // Color de fondo de selección personalizado
            dtaGrid_Detalles.BackgroundColor = Sistema.Config.ColorSeleccionVentana;
            dtaGrid_Detalles.DefaultCellStyle.BackColor = Sistema.Config.ColorDetalles;
        }

        private void SetearDatosDataGrid()
        {
            string filtroCategorias = "";
            string filtroTipo = "";
            List<IConsumible> listaFijos = new List<IConsumible>(mesIngresado.ListaConsumosFijos);
            List<IConsumible> listVolatil = new List<IConsumible>(mesIngresado.ListaConsumosVolatiles);
            List<IConsumible> listaEsporadico = new List<IConsumible>(mesIngresado.ListaConsumosEsporadicos);

            int contador = 0;
            cbo_Categorias.Enabled = false;
            cbo_Tipos.Enabled = false;

            if (chk_Categorias.Checked == true)
            {
                contador += 1;
                cbo_Categorias.Enabled = true;
                cbo_Categorias.DataSource = listaDeCategorias;
                filtroCategorias = cbo_Categorias.SelectedItem.ToString();
            }
            if (chk_Tipo.Checked == true)
            {
                contador += 2;
                cbo_Tipos.Enabled = true;
                cbo_Tipos.DataSource = listaDeTipos;
                filtroTipo = cbo_Tipos.SelectedItem.ToString();
            }
            dtaGrid_Detalles.Rows.Clear();
            dtaGrid_Detalles.RowHeadersVisible = false;
            Generics.MiFiltroDelegado<IConsumible, string> metodoDeFiltrado;

            switch (contador)
            {
                case 1:
                    metodoDeFiltrado = (IConsumible consumo, string filtro1, string filtro2, string tipo) => { return filtro1 == consumo.Categoria; };
                    break;
                case 2:
                    metodoDeFiltrado = (IConsumible consumo, string filtro1, string filtro2, string tipo) => { return filtro2 == tipo; };
                    break;
                case 3:
                    metodoDeFiltrado = (IConsumible consumo, string filtro1, string filtro2, string tipo) => { return filtro2 == tipo && filtro1 == consumo.Categoria; };
                    break;
                default:
                    metodoDeFiltrado = (IConsumible consumo, string filtro1, string filtro2, string tipo) => { return true; };
                    break;
            }

            /*foreach (Consumo consumo in mesIngresado.ListaConsumosEsporadicos)
            {
                if (CumpleFiltro(consumo, contador, TiposDeGastos.Esporadico.ToString()))
                {
                    AñadirFila(consumo.Id, consumo.Nombre, "Esporadico", consumo.Categoria, "-", $"${consumo.Monto}", consumo.PagoRealizado, consumo.Fecha);
                }
            }
            foreach (ConsumoVolatil consumo in mesIngresado.ListaConsumosVolatiles)
            {
                if (CumpleFiltro(consumo, contador, TiposDeGastos.Volatil.ToString()))
                {
                    AñadirFila(consumo.Id, consumo.Nombre, "Volatil", consumo.Categoria, "-", $"${consumo.Monto}", consumo.PagoRealizado, consumo.Fecha);
                }
            }
            foreach (ConsumoFijo consumo in mesIngresado.ListaConsumosFijos)
            {
                if (CumpleFiltro(consumo, contador, TiposDeGastos.Fijo.ToString()))
                {
                    AñadirFila(consumo.Id, consumo.Nombre, "Fijo", consumo.Categoria, consumo.CantCuotas.ToString(), $"${consumo.Monto}", consumo.PagoRealizado, consumo.Fecha);
                }
            }*/

            Generics.RecorrerListaConDobleFiltroString(listaFijos, metodoDeFiltrado, AñadirFila, filtroCategorias, "Fijo", filtroTipo);
            Generics.RecorrerListaConDobleFiltroString(listVolatil, metodoDeFiltrado, AñadirFila, filtroCategorias, "Volatil", filtroTipo);
            Generics.RecorrerListaConDobleFiltroString(listaEsporadico, metodoDeFiltrado, AñadirFila, filtroCategorias, "Esporadico", filtroTipo);
        }
    }
}
