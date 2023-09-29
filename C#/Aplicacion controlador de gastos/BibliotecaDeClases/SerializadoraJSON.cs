using Google.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraJSON :ISerializable
    {
        public SerializadoraJSON() { }
       /* public static void Escribir(string carpeta, string nombreArchivo, Configuracion miConfig)
        {
            string ruta = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\{carpeta}"));
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
                string archivo = Path.Combine(ruta, nombreArchivo);
                string json = JsonConvert.SerializeObject(miConfig, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(archivo, json);

            }
            catch (IOException)
            {
                MessageBox.Show($"El archivo {nombreArchivo} está en uso por otro proceso.\nPor favor, cierre el archivo y vuelva a intentarlo.");
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al intentar escribir el archivo, contactese con el proveedor.");
            }
        }
        public static Configuracion Leer(string carpeta, string nombreArchivo)
        {
            string ruta = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\{carpeta}"));
            string archivo = Path.Combine(ruta, nombreArchivo);
            Configuracion confGraf;
            try
            {   
                string json = File.ReadAllText(archivo);
                confGraf = (JsonConvert.DeserializeObject<Configuracion>(json));
            }
            catch (Exception)
            {
                confGraf = null;
            }
            return confGraf;
        }*/

        public T Escribir<T>(string ruta, T miConfig)
        {         
                string json = JsonConvert.SerializeObject(miConfig, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(ruta, json);
            return miConfig;
        }
        public T Leer<T>(string ruta, T miConfig)
        {
            T confGraf;
            //try
            //{
                string json = File.ReadAllText(ruta);
                confGraf = (JsonConvert.DeserializeObject<T>(json));
            //}
            //catch (Exception)
            //{
              //  confGraf = null;
            //}
            return confGraf;
        }

    }
}
