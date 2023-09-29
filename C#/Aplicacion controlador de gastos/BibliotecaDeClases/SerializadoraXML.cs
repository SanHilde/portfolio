using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraXML:ISerializable
    {
        //Mes mes;
        public SerializadoraXML()
        {
        
        }
        public static void Escribir(string carpeta, string nombreArchivo, Mes miMes)
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
                using (StreamWriter sw = new StreamWriter(ruta + nombreArchivo, false))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Mes));
                    ser.Serialize(sw, miMes);
                }
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
        public static Mes Leer (string carpeta, string nombreArchivo)
        {
            string ruta = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\{carpeta}\{nombreArchivo}"));
            Mes lectura;
            //MessageBox.Show(ruta);
            using (StreamReader sr = new StreamReader(ruta))
            {
                XmlSerializer des = new XmlSerializer(typeof(Mes));
                lectura = (Mes)des.Deserialize(sr);
            } 
            return lectura;
        }
        public T Escribir<T>(string ruta, T miMes)
        {
            using (StreamWriter sw = new StreamWriter(ruta , false))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Mes));
                ser.Serialize(sw, miMes);
            }
            return miMes;
        }
        public T Leer<T>(string ruta, T miMes)
        {
            using (StreamReader sr = new StreamReader(ruta))
            {
                XmlSerializer des = new XmlSerializer(typeof(Mes));
                miMes = (T) des.Deserialize(sr);               
            }
            return miMes;
        }
    }
}
