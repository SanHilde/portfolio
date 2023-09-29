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
    public partial class FrmTestDelegados : Form
    {
        //public delegate void ActualizarNombreDelegate(string nombre);
        //private ActualizarNombreDelegate actualizarNombreDelegate;
        public Action<string> actualizarLb;

        //public FrmTestDelegados(ActualizarNombreDelegate actualizarNombreDelegate)
            public FrmTestDelegados()
        {
          //  this.actualizarNombreDelegate = actualizarNombreDelegate;
            InitializeComponent();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            //actualizarNombreDelegate.Invoke(txt_Nombre.Text);

            if (actualizarLb != null ) 
            {
                actualizarLb(txt_Nombre.Text);
            }
        }
    }
}
