using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public sealed partial class FormEditarCategorias : FormHeredableDosBotones
    {
        private List<string> listaDeCategorias;
        string categoriaVieja;
        string categoriaNueva;
        static FormMenuPrincipal formPadre;


        public FormEditarCategorias(List<string> listaDeCategoriasTraida, FormMenuPrincipal formTraido) : base (280)
        {
            InitializeComponent();
            ListaDeCategorias = listaDeCategoriasTraida;
            formPadre = formTraido;
            
        }

        public List<string> ListaDeCategorias 
        {
            get
            {
                return listaDeCategorias;
            } 
            set
            {
                listaDeCategorias = value;
            }
        }

        public string CategoriaVieja
        {
            get
            {
                return this.categoriaVieja;
            }
        }
        public string CategoriaNueva
        {
            get
            {
                return this.categoriaNueva;
            }
        }

        public override void btn_Guardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show($"¿Estas seguro que deseas cambiar '{cbo_CategoriaActual.Text}' por '{txt_CategoriaEditada.Text}'?","Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (resultado == DialogResult.Yes)
            {
                listaDeCategorias[cbo_CategoriaActual.SelectedIndex] = txt_CategoriaEditada.Text;
                this.categoriaVieja = cbo_CategoriaActual.Text;
                this.categoriaNueva = txt_CategoriaEditada.Text;
                //cbo_CategoriaActual.SelectedItem;
                base.btn_Guardar_Click (sender, e);
            }
        }

        private void FormEditarCategorias_Load(object sender, EventArgs e)
        {
            //Grafica.PonerFormato(btn_Guardar, btn_Cancelar, this, formPadre);
            //pic_BarraLateral.Height = this.Height;
            Grafica.UbicacionDeForm(this, formPadre);
            
            cbo_CategoriaActual.DataSource = ListaDeCategorias;  
        }

        public override void btn_Cancelar_Click(object sender, EventArgs e)
        {
            base.btn_Cancelar_Click(sender, e);
        }
    }
}
