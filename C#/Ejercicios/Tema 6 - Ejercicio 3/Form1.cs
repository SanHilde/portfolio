using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaMoneda;

namespace Tema_6___Ejercicio_3
{
    public partial class FrmMonedas : Form
    {
        int indice = 0;
        public FrmMonedas()
        {
            InitializeComponent();

            txt_CotPeso.Text = "400";
            txt_CotEuro.Text = "2";
            txt_CotDolar.Text = "1";

            Pesos.SetCotizacion(double.Parse(txt_CotPeso.Text));
            Euro.SetCotizacion(double.Parse(txt_CotEuro.Text));

        }
        private void btn_Euro_Click(object sender, EventArgs e)
        {

            double cotizacion;
            double actualizacion;

            if (string.IsNullOrEmpty(txt_CantEuro.Text) == false && double.TryParse(txt_CantEuro.Text, out actualizacion) == true)
            {
                cotizacion = double.Parse(txt_CotEuro.Text);
                Euro.SetCotizacion(cotizacion);

                txt_EuroXEuro.Text = txt_CantEuro.Text;
                txt_EuroXDolar.Text = ((Dolar)((Euro)(double.Parse(txt_CantEuro.Text)))).GetCantidad().ToString();
                txt_EuroXPeso.Text = ((Pesos)((Euro)(double.Parse(txt_CantEuro.Text)))).GetCantidad().ToString();
            } else
            {
                MessageBox.Show("Lo que ingreso no es un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CantEuro.Focus();
            }

        }

        private void btn_Dolar_Click(object sender, EventArgs e)
        {
            double cotizacion;
            double actualizacion;

            if (string.IsNullOrEmpty(txt_CantDolar.Text) == false && double.TryParse(txt_CantDolar.Text, out actualizacion) == true)
            {
                txt_DolarXDolar.Text = txt_CantDolar.Text;
                txt_DolarXEuro.Text = ((Euro)((Dolar)(double.Parse(txt_CantDolar.Text)))).GetCantidad().ToString();
                txt_DolarXPeso.Text = ((Pesos)((Dolar)(double.Parse(txt_CantDolar.Text)))).GetCantidad().ToString();
            } else
            {
                MessageBox.Show("Lo que ingreso no es un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CantDolar.Focus();
            }
        }

        private void btn_Peso_Click(object sender, EventArgs e)
        {
            double cotizacionPeso;
            double actualizacion;

            if (string.IsNullOrEmpty(txt_CantPeso.Text) == false && double.TryParse(txt_CantPeso.Text, out actualizacion) == true)
            {
                cotizacionPeso = double.Parse(txt_CotPeso.Text);
                Pesos.SetCotizacion(cotizacionPeso);
                txt_PesoXPeso.Text = txt_CantPeso.Text;
                txt_PesoXEuro.Text = ((Euro)((Pesos)(double.Parse(txt_CantPeso.Text)))).GetCantidad().ToString();
                txt_PesoXDolar.Text = ((Dolar)((Pesos)(double.Parse(txt_CantPeso.Text)))).GetCantidad().ToString();
            } else
            {
                MessageBox.Show("Lo que ingreso no es un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CantPeso.Focus();
            }
        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            if (indice == 0)
            {
                indice = 1;
            } else
            {
                indice = 0;
            }

            btn_Lock.ImageIndex = indice;
            if (indice == 0)
            {
                txt_CotDolar.Enabled = false;
                txt_CotEuro.Enabled = false;
                txt_CotPeso.Enabled = false;
            } else
            {
                txt_CotDolar.Enabled = true;
                txt_CotEuro.Enabled = true;
                txt_CotPeso.Enabled = true;
            }
        }

        private void txt_CotPeso_Leave(object sender, EventArgs e)
        {
            double actualizacion;
            if (double.TryParse(txt_CotPeso.Text, out actualizacion) == true)
            {
                btn_Peso_Click(sender, e);
                btn_Dolar_Click(sender, e);
                btn_Euro_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Lo que ingreso no es un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CotPeso.Focus();
            }
        }

        private void txt_CotDolar_Leave(object sender, EventArgs e)
        {
            if (txt_CotDolar.Text != "1")
            {
                MessageBox.Show("La cotizacion del dolar siempre deber ser 1");
                txt_CotDolar.Text = "1";
            }
        }

        private void txt_CotEuro_Leave(object sender, EventArgs e)
        {
            double actualizacion;
            if (double.TryParse(txt_CotEuro.Text, out actualizacion) == true)
            {
                btn_Peso_Click(sender, e);
                btn_Dolar_Click(sender, e);
                btn_Euro_Click(sender, e);
            } else
            {
                MessageBox.Show ("Lo que ingreso no es un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CotEuro.Focus();
            }

        }
    }
}
