using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Interfaz.FormMenuPrincipal;

namespace Interfaz
{
    public sealed partial class FormNuevoPago : FormHeredable
    {
        static Mes mesActual;
       // static Usuario usuarioLogeado;
        int banderaConsumo;
        int banderaCategorias;
        static FormMenuPrincipal formPadre;

        public int BanderaConsumo
        {
            get
            {
                return this.banderaConsumo;
            }
        }
        public int BanderaCategorias
        {
            get
            {
                return this.banderaCategorias;
            }
        }


        public FormNuevoPago(Usuario usuarioLogeado, Mes mesActualPasado, List<string> listaDeCategorias, FormMenuPrincipal formPadreTraido) : base(210)//creo que no es necesario el usuario
        {

            mesActual = mesActualPasado;
            InitializeComponent();
            cbo_Consumo.DataSource = Enum.GetValues(typeof(Usuario.TiposDeGastos)).Cast<Usuario.TiposDeGastos>().ToList();
            cbo_Categorias.DataSource = listaDeCategorias;
            formPadre = formPadreTraido;

        }

        private void SetBanderas(int banderaConsumo, int banderaCategorias)
        {
            this.banderaConsumo = banderaConsumo;
            this.banderaCategorias = banderaCategorias;
        }
        private void CargaDeValores (string categoria, string nombre, string monto, int id, int banderaInterna)
        {
            if (categoria == cbo_Categorias.Text && banderaInterna == 1)
            {
                cbo_Descripcion.Items.Add($"{id}-{nombre}");
            }
            if (($"{id}-{nombre}") == cbo_Descripcion.Text)
            {
                lbl_MontoCargado.Text = "$" + monto;
            }
        }

        private void CargaDeComboBox ()
        {
            int banderaInterna = 0;

            if (cbo_Consumo.SelectedIndex != BanderaConsumo || cbo_Categorias.SelectedIndex !=BanderaCategorias)
            {
                lbl_MontoCargado.Text = "";
                cbo_Descripcion.Items.Clear();
                banderaInterna = 1;
            }

            switch (cbo_Consumo.SelectedIndex)
            {
                case 0://fijo
                    foreach (ConsumoFijo consumo in mesActual.ListaConsumosFijos)
                    {
                        CargaDeValores(consumo.Categoria, consumo.Nombre, consumo.Monto.ToString(), consumo.Id, banderaInterna);
                    }
                    SetBanderas(cbo_Consumo.SelectedIndex, cbo_Categorias.SelectedIndex);
                    break;
                case 1:
                    foreach (ConsumoVolatil consumo in mesActual.ListaConsumosVolatiles)
                    {
                        CargaDeValores(consumo.Categoria, consumo.Nombre, consumo.Monto.ToString(), consumo.Id, banderaInterna);
                    }
                    SetBanderas(cbo_Consumo.SelectedIndex, cbo_Categorias.SelectedIndex);
                    break;
                case 2://esporadico                   
                    foreach (Consumo consumo in mesActual.ListaConsumosEsporadicos)
                    {
                        CargaDeValores(consumo.Categoria, consumo.Nombre, consumo.Monto.ToString(), consumo.Id, banderaInterna);
                    }
                    SetBanderas(cbo_Consumo.SelectedIndex, cbo_Categorias.SelectedIndex);
                    break;
            }
        }

        private void cbo_Consumo_SelectedIndexChanged(object sender, EventArgs e)
        {  
            CargaDeComboBox();
        }

        private void cbo_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaDeComboBox();
        }

        private void cbo_Descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaDeComboBox();
        }

        private bool GuardarPago ()
        {
            bool respuesta= false;
            if (rad_Pagado.Checked == true)
            {
                respuesta= SetPago(true);
            } else
            {
                respuesta = SetPago(false);
            }
            return respuesta;
        }
        private bool SetPago (bool pago)
        {
            bool respuesta = false;
            switch (cbo_Consumo.SelectedIndex)
            {
                case 0://fijo
                    foreach (ConsumoFijo consumo in mesActual.ListaConsumosFijos)
                    {
                        if (cbo_Descripcion.Text == ($"{consumo.Id}-{consumo.Nombre}"))
                        {
                            consumo.PagoRealizado = pago;
                            respuesta = true;
                        }
                    }
                    break;
                case 1:
                    foreach (ConsumoVolatil consumo in mesActual.ListaConsumosVolatiles)
                    {
                        if (cbo_Descripcion.Text == ($"{consumo.Id}-{consumo.Nombre}"))
                        {
                            consumo.PagoRealizado = pago;
                            respuesta = true;
                        }
                    }
                    break;
                case 2://esporadico                   
                    foreach (Consumo consumo in mesActual.ListaConsumosEsporadicos)
                    {
                        if (cbo_Descripcion.Text == ($"{consumo.Id}-{consumo.Nombre}"))
                        {
                            consumo.PagoRealizado = pago;
                            respuesta = true;
                        }
                    }
                    break;
            }
            return respuesta;
        }


        public override void btn_GuardarYContinuar_Click(object sender, EventArgs e)
        {
            if (GuardarPago())
            {
                base.btn_GuardarYContinuar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error al guardar el pago, este ultimo no se guardará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Salir_Click(sender, e);
            }
        }

        public override void btn_GuardarYSalir_Click(object sender, EventArgs e)
        {
            if (GuardarPago())
            {
                base.btn_GuardarYSalir_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error al guardar el pago, este ultimo no se guardará.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Salir_Click(sender, e);
            }

        }

        public override void btn_Salir_Click(object sender, EventArgs e)
        {
            base.btn_Salir_Click(sender, e);

        }

        private void FormNuevoPago_Load(object sender, EventArgs e)
        {
            Grafica.UbicacionDeForm(this, formPadre);
        }
    }
}
