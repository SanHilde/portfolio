using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class SerializadoraTXT: ISerializable
    { 
        public SerializadoraTXT() 
        {
        
        } 
    
        public T Escribir<T>(string ruta, T miObjeto)
        {
            using (StreamWriter sw = new StreamWriter(ruta, true))
            {
                sw.WriteLine(DateTime.Now + "\n" + miObjeto);
            }
            return miObjeto;
        }
        public T Leer<T>(string ruta, T miObjeto)
        {
            using (StreamReader sr = new StreamReader(ruta))
            {
                string contenido = sr.ReadToEnd();
                miObjeto = (T)(object)contenido;
            }
            return miObjeto;
        }
    }
}
