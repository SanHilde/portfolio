using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using LiveCharts.WinForms;
using System.IO;
using System.Drawing.Text;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts;
using System.Drawing.Imaging;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using Chart = System.Windows.Forms.DataVisualization.Charting.Chart;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Entidades
{
    public static class Grafica
    {
        static Color[] tonosVerdes;
        static Color[] tonosRojos;
        static Grafica() 
        {

            tonosVerdes = new Color[]
            {
                Color.FromArgb(0, 128, 0),        // Green
                Color.FromArgb(85, 107, 47),      // Olive
                Color.FromArgb(107, 142, 35),     // Olive Drab
                Color.FromArgb(154, 205, 50),     // Yellow Green
                Color.FromArgb(173, 255, 47),     // Green Yellow
                Color.FromArgb(143, 188, 143),    // Dark Sea Green
                Color.FromArgb(50, 205, 50),      // Lime Green
                Color.FromArgb(60, 179, 113),     // Medium Sea Green
                Color.FromArgb(32, 178, 170),     // Light Sea Green
                Color.FromArgb(46, 139, 87),      // Sea Green
                Color.FromArgb(0, 255, 0),        // Lime
                Color.FromArgb(124, 252, 0),      // Lawn Green
                Color.FromArgb(144, 238, 144),    // Light Green
                Color.FromArgb(152, 251, 152),    // Pale Green
                Color.FromArgb(0, 255, 127),      // Spring Green
                Color.FromArgb(0, 128, 128),      // Teal
                Color.FromArgb(0, 255, 255),      // Cyan
                Color.FromArgb(0, 206, 209),      // Dark Turquoise
                Color.FromArgb(64, 224, 208),     // Turquoise
                Color.FromArgb(127, 255, 212),    // Aquamarine
                Color.FromArgb(0, 250, 154),      // Medium Spring Green
                Color.FromArgb(0, 255, 127),      // Spring Green
                Color.FromArgb(0, 255, 0),        // Lime
            };
            tonosRojos = new Color[]
            {
                Color.FromArgb(255, 0, 0),         // Red
                Color.FromArgb(139, 0, 0),         // Dark Red
                Color.FromArgb(165, 42, 42),       // Brown
                Color.FromArgb(178, 34, 34),       // Firebrick
                Color.FromArgb(220, 20, 60),       // Crimson
                Color.FromArgb(205, 92, 92),       // Indian Red
                Color.FromArgb(255, 99, 71),       // Tomato
                Color.FromArgb(240, 128, 128),     // Light Coral
                Color.FromArgb(250, 128, 114),     // Salmon
                Color.FromArgb(255, 69, 0),        // Orange Red
                Color.FromArgb(255, 0, 255),       // Magenta
                Color.FromArgb(139, 0, 139),       // Dark Magenta
                Color.FromArgb(128, 0, 0),         // Maroon
                Color.FromArgb(255, 20, 147),      // Deep Pink
                Color.FromArgb(199, 21, 133),      // Medium Violet Red
                Color.FromArgb(219, 112, 147),     // Pale Violet Red
                Color.FromArgb(255, 105, 180),     // Hot Pink
                Color.FromArgb(255, 182, 193),     // Light Pink
                Color.FromArgb(255, 192, 203),     // Pink
                Color.FromArgb(255, 228, 181),     // Moccasin
                Color.FromArgb(250, 235, 215),     // Antique White
                Color.FromArgb(255, 255, 240),     // Ivory
            };
        }
        public static Color[] TonosVerdes
        { 
            get 
            { 
                return tonosVerdes; 
            }
        }
        public static Color[] TonosRojos
        {
            get
            {
                return tonosRojos;
            }
        }
        public static Button SetearBoton(Button boton, int borde, Color colorDeMouseDown, Color colorDeMouseOver, Color colorDeFondo, Color colorDeTexto, FlatStyle estilo)
        {
            boton.FlatAppearance.BorderSize = borde;
            boton.FlatStyle = estilo;
            boton.FlatAppearance.BorderColor = colorDeMouseDown;
            boton.FlatAppearance.MouseDownBackColor = colorDeMouseDown;
            boton.FlatAppearance.MouseOverBackColor = colorDeMouseOver;
            boton.BackColor = colorDeFondo;
            boton.ForeColor = colorDeTexto;
            return boton;
        }
        public static Button SetearBoton(Button boton)
        {
            float factor = 0.5f; // Factor de oscurecimiento (0-1)
            Color nuevoColor;
            if (Sistema.Config.TemaElegido == "oscuro")
            {                
                nuevoColor = ControlPaint.Dark(Sistema.Config.ColorDetalles, factor);
            } else
            {
                nuevoColor = ControlPaint.Light(Sistema.Config.ColorDetalles, factor);
            }
            
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = Sistema.Config.ColorIntermedio;
            boton.FlatAppearance.MouseDownBackColor = Sistema.Config.ColorPrincipal;
            boton.FlatAppearance.MouseOverBackColor = nuevoColor;
            boton.BackColor = Sistema.Config.ColorDetalles;
            //boton.ForeColor = Color.White;
            return boton;
        }
        public static Button SetearBoton(Button boton, Color colorBoton)
        {
            float factor = 0.5f; // Factor de oscurecimiento (0-1)
            Color nuevoColor;
            if (Sistema.Config.TemaElegido == "oscuro")
            { 
                nuevoColor = ControlPaint.Dark(colorBoton, factor);
            }
            else
            {
                nuevoColor = ControlPaint.Light(colorBoton, factor);
            }
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            //boton.FlatAppearance.BorderColor = Sistema.Config.ColorContraste;
            boton.FlatAppearance.MouseDownBackColor = Sistema.Config.ColorPrincipal;
            boton.FlatAppearance.MouseOverBackColor = nuevoColor;
            boton.BackColor = colorBoton;
            //boton.ForeColor = Color.White;
            return boton;
        }

        public static Point UbicacionDeForm(Form formHijo, Form formPadre)
        {
            int x = formPadre.Location.X + formPadre.Width - formHijo.Width-8;
            int y = formPadre.Location.Y+31;
            formHijo.Location = new Point(x, y);
            formHijo.Height = formPadre.Height - 39;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Width = 316;
            Sistema.SetearConfiguracion(formHijo);

            return formHijo.Location;
        }
        public static string AbreviarTexto(string texto, int longitudMaxima)
        {
            string respuesta;
            if (texto.Length > longitudMaxima)
            {
                respuesta= texto.Substring(0, longitudMaxima) + "...";
                
            } else
            {
                respuesta = texto;
            }
            return respuesta;
        }

        public static Chart CrearGrafico(Chart grafico, Dictionary<string, double> valores, string tituloDelGrafico, double sueldoCobrado)
        {

            Series series = new Series("series");

            grafico.Legends[0].BackColor = Color.Transparent;
            grafico.ChartAreas[0].BackColor = Color.Transparent;
            grafico.Legends[0].ForeColor = Sistema.Config.ColorContraste;
            grafico.Series.Clear();
            grafico.Titles.Clear();
            grafico.Titles.Add(tituloDelGrafico);
            grafico.Titles[0].Alignment = ContentAlignment.TopLeft;
            grafico.Titles[0].ForeColor = Sistema.Config.ColorDetalles;// 
            grafico.Titles[0].Font = new Font(grafico.Titles[0].Font, FontStyle.Bold);
            grafico.Titles[0].Font = new Font(grafico.Titles[0].Font.FontFamily, 14f);
            
            series.ChartType = SeriesChartType.Pie;
            series["PieLabelStyle"] = "Disabled";
            //series.Legend = "LegendName"; // Asegúrate de establecer el nombre de la leyenda aquí
            // Mover la leyenda hacia la derecha (ajusta los valores según tus necesidades)
            //grafico.Legends[0].Position.X = ; // Cambia el valor según tus necesidades


            // Asignar la paleta de colores al gráfico

            switch (Sistema.Config.ColorElegido)
            {
                case "rojo":
                    grafico.Palette = ChartColorPalette.None;
                    grafico.PaletteCustomColors = Grafica.TonosRojos;
                    break;
                case "verde":
                    grafico.Palette = ChartColorPalette.None;
                    grafico.PaletteCustomColors = Grafica.TonosVerdes;
                    break;
                case "azul":
                    grafico.Palette = ChartColorPalette.SeaGreen;
                    break;
                    
            }
            
            foreach (KeyValuePair<string, double> kvp in valores)
            {
                if (kvp.Value  != 0)
                {  
                    DataPoint dataPoint = new DataPoint();                    
                    double porcentaje = Math.Round((kvp.Value * 100) / sueldoCobrado, 1);
                    
                    if (kvp.Value > 0)
                    {
                        dataPoint.AxisLabel = kvp.Key; 
                        dataPoint.YValues = new double[] { kvp.Value };
                        series.Points.Add(dataPoint);
                        dataPoint.LegendText = $"${kvp.Value} - {kvp.Key}"; // Conservar el texto original en la leyenda
                        dataPoint.Label = $"{kvp.Key} - %{porcentaje} "; //datos grafico
                        dataPoint.LabelForeColor = Sistema.Config.ColorContraste;
                    }
                }
            }
            
            series["PieLabelStyle"] = "Outside";
            series.Font = new Font("Calibri", 10, FontStyle.Bold); // Establecer el color de las letras en blanco
            grafico.Series.Add(series);
            // Obtener la referencia a la ChartArea
            ChartArea chartArea = grafico.ChartAreas[0];

            // Ajustar el tamaño de la ChartArea
            chartArea.InnerPlotPosition.Auto = false;
            chartArea.InnerPlotPosition.Width = 75; // Ajustar el ancho según tus necesidades (porcentaje)
            chartArea.InnerPlotPosition.Height = 75; // Ajustar la altura según tus necesidades (porcentaje)
            chartArea.InnerPlotPosition.X = 0; // Ajustar la posición X según tus necesidades (porcentaje)
            chartArea.InnerPlotPosition.Y = 10; // Ajustar la posición Y según tus necesidades (porcentaje)

            

            chartArea.Position.Auto = false;
            chartArea.Position.Width = 100; // Ajustar el ancho según tus necesidades (porcentaje)
            chartArea.Position.Height = 100; // Ajustar la altura según tus necesidades (porcentaje)
            chartArea.Position.X = 0; // Ajustar la posición X según tus necesidades (porcentaje)
            chartArea.Position.Y = 0; // Ajustar la posición Y según tus necesidades (porcentaje)

            return grafico;

        }
        public static void SetearMenuStrip(MenuStrip menu, Form formulario, bool MenuConImagenes)
        {
            int contador = 1;
            string rutaIconos = Sistema.Config.Ruta; // Ruta de la carpeta de iconos

            foreach (ToolStripItem item in menu.Items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    // Cargar el icono correspondiente
                    string rutaIcono = Path.Combine(rutaIconos, $"icono-{contador}-{Sistema.Config.TemaElegido}.png");
                    if (File.Exists(rutaIcono) && MenuConImagenes == true)
                    {
                        item.Image = Image.FromFile(rutaIcono);
                    }

                    // Configurar los colores del menú y submenús
                    menuItem.ForeColor = Sistema.Config.ColorContraste;
                    menuItem.BackColor = Color.Transparent;//Sistema.Config.ColorSeleccionVentana;

                    // Aplicar cambios a los submenús
                    SetearColoresSubmenu(menuItem.DropDownItems);

                    contador++;
                }
            }

            formulario.BackColor = Sistema.Config.ColorPrincipal;
            menu.BackColor = Sistema.Config.ColorSeleccionVentana;
        }

        private static void SetearColoresSubmenu(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    // Configurar los colores del submenú
                    menuItem.ForeColor = Sistema.Config.ColorContraste;
                    menuItem.BackColor = Sistema.Config.ColorSeleccionVentana;

                    // Aplicar cambios a los submenús anidados
                    SetearColoresSubmenu(menuItem.DropDownItems);
                }
            }
        }

    }
}
