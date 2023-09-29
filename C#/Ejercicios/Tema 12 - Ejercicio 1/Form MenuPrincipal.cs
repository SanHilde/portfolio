using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_12___Ejercicio_1
{
    public partial class Form_MenuPrincipal : Form
    {
        FrmMostrar formMostrar;
        FrmTestDelegados formTestDelegados;
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            formMostrar = new FrmMostrar();
            formMostrar.MdiParent = this;
            formTestDelegados = new FrmTestDelegados();
            formTestDelegados.MdiParent = this;
            TSMI_Mostrar.Enabled = false;
            formTestDelegados.actualizarLb = atraparDelegado;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTestDelegados.Show();
            TSMI_Mostrar.Enabled = true;
            
        }

        private void TSMI_Mostrar_Click(object sender, EventArgs e)
        {
            formMostrar.Show();
        }
        private void atraparDelegado (string dato)
        {
            MessageBox.Show(dato);
        }
    }
}
