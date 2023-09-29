using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Entidades;
using LiveCharts.WinForms;
//using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Drawing.Text;
//using LiveCharts.Wpf.Charts.Base;
using LiveCharts;

namespace Interfaz
{
    public partial class FormGraficos : Form
    {
        static Dictionary<string, double> diccionarioGraficoUno;
        static Form formPadre;
        static Point ubicacion;
        static string tituloDelGrafico;
        public FormGraficos()
        {
            InitializeComponent();
        }
        public FormGraficos(Form formPadreTraido, Point puntoUbicacionTraido, Dictionary<string, double> diccionarioTraidoUno, string titulo) :this()
        {
            diccionarioGraficoUno = diccionarioTraidoUno;
            formPadre = formPadreTraido;
            ubicacion = puntoUbicacionTraido;
            tituloDelGrafico = titulo;
        }

        private void FormGraficos_Load(object sender, EventArgs e)
        {
            Location = ubicacion;
            //CrearGrafico(diccionarioGraficoUno, crt_GrafUno);
            double total = 0;
                foreach (double valor in diccionarioGraficoUno.Values)
                {
                    total = total + valor;
                }
            Grafica.CrearGrafico(crt_GraficoTorta, diccionarioGraficoUno,tituloDelGrafico, total);

        }


    }
}
