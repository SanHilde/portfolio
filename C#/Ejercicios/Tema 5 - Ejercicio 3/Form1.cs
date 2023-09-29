using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_5___Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string texto;
            string[] arrayPalabras;
            Dictionary<string, int> diccionario;
            Dictionary<string, int> diccionarioOrdenado;
           
            StringBuilder stringBuilder = new StringBuilder();  

            diccionario = new Dictionary<string, int>();
            texto = rchTexto.Text;
            texto = texto.Replace(",", "");
            arrayPalabras = texto.Split(' ');

            for (int i = 0; i < arrayPalabras.Length; i++)
            {
                if (diccionario.ContainsKey(arrayPalabras[i]))
                {
                    diccionario[arrayPalabras[i]] += 1;
                }
                else
                {
                    diccionario.Add(arrayPalabras[i], 1);
                }
            
            }
            diccionarioOrdenado = diccionario.OrderByDescending(objeto => objeto.Value).Take(3).ToDictionary(objeto => objeto.Key, objeto => objeto.Value);

            foreach (var palabra in diccionarioOrdenado)
            {
                stringBuilder.Append($"Palabra: {palabra.Key} cant: {palabra.Value}\n");
            }

            MessageBox.Show(stringBuilder.ToString(), "lista");

            
        }
    }
}
