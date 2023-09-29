using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public sealed partial class FormNuevoObjetivoAhorro : FormHeredableDosBotones
    {
        int objetivoNuevo;
        int limite;
        double sueldoCobrado;

        FormMenuPrincipal formPadre;
        public FormNuevoObjetivoAhorro(FormMenuPrincipal formPadreTraido) : base (280)
        {
            InitializeComponent();
            this.formPadre = formPadreTraido;
            this.limite = 100;
        }
        public FormNuevoObjetivoAhorro(FormMenuPrincipal formPadreTraido, string label, string simbolo) : base(280)
        {
            InitializeComponent();
            this.formPadre = formPadreTraido;
            lbl_NuevoObjetivo.Text = label;
            lbl_Porcentaje.Text = simbolo;
            this.limite = -1;
        }

        public int ObjetivoNuevo
        {
            get
            {
                return this.objetivoNuevo;
            }

        }

        public double SueldoCobrado { get => sueldoCobrado; set => sueldoCobrado = value; }

        public override void btn_Guardar_Click(object sender, EventArgs e)
        {
            float nuevoObjetivo;
            try
            {
                if (this.limite == -1)
                {
                    nuevoObjetivo = float.Parse(txt_NuevoObjetivo.Text);
                }
                else
                { 
                    nuevoObjetivo = NumeroMayorExcepcion.ComprobarNumeroMayorExcepcion((int)(float.Parse(txt_NuevoObjetivo.Text)), this.limite, lbl_NuevoObjetivo.Text);
                }
                DialogResult resultado = MessageBox.Show($"¿Estas seguro que deseas cambiar el valor por {lbl_Porcentaje.Text}{nuevoObjetivo}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.objetivoNuevo = (int) nuevoObjetivo;
                    base.btn_Guardar_Click(sender, e);
                }
            } catch (NumeroMayorExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FormatException)
            {
                MessageBox.Show($"No ingreso un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                try
                {
                    SerializadoraTXT serializadora = new SerializadoraTXT();
                    string textoAEscribir = $"Clase: FormNuevoObjetivoDeAhorro\nMetodo: btn_Guardar_Click\nError: {ex.Message}\n";
                    Generics.TrabajarArchivo("Errores", "ErrorAlEditarObjetivo.txt", serializadora.Escribir, textoAEscribir);
                    //Sistema.EscribirArchivo(@"Errores", "ErrorAlCambiarObjAhorro.txt", $"Clase: FormNuevoConsumo\n, Metodo: CrearGasto\nError: {ex.Message}");
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormNuevoObjetivoAhorro_Load(object sender, EventArgs e)
        {
            Grafica.UbicacionDeForm(this, formPadre);
            if (lbl_Porcentaje.Text == "%")
            {
                lbl_Peso.Visible = true;
                txt_ObjetivoNeto.Visible = true;
            }
        }

        public override void btn_Cancelar_Click(object sender, EventArgs e)
        {
            base.btn_Cancelar_Click(sender, e);
        }

        private void txt_NuevoObjetivo_TextChanged(object sender, EventArgs e)
        {
            int nuevoObjetivo = 0;
            if (int.TryParse(txt_NuevoObjetivo.Text, out nuevoObjetivo))
            {
                txt_ObjetivoNeto.Text = $"{SueldoCobrado * objetivoNuevo / 100}";
            }
        }

        private void txt_ObjetivoNeto_TextChanged(object sender, EventArgs e)
        {
            int nuevoObjetivo =0 ;
            if (int.TryParse(txt_ObjetivoNeto.Text,out nuevoObjetivo))
            {
                txt_NuevoObjetivo.Text = $"{nuevoObjetivo * 100 / SueldoCobrado}";
            }
            
        }
    }
}
