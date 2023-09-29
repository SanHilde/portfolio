using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Usuario;

namespace Interfaz
{
    public sealed partial class FormEditarUsuario : FormHeredable
    {
        static List<string>listaDeUsuarios;
        Usuario usuarioEditado;
        static Point ubicacion;
        //int respuesta;
        //int index;

        public Usuario UsuarioEditado
        {
            get
            {
                return this.usuarioEditado;
            }
            set
            {
                this.usuarioEditado = value;
            }
        }
        /*public int Index
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
            }
        }*/
        /*public int Respuesta
        {
            get
            {
                return this.respuesta;
            }
            set
            {
                this.respuesta = value;
            }
        }*/

        public FormEditarUsuario(Form formPadreTraido, Point ubicacionTraida)
        { 
            InitializeComponent();
            EditarBotones("Guardar Edicion", "Cancelar Edicion", "Eliminar Usuario");
            listaDeUsuarios = Sistema.ListaUsuarios;
            ubicacion = ubicacionTraida;
            
        }

        private async void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            DesactivarBarra();
            cbo_Usuarios.Items.Clear();
            foreach (string usuarios in listaDeUsuarios)
            {
                cbo_Usuarios.Items.Add(usuarios);
            }
            Location = ubicacion;
            cbo_TipoDeUsuario.DataSource = Enum.GetValues(typeof(TiposDeUsuarios));
            cbo_Estado.DataSource = Enum.GetValues(typeof(TipoDeEstado));
            usuarioEditado = await Sistema.BuscarUsuario(cbo_Usuarios.Text);
            
        }

        public override void btn_GuardarYContinuar_Click(object sender, EventArgs e)//en realidad edita el usuario
        {
            //if (EditarUsuario()==1)
            //{
            EditarUsuario();
            base.btn_GuardarYContinuar_Click(sender, e);
            
            /*} else
            {
                base.btn_Salir_Click(sender, e);
            }*/
        }

        public override void btn_GuardarYSalir_Click(object sender, EventArgs e) //en realida cancela
        {
            base.btn_Salir_Click(sender, e);
        }

        public override void btn_Salir_Click(object sender, EventArgs e) //en realidad elimina el usuario
        {

            //if (EditarUsuario()==1)
            //EditarUsuario();
            //{
            usuarioEditado.Estado = TipoDeEstado.Baja;
                base.btn_GuardarYSalir_Click(sender, e);
           /* }
            else
            {
                MessageBox.Show("Error al crear el gasto, este ultimo no se guardará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Salir_Click(sender, e);
            }*/
        }

        private async void cbo_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index;
            //index = cbo_Usuarios.SelectedIndex;
            usuarioEditado = await Sistema.BuscarUsuario(cbo_Usuarios.Text);
            if (usuarioEditado != null)
            {
                txt_Contraseña.Text = usuarioEditado.Constraseña;
                txt_ContraseñaRepetida.Text = txt_Contraseña.Text;
                txt_Nombre.Text = usuarioEditado.NombreDeUsuario;
                txt_NuevoUsuario.Text = usuarioEditado.UsuarioRegistrado;
                cbo_TipoDeUsuario.SelectedIndex = (int)usuarioEditado.CategoriaUsuario;
                cbo_Estado.SelectedIndex = (int)usuarioEditado.Estado;
            }
        }
        private void EditarUsuario()
        {
           // int resultado;
           // int index;
            TiposDeUsuarios tipoUsuario;
            TipoDeEstado tipoEstado;
            //Usuario usuarioAEditar;
            
            //Usuario usuarioEditado = new Usuario(txt_NuevoUsuario.Text, txt_Contraseña.Text, txt_Nombre.Text, tipoUsuario);
            //this.UsuarioEditado = usuarioEditado;
            //index = cbo_Usuarios.SelectedIndex;

            //listaDeUsuarios[index] = usuarioEditado;
            
            //if (listaDeUsuarios[index] == usuarioEditado.)
            if (txt_Contraseña.Text==txt_ContraseñaRepetida.Text)
            {
                tipoUsuario = (TiposDeUsuarios)Enum.ToObject(typeof(TiposDeUsuarios), cbo_TipoDeUsuario.SelectedIndex);
                tipoEstado = (TipoDeEstado)Enum.ToObject(typeof(TipoDeEstado), cbo_Estado.SelectedIndex);
                usuarioEditado.NombreDeUsuario = txt_Nombre.Text;
                usuarioEditado.Constraseña = txt_Contraseña.Text;
                usuarioEditado.CategoriaUsuario = tipoUsuario;
                usuarioEditado.NombreDeUsuario = txt_Nombre.Text;
                usuarioEditado.Estado = tipoEstado;
                //this.UsuarioEditado = usuarioAEditar;
                //await Sistema.GuardarDatos(usuarioAEditar);
                //Index = index;
                //this.respuesta = 1;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.respuesta = 0;
            }
            //return resultado;
        }


    }
}
