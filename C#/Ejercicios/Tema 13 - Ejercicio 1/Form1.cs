using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_13___Ejercicio_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AsignarHora();
            timer1.Interval = 1000; // Intervalo de 1 segundo
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            new Task(UpdateDateTime);
            updateTimeThread.Start();
        }
        
        private void AsignarHora()
        {
            TimeSpan horaActual = DateTime.Now.TimeOfDay;
            lbl_Hora.Text =  $"{horaActual.Hours}:{horaActual.Minutes}:{horaActual.Seconds}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AsignarHora();
        }
        private void UpdateDateTime()
        {
            while (true)
            {
                // Obtener la hora actual
                //DateTime now = DateTime.Now;

                // Actualizar el texto del Label en el hilo principal utilizando Invoke
                /*label1.Invoke(new Action(() =>
                {
                    label1.Text = now.ToString("HH:mm:ss");
                }));*/
                AsignarHora();
                // Esperar 1 segundo
                Thread.Sleep(1000);
            }
        }
}
