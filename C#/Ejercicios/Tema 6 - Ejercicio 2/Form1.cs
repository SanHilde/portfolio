using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tema_6___Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresante nuevoIngresante;

            string[] cursos=new string[0];
            string direccion;
            int edad;
            string genero;
            string nombre;
            string pais;

            nombre = txtNombre.Text;
            direccion = txtDireccion.Text;
            edad = Int32.Parse(nupEdad.Text);
            pais = lstPais.Text;

            if (radMasculino.Checked)
            {
                genero = radMasculino.Text;
            }
            else 
            {
                if (radFemenino.Checked)
                {
                    genero = radFemenino.Text;
                }
                else
                {
                    genero = radNoBinario.Text;
                }
            }

            
            if (chkUno.Checked) 
            {
                Array.Resize (ref cursos, cursos.Length+1);
                cursos[cursos.Length - 1] = chkUno.Text;
            }
            if (chkDos.Checked)
            {
                Array.Resize(ref cursos, cursos.Length + 1);
                cursos[cursos.Length - 1] = chkDos.Text;
            }
            if (chkTres.Checked)
            {
                Array.Resize(ref cursos, cursos.Length + 1);
                cursos[cursos.Length - 1] = chkTres.Text;
            }
            

            nuevoIngresante = new Ingresante(nombre,direccion,genero,pais,cursos,edad);
            MessageBox.Show(nuevoIngresante.Mostrar());
                
        }
        public void Agregar (bool check, string[] array, string texto)
        {
            if (check == true)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = texto;
            }
        }

    }
}
