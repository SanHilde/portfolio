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
    public partial class FormHeredable : Form
    {
        int eleccion;
        List<string> listaDeCategorias;
        

        public FormHeredable ()
        {
            InitializeComponent();
            pic_Divisor.Height = 565;
        }

        public FormHeredable(int tamañoBarra) : this ()
        {
            pic_BarraLateral.Height = tamañoBarra;
        }
        public int Eleccion
        {
            get
            {
                return this.eleccion;
            }
        }
        public List<string> ListaDeCategorias
        {
            get
            {
                return this.listaDeCategorias;
            }
        }

        public event EventHandler GuardarClicked;
        public event EventHandler SalirClicked;

        public virtual void OnGuardarClicked(EventArgs e)
        {
            GuardarClicked?.Invoke(this, e);
        }
        public virtual void OnSalirClicked(EventArgs e)
        {
            SalirClicked?.Invoke(this, e);
        }

        public virtual void btn_GuardarYContinuar_Click(object sender, EventArgs e)
        {           
            this.DialogResult = DialogResult.OK;
            this.eleccion = 1;
        }

        public virtual void btn_GuardarYSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.eleccion = 0;
        }

        public virtual void btn_Salir_Click(object sender, EventArgs e)
        {
            this.eleccion = 0;
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormHeredable_Load(object sender, EventArgs e)
        {
            Grafica.SetearBoton(btn_GuardarYContinuar,Color.ForestGreen);
            Grafica.SetearBoton(btn_GuardarYSalir, Color.DeepSkyBlue);
            Grafica.SetearBoton(btn_Salir, Color.DarkRed);
            pic_BarraLateral.BackColor = Sistema.Config.ColorDetalles;
            
        }
        public virtual void EditarBotones (string boton1, string boton2, string boton3)
        {
            btn_GuardarYContinuar.Text = boton1;
            btn_GuardarYSalir.Text = boton2;
            btn_Salir.Text = boton3;
        }
        public void DesactivarBarra()
        {
            pic_BarraLateral.Visible = false;
            pic_Divisor.Visible = false;
        }
        public void SuscribirseAlEventoDelFormPrincipal(FormMenuPrincipal formPrincipal)
        {
            formPrincipal.EventoDatosEnviados += RecibirDatos;
        }

        public void RecibirDatos(List<string> lista)
        {
            listaDeCategorias = lista;
        }
    }
}
