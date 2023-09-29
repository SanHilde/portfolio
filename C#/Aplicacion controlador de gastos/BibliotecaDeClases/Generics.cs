using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public static class Generics
    {
        public delegate bool MiFiltroDelegado<T, U>(T item, U comparacion, U segundaComparacion, U segundoItem) where T : IConsumible; 
        public static void RecorrerListaConFiltroString<T,U,V> (List<T> lista, Func <T,U,bool> filtro, Action<T, V> metodoARealizar, U comparacion, V actualizacion)
        { 
            
            foreach ( T item in lista ) 
            {
                if (filtro(item, comparacion) == true)              
                {
                    metodoARealizar(item,actualizacion);
                }
            }
        }
        public static void RecorrerListaConFiltroString<T, U, V>(List<T> lista, Func<T, U, bool> filtro, Action<T, V, List<T>> metodoARealizar, U comparacion, V actualizacion)
        {

            foreach (T item in lista)
            {
                if (filtro(item, comparacion) == true)
                {
                    metodoARealizar(item, actualizacion,lista);
                }
            }
        }
        public static bool RecorrerListaConFiltroString<T, U>(List<T> lista, Func<T, U, bool> filtro, U comparacion)
        {
            bool respuesta = false;
            foreach (T item in lista)
            {
                if (filtro(item, comparacion) == true)
                {
                    respuesta = true;
                    break;
                }
            }
            return respuesta;
        }
        public static void RecorrerListaConFiltroString<T, U>(List<T> lista, Func<T, U, bool> filtro, Action<T> metodoARealizar, U comparacion)
        {

            foreach (T item in lista)
            {
                if (filtro(item, comparacion) == true)
                {
                    metodoARealizar(item);
                }
            }
        }
        public static void RecorrerListaConDobleFiltroString<T,U>(List<T> lista, MiFiltroDelegado<T, U> filtro, Action<T,U> metodoARealizar, U comparacion, U segundaComparacion, U segundoItem) where T: IConsumible
        {

            foreach (T item in lista)
            {
                if (filtro(item, comparacion,segundaComparacion, segundoItem) == true)
                {
                    metodoARealizar(item,segundaComparacion);
                }
            }
        }
        public static void RecorrerListaConFiltroInt<T, U>(List<T> lista, Func<T, U, bool> filtro, Action<T,List<T>> metodoARealizar, U comparacion)
        {

            foreach (T item in lista)
            {
                if (filtro(item, comparacion) == true)
                {
                    metodoARealizar(item, lista);
                    break;
                }
            }
        }
        public static void RecorrerListaConFiltroInt<T>(List<T> lista, Func<T, int, bool> filtro, Action<T,int> metodoARealizar)
        {
            int contador=0;
            foreach (T item in lista)
            {
                contador++;
                if (filtro(item, contador) == false)
                {
                    metodoARealizar(item, contador);
                }
            }
        }
        public static void RecorrerListaConFiltroBool<T, V>(List<T> lista, Func<T, bool> filtro, Action<T, V> metodoARealizar, V actualizacion)
        {
            foreach (T item in lista)
            {
                if (filtro(item) == true)
                {
                    metodoARealizar(item, actualizacion);
                }
            }
        }
        public static bool FiltroCategoria(Consumo consumo, string filtro)
        {
            return consumo.Categoria == filtro;
        }
        public static bool FiltroNombre(Consumo consumo, string filtro)
        {
            string descripcion = $"{consumo.Id}-{consumo.Nombre}";
            return descripcion == filtro;
        }
        public static bool FiltroPago(Consumo consumo)
        {
            return consumo.PagoRealizado == true;
        }

        public static bool FiltroId(Consumo consumo, int filtro)
        {
            return consumo.Id == filtro;
        }
        public static bool FiltroId(IConsumible consumo, int filtro)
        {
            return consumo.Id == filtro;
        }

        public static T TrabajarArchivo<T>(string carpeta, string nombreArchivo, Func<string,T,T> metodoARealizar, T objeto)
        {
            T retorno = default(T);
            string rutaCompleta;
            try
            {     
                string ruta;
                if (carpeta == "Datos exportados")
                {
                    ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\{carpeta}\";
                }
                else
                {
                    ruta = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\{carpeta}"));
                }
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                rutaCompleta = Path.Combine(ruta, nombreArchivo);
                retorno =metodoARealizar(rutaCompleta, objeto);//aca deberia hacer un try? Dentro de esta funcion
                return retorno;
            }
            catch (FileNotFoundException)
            {
                //retorno = default(T);
                return retorno;
            }
            catch (IOException)
            {
                MessageBox.Show($"El archivo {nombreArchivo} está en uso por otro proceso.\nPor favor, cierre el archivo y vuelva a intentarlo.");
                //retorno = default(T); // Asignar valor predeterminado
                return retorno;
            }
            catch (Exception)
            {
                throw new Exception("Hubo un problema al intentar trabajar el archivo, contactese con el proveedor.");
            }
        }

    }
}
