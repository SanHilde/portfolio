using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Entidades
{
    public class Configuracion
    {
        //static Color[] tonosVerdes;
         Color colorPrincipal;
         Color colorIntermedio;
         Color colorContraste;
         Color colorDetalles;
         Color colorSeleccionVentana;
        string colorElegido;
        string temaElegido;
        string fondo;
        string ruta;
         TipoDeBase baseDeDatos;

        public Configuracion ()
        {
            colorPrincipal = Color.Black;
            colorIntermedio = Color.LightGray;
            colorContraste = Color.White;
            colorDetalles = Color.FromArgb(0, 153, 41);
            colorSeleccionVentana = Color.FromArgb(10, 10, 10);
            colorElegido = "verde";
            temaElegido = "oscuro";
            baseDeDatos = TipoDeBase.FireBase;
            ruta = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\Imagenes"));
            fondo = ruta+ @"\Fondo menu principal-" + colorElegido+".png";
        }

        public  Color ColorPrincipal 
        {
            get
            {
                return colorPrincipal;
            }
            set
            {
                colorPrincipal = value;
            }
        }
        public Color ColorIntermedio
        {
            get
            {
                return colorIntermedio;
            }
            set
            {
                colorIntermedio = value;
            }
        }
        public Color ColorContraste
        {
            get
            {
                return colorContraste;
            }
            set
            {
                colorContraste = value;
            }
        }
        public Color ColorDetalles
        {
            get
            {
                return colorDetalles;
            }
            set
            {
                colorDetalles = value;
            }
        }
        public Color ColorSeleccionVentana
        {
            get
            {
                return colorSeleccionVentana;
            }
            set
            {
                colorSeleccionVentana = value;
            }
        }
        public TipoDeBase BaseDeDatos
        {
            get
            {
                return baseDeDatos;
            }
            set
            {
                baseDeDatos = value;
            }
        }

        public string ColorElegido
        {
            get
            {
                return colorElegido;
            }
            set
            {
                colorElegido = value;
            }
        }
        public string TemaElegido
        {
            get
            {
                return temaElegido;
            }
            set
            {
                temaElegido = value;
            }
        }

        public string Fondo
        {
            get
            {
                return fondo;
            }
            set
            {
                fondo = value;
            }
        }
        public string Ruta
        {
            get
            {
                return ruta;
            }
            set
            {
                ruta = value;
            }
        }


        public enum TipoDeBase
        {
            FireBase,
            MySQL
        }
        public void SetearColorDetalle(Color colorDetallesTraido, string colorTraido)
        {
            colorDetalles= colorDetallesTraido;
            ColorElegido = colorTraido;
            fondo= ruta + @"\Fondo menu principal-" + colorElegido + ".png";
        }
        public void CambiarTema (string temaTraido)
        {

            if (temaTraido == "oscuro")
            {
                colorPrincipal = Color.Black;
                colorContraste = Color.White;
                colorSeleccionVentana = Color.FromArgb(10, 10, 10);
                TemaElegido = temaTraido;
                
            } else
            {
                colorSeleccionVentana = Color.FromArgb(245, 245, 245);
                TemaElegido = temaTraido;
                colorPrincipal = Color.White;
                colorContraste = Color.Black;
            }
        }
    }
}
