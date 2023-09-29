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
    public sealed partial class FormNuevoUsuario : Form
    {
        Usuario usuarioCreado;
        readonly Form formPadre;
        Point puntoDeUbicacion;
        public FormNuevoUsuario(Form formPadreTraido, Point puntoDeUbicacionTraido)
        {
            InitializeComponent();
            this.formPadre = formPadreTraido;
            this.puntoDeUbicacion = puntoDeUbicacionTraido;
        }

        public Usuario UsuarioCreado 
        {
            get
            {
                return this.usuarioCreado;
            }
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            DialogResult dg;      
            
            if ( string.IsNullOrEmpty(txt_NuevoUsuario.Text)== false || string.IsNullOrEmpty(txt_Contraseña.Text)==false || string.IsNullOrEmpty(txt_Nombre.Text) == false)
            {
                if (txt_Contraseña.Text == txt_ContraseñaRepetida.Text)
                {
                    if (Sistema.ValidarCuenta(txt_NuevoUsuario.Text) == false)
                    {
                        this.usuarioCreado = new Usuario(txt_NuevoUsuario.Text, txt_Contraseña.Text, txt_Nombre.Text);
                        MessageBox.Show("El usuario fue creado con exito", "Creacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dg = DialogResult.OK;
                        this.DialogResult = dg;
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe, ingrese otro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Uno de los campos esta vacio", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormNuevoUsuario_Load(object sender, EventArgs e)
        {
            Location = puntoDeUbicacion;
            btn_CrearUsuario = Grafica.SetearBoton(btn_CrearUsuario, Color.ForestGreen);
            btn_Cancelar = Grafica.SetearBoton(btn_Cancelar,Color.DarkRed);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult dg = DialogResult.Cancel;
            this.DialogResult = dg;
        }
    }
}
