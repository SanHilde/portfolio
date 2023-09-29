using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Entidades;
using static Entidades.Usuario;
using Google.Cloud.Firestore;

namespace Interfaz
{
    public partial class FormLogIn : Form
    {
        static int contador;
        static bool finalizado;


        public FormLogIn()
        {
            InitializeComponent();
            contador = 3;
            finalizado = false;
        }

        private async void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Click -= btn_Ingresar_Click;

            Usuario usuarioIngresado;
            //Usuario = new Usuario(txt_Usuario.Text, txt_Contraseña.Text);
            usuarioIngresado = await Sistema.BuscarUsuario(txt_Usuario.Text, txt_Contraseña.Text);
            DialogResult dg;
            //if (Sistema.ValidarUsuario(txt_Usuario.Text, txt_Contraseña.Text,out usuarioIngresado))
            if (usuarioIngresado != null)
            {
                if (usuarioIngresado.Estado == TipoDeEstado.Vigente)
                {
                    Sistema.SetUsuarioLogeado(usuarioIngresado);
                    usuarioIngresado.RehacerCategorias();
                    
                    this.Hide();
                    if (usuarioIngresado.CategoriaUsuario == TiposDeUsuarios.normal)
                    {
                        //SerializadoraXML.Escribir("Backup", "backupMes.xml", usuarioIngresado.ListaDeMeses.Last());
                        SerializadoraXML serializadora = new SerializadoraXML();
                        if (usuarioIngresado.ListaDeMeses.Count != 0)
                        {
                            Generics.TrabajarArchivo("Backup", "backupMes.xml", serializadora.Escribir, usuarioIngresado.ListaDeMeses.Last());
                        }
                        FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(usuarioIngresado);
                        //Sistema.SetearConfiguracion(formMenuPrincipal);
                        dg = formMenuPrincipal.ShowDialog();
                    }
                    else
                    {                        
                        FormMenuAdmin formMenuAdmin = new FormMenuAdmin();
                        Sistema.SetearConfiguracion(formMenuAdmin);
                        dg = formMenuAdmin.ShowDialog();
                    }

                    if (dg == DialogResult.OK)
                    {
                        finalizado = true;
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario fue dado de baja, contactar con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else
            {
                if (contador != 0 )
                {
                    MessageBox.Show($"Error en el usuario y/o contraseña, reingrese.\n Le quedan {contador} intentos.", "Incorrecto",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Contraseña.Text = "";
                    contador--;                  
                    btn.Click += btn_Ingresar_Click;
                }
                else 
                {
                    this.Close();
                }
            }
        }

        private void txt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_IngresoRapido_Click(object sender, EventArgs e)
        {

            txt_Usuario.Text = "san.hilde";
            txt_Contraseña.Text = "223485san";
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg;
            if (finalizado == false)
            {
                if (contador != 0)
                {
                    dg = MessageBox.Show("¿Esta seguro que desea salir?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dg == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    MessageBox.Show("Se quedo sin intentos, el programa se finalizará", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            int x = this.Location.X + (this.Width - 350) / 2+5;
            int y = this.Location.Y + this.Height - (190 + 70);

            FormNuevoUsuario formNuevoUsuario = new FormNuevoUsuario(this, new Point(x, y));
            Sistema.SetearConfiguracion(formNuevoUsuario);
            panel.Visible = true;
            panel.Size = new Size(formNuevoUsuario.Width+2,formNuevoUsuario.Height+2);
            panel.Location = new Point((this.Width - 350) / 2+4, this.Height - (190 + 71));
            panel.BackColor = Sistema.Config.ColorContraste;

            DialogResult dg;
            dg = formNuevoUsuario.ShowDialog();
            if (dg == DialogResult.OK)
            {
                panel.Visible = false;
                Sistema.AgregarUsuario(formNuevoUsuario.UsuarioCreado);     
            } else
            {
                panel.Visible = false;
            }
            
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            panel.Visible=false;
            btn_CrearUsuario = Grafica.SetearBoton(btn_CrearUsuario);
            btn_Ingresar = Grafica.SetearBoton(btn_Ingresar);
            btn_IngresoRapido = Grafica.SetearBoton(btn_IngresoRapido);
            btn_Cancelar = Grafica.SetearBoton(btn_Cancelar);
        }

    }
}
