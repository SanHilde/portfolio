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

namespace Interfaz
{
    public partial class FormHeredableDosBotones : Form
    {
        public FormHeredableDosBotones()
        {
            InitializeComponent();
            pic_Divisor.Height = 565;

        }
        public FormHeredableDosBotones(int tamañoBarra) : this()
        {
            pic_BarraLateral.Height = tamañoBarra;
        }
        public virtual void btn_Guardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public virtual void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormHeredableDosBotones_Load(object sender, EventArgs e)
        {
            Grafica.SetearBoton(btn_Guardar, Color.ForestGreen);
            Grafica.SetearBoton(btn_Cancelar, Color.DarkRed);
            pic_BarraLateral.BackColor = Sistema.Config.ColorDetalles;
        }
        public void DesactivarBarra()
        {
            pic_BarraLateral.Visible = false;
        }
    }
}
