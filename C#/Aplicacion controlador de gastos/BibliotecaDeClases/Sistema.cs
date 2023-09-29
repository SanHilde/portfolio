using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;
using static Entidades.Usuario;
using static Entidades.Configuracion;


namespace Entidades
{
    public static class Sistema
    {
        private static List<string> listaUsuarios;
        private static Usuario usuarioLogeado;
       // private static TipoDeBase baseDeDatos;
        private static Configuracion config;

        public static Usuario UsuarioLogeado
        {
            get
            {
                return usuarioLogeado;
            }
        }
        public static List<string> ListaUsuarios
        {
            get 
            {
                return listaUsuarios;
            }
        }

        public static Configuracion Config 
        { 
            get
            {
                return config;
            }
            set
            {
                config = value;
            }
        }

        /*enum TipoDeBase
        {
        FireBase,
        MySQL
        }*/

        static Sistema()
        {
            listaUsuarios = new List<string>();
            //baseDeDatos= TipoDeBase.FireBase;
            //AgregarUsuario();
            //config = SerializadoraJSON.Leer("Configuracion", "config.json");
            SerializadoraJSON serializadora = new SerializadoraJSON();
            config = Generics.TrabajarArchivo("Configuracion", "config.json", serializadora.Leer, config);
            if (config == null)
            {
                config = new Configuracion();
            }
        }

        public static void SetUsuarioLogeado (Usuario usuarioPasado)
        {
            usuarioLogeado = usuarioPasado;
            if (TipoDeBase.FireBase == config.BaseDeDatos)
            {
                listaUsuarios = Firebase.ListaDeUsuarios;
            } else
            {
                listaUsuarios = SQL_database.ListaDeUsuarios;
            }

            
        }
        private static void AgregarUsuario ()
        {
            //DatosHardcode datosHardcode = new DatosHardcode();
        }

        public static async void AgregarUsuario(Usuario usuarioCreado)
        {
            //listaUsuarios.Add(usuarioCreado);
            //   await Firebase.Agregar(DatosHardcode.UsuarioUno);
            if (config.BaseDeDatos == TipoDeBase.FireBase)
            {
                await Firebase.Agregar(usuarioCreado);
            }
            else
            {
                SQL_database.Agregar(usuarioCreado);
            }
            //      await Firebase.Agregar(DatosHardcode.UsuarioTres);

        }

       /* public static bool ValidarUsuario (string usuarioIngresado, string contraseñaIngresada, out Usuario usuarioLogeado)
        {
            bool respuesta=false;
            usuarioLogeado=null;

            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.ValidarUsuario(usuarioIngresado, contraseñaIngresada))
                {
                    respuesta = true;
                    usuarioLogeado = usuario;
                    break;
                }
            }
            return respuesta;
        }*/
        public static bool ValidarCuenta(string usuarioIngresado)
        {
            bool respuesta = false;

            foreach (string usuario in listaUsuarios)
            {
                //if (usuario.ValidarUsuario(usuarioIngresado))
                if (usuario == usuarioIngresado)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        //public static bool GuardarDatos(Usuario usuarioPasado, Mes mesPasado, List<string> listaDeCategorias)
        public static async Task<Usuario> GuardarDatos(Usuario usuarioPasado, Mes mesPasado, List<string> listaDeCategorias)
        {
            //bool resultado = false;
            Usuario usuarioActualizado=null;
            usuarioPasado.ListaDeCategorias = listaDeCategorias;
            usuarioPasado.ActualizarMes(mesPasado);
            usuarioActualizado = await Firebase.Actualizar(usuarioPasado);
            SQL_database.GuardarDatos(usuarioPasado);


            /*for (int i=0; i<= ListaUsuarios.Count-1; i++)
            {
                if (ListaUsuarios[i].UsuarioRegistrado == usuarioLogeado.UsuarioRegistrado)
                {
                    //listaUsuarios[i] = usuarioPasado;
                    
                    //resultado= true;
                }
            }*/
            return usuarioActualizado;
            //return resultado;
        }
        public static async Task<Usuario> GuardarDatos(Usuario usuarioPasado)
        {
            //bool resultado = false;
            Usuario usuarioActualizado = null;

            usuarioActualizado = await Firebase.Actualizar(usuarioPasado);
            SQL_database.GuardarDatos(usuarioPasado);
            return usuarioActualizado;
            //return resultado;
        }

        public static void EscribirArchivo (string carpeta, string nombreArchivo, string textoAEscribir)
        {
            string ruta = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\{carpeta}\"));
            if (carpeta == "Datos exportados")
            {
                ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{carpeta}\";
            }
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter sw = new StreamWriter(ruta + nombreArchivo, true))
                {
                    sw.WriteLine(DateTime.Now + " " + textoAEscribir);
                }
            } catch (IOException)
            {
               MessageBox.Show($"El archivo {nombreArchivo} está en uso por otro proceso.\nPor favor, cierre el archivo y vuelva a intentarlo.");
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al intentar escribir el archivo, contactese con el proveedor.");
            }
        }


        public static async Task<Usuario> BuscarUsuario(string usuario, string contraseña)
        {
            Usuario respuesta;
            if (TipoDeBase.FireBase == config.BaseDeDatos)
            {
                respuesta= await Firebase.Traer(usuario, contraseña);

            } else
            {
                respuesta = SQL_database.Traer(usuario,contraseña);
                if (respuesta != null)
                {
                    SQL_database.ActualizarDatos(respuesta);
                    await Firebase.Traer(usuario, contraseña);
                }
            }
            return respuesta;
        }

        public static async Task<Usuario> BuscarUsuario(string usuario)
        {
            Usuario respuesta;
            if (TipoDeBase.FireBase == config.BaseDeDatos)
            {
                respuesta = await Firebase.Traer(usuario);
            }
            else
            {
                respuesta = SQL_database.Traer(usuario);
                if (respuesta != null)
                {
                    SQL_database.ActualizarDatos(respuesta);
                }
            }
            return respuesta;
        }
        public static void SetearConfiguracion(Form formASetear)
        {
            formASetear.BackColor = config.ColorSeleccionVentana;

            foreach (Control control in formASetear.Controls)
            {
                if (control is Button || control is PictureBox)
                {
                    control.ForeColor = config.ColorContraste;
                }
                else
                {
                    control.ForeColor = config.ColorContraste;
                    control.BackColor = config.ColorSeleccionVentana;

                    if (control is ComboBox comboBox)
                    {
                        comboBox.Height = 25;
                        //comboBox.ForeColor = config.ColorPrincipal;
                        comboBox.FlatStyle = FlatStyle.Flat;
                        //    comboBox.BackColor = config.ColorContraste;

                    }
                    if (control is GroupBox groupBox)
                    {
                        groupBox.Controls[0].ForeColor = config.ColorContraste;
                        groupBox.Controls[1].ForeColor = config.ColorContraste;
                    }


                   /* if (control is DateTimePicker dateTime)
                    {
                        dateTime.CalendarMonthBackground = config.ColorSeleccionVentana;
                        dateTime.CalendarForeColor = config.ColorContraste;
                        dateTime.CalendarTitleForeColor = config.ColorContraste;     
                        dateTime.BackColor = config.ColorSeleccionVentana;
                        dateTime.ForeColor = Config.ColorContraste;
                    }*/
                    
                    if (control is TextBox textBox)
                    {
                        //textBox.ForeColor = config.ColorPrincipal;
                        textBox.BorderStyle = BorderStyle.Fixed3D;
                    //    textBox.BackColor = config.ColorContraste;
                    }/*
                    if (control is CheckedListBox checkedListBox)
                    {
                        checkedListBox.ForeColor = config.ColorPrincipal;
                        checkedListBox.BorderStyle = BorderStyle.FixedSingle;
                        //checkedListBox.BackColor = config.ColorContraste;
                    }*/
                    //if (control is Date)
                }
            }
        }

    }
}
