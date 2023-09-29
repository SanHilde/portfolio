using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tema_6___Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cboMaterias.Items.Add("Programacion I");
            cboMaterias.Items.Add("Programacion II");
            cboMaterias.Items.Add("Laboratorio de programacion I");
            cboMaterias.Items.Add("Laboratorio de programacion II");
            cboMaterias.Items.Add("Ingles I");
            cboMaterias.Items.Add("Ingles II");
            cboMaterias.Items.Add("Matematica I");
            cboMaterias.Items.Add("Estadistica");
            cboMaterias.Items.Add("SPD");
            cboMaterias.Items.Add("Arquitectura y Sistemas Operativos");
            cboMaterias.Items.Add("Metodologia de la investigacion");
            cboMaterias.SelectedIndex = 0;

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string materiaFavorita;
            StringBuilder sb = new StringBuilder();

            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            materiaFavorita =cboMaterias.Text;
            if (String.IsNullOrEmpty(nombre) !=true && String.IsNullOrEmpty(apellido) != true)
            {
                MessageBox.Show($"¡Hola Windows Forms! \nSoy {nombre} {apellido} y mi materia favorita es {materiaFavorita}. ","Saludo");
            } else
            {
                sb.Append("Se deben completar los siguiente campos:\n");
                if (String.IsNullOrEmpty(nombre) == true)
                {
                    sb.Append("Nombre\n");
                }
                if (String.IsNullOrEmpty(apellido) == true)
                {
                    sb.Append("Apellido\n");
                }
                MessageBox.Show(sb.ToString(), "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


    }
}
