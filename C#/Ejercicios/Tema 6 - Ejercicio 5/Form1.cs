using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Tema_2___Ejercicio_3._1;
//using Tema_4___Ejercicio_3;


namespace Tema_6___Ejercicio_5
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            string binarioDecimalIngresado = txtBinarioDecimalIngreso.Text;
            int binarioDecimal;


            if (int.TryParse(binarioDecimalIngresado,out binarioDecimal) == true)
            {
                //txtBinarioDecimalResp = Conversor.ConvertirBinarioADecimal((double)binarioDecimal);
            }




        }

        private void btnDecimalBinario_Click(object sender, EventArgs e)
        {
            string binarioDecimalIngresado = txtBinarioDecimalIngreso.Text;
            int decimalBinario;


            if (int.TryParse(binarioDecimalIngresado, out decimalBinario) == true)
            {
                //txtDecimalBinarioResp.Text = Conversor.ConvertirBinarioADecimal(decimalBinario);
            } else
            {
                MessageBox.Show ("Lo que ingreso no es un numero decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
