using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Usuario;
using static System.Net.Mime.MediaTypeNames;

namespace Interfaz
{
    public partial class FormMenuAdmin : Form
    {
        static List<string> listaDeUsuarios;
        static Dictionary<string, double> consumosPorTipo;


        public FormMenuAdmin()
        {
            InitializeComponent();
            listaDeUsuarios = Sistema.ListaUsuarios;
            consumosPorTipo = new Dictionary<string, double>()
            {
                { "Consumos esporadicos", 0 },
                { "Consumos volatiles", 0 },
                { "Consumos fijos", 0 }
            };
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            int x = Location.X + menu_Admin.Width + 10;
            int y = Location.Y + 35;
            FormNuevoUsuario formNuevoUsuario = new FormNuevoUsuario(this, new Point(x, y));
            Sistema.SetearConfiguracion(formNuevoUsuario);
            dg = formNuevoUsuario.ShowDialog();
            if (dg == DialogResult.OK)
            {
                Usuario usuarioAdmin = new Usuario(formNuevoUsuario.UsuarioCreado.UsuarioRegistrado, formNuevoUsuario.UsuarioCreado.Constraseña, formNuevoUsuario.UsuarioCreado.NombreDeUsuario, TiposDeUsuarios.admin);
                Sistema.AgregarUsuario(usuarioAdmin);
            }
        }

        private async void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Location.X + menu_Admin.Width + 45;
            int y = Location.Y + 35;
            FormEditarUsuario formEditarUsuario = new FormEditarUsuario(this, new Point(x, y));
            Sistema.SetearConfiguracion(formEditarUsuario);
            DialogResult dg;
            dg = formEditarUsuario.ShowDialog();
            /*if (dg == DialogResult.OK && formEditarUsuario.Eleccion == 1)
            {
                //listaDeUsuarios[formEditarUsuario.Index] = formEditarUsuario.UsuarioEditado;
                await Sistema.GuardarDatos(formEditarUsuario.UsuarioEditado);
                datosGuardados = false;
            }
            else
            {
                if (dg == DialogResult.OK && formEditarUsuario.Eleccion == 0)
                {
                    //listaDeUsuarios.Remove(formEditarUsuario.UsuarioEditado);
                    datosGuardados = false;
                }
            }*/
            if (dg == DialogResult.OK )
            {
                await Sistema.GuardarDatos(formEditarUsuario.UsuarioEditado);
            }
        }

        private void FormMenuAdmin_Load(object sender, EventArgs e)
        {
            Grafica.SetearMenuStrip(menu_Admin, this, false);
            menu_Admin.BackColor = Sistema.Config.ColorPrincipal;
            MdiClient mdiClient=null;
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    mdiClient = (MdiClient)control;
                    mdiClient.BackColor = Sistema.Config.ColorSeleccionVentana;
                    //mdiClient.AutoScroll = false;
                    mdiClient.AutoSize = false;
                    mdiClient.Dock = DockStyle.Fill;
                    break;
                }
            }
            Task tarea = new Task(CalcularTodosLosDatos);
            tarea.Start();
        }

        private void FormMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = DialogResult.No;
            dg = MessageBox.Show("¿Esta seguro que desea salir?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void todosLosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int x = Location.X + menu_Admin.Width + 15;
            //int y = Location.Y + 35;

            //FormGraficos formGraficos = new FormGraficos(this, new Point(x, y), consumosPorTipo, "Consumos de todos los usuarios por tipo");
            FormGraficos formGraficos = new FormGraficos(this, new Point(0, 0), consumosPorTipo, "Consumos de todos los usuarios por tipo");

            //formGraficos.Owner = this;
            formGraficos.MdiParent = this;
            Sistema.SetearConfiguracion(formGraficos);
            formGraficos.Show();
        }
        private void AdicionarGasto (Consumo consumo, string key)
        {
            consumosPorTipo[key] = consumosPorTipo[key] + consumo.Monto;
        }
        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.Config.BaseDeDatos = Configuracion.TipoDeBase.MySQL;
            //SerializadoraJSON.Escribir("Configuracion", "config.json", Sistema.Config);
            SerializadoraJSON serializadora = new SerializadoraJSON();
            Generics.TrabajarArchivo("Configuracion", "config.json", serializadora.Escribir, Sistema.Config);
        }

        private void fireBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sistema.Config.BaseDeDatos = Configuracion.TipoDeBase.FireBase;
            //SerializadoraJSON.Escribir("Configuracion", "config.json", Sistema.Config);
            SerializadoraJSON serializadora = new SerializadoraJSON();
            Generics.TrabajarArchivo("Configuracion", "config.json", serializadora.Escribir, Sistema.Config);
        }
        private async void CalcularTodosLosDatos()
        {
            foreach (string usuarioString in listaDeUsuarios)
            {
                Mes mesActual;
                Usuario usuario = await Sistema.BuscarUsuario(usuarioString);
                if (usuario.CategoriaUsuario == TiposDeUsuarios.normal)
                {
                    for (int i = 0; i <= usuario.ListaDeMeses.Count() - 1; i++)
                    {
                        mesActual = usuario.ListaDeMeses[i];
                        Generics.RecorrerListaConFiltroBool(mesActual.ListaConsumosVolatiles, Generics.FiltroPago, AdicionarGasto, "Consumos volatiles");
                        Generics.RecorrerListaConFiltroBool(mesActual.ListaConsumosEsporadicos, Generics.FiltroPago, AdicionarGasto, "Consumos esporadicos");
                        Generics.RecorrerListaConFiltroBool(mesActual.ListaConsumosFijos, Generics.FiltroPago, AdicionarGasto, "Consumos fijos");
                    }
                }
            }
            Thread.Sleep(5000);
            MessageBox.Show("Termine");
        }
    }
}
