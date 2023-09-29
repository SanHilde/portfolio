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
using Entidades;


namespace Interfaz
{
    public partial class FormCreacionPersonaje : Form
    {
        public FormCreacionPersonaje()
        {
            InitializeComponent();
        }

        private void FormCreacionPersonaje_Load(object sender, EventArgs e)
        {
            Array clasesPersonajes = Enum.GetValues(typeof(ClasePersonaje));
            foreach (ClasePersonaje clase in clasesPersonajes)
            {
                cmb_Clase.Items.Add(clase);
            }
        }

        private void cmb_Clase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = cmb_Clase.SelectedIndex;
            Image imagenSeleccionada = imglst_Clases.Images[indiceSeleccionado];
            pic_Clase.Image = imagenSeleccionada;

        }

    }
}
