namespace Interfaz
{
    partial class FormNuevoMes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_InicioCiclo = new System.Windows.Forms.Label();
            this.lbl_SueldoCobrado = new System.Windows.Forms.Label();
            this.lbl_ObjetivoAhorro = new System.Windows.Forms.Label();
            this.lbl_ConsumosMensualesFijos = new System.Windows.Forms.Label();
            this.chkl_ConsumosMensualesFijos = new System.Windows.Forms.CheckedListBox();
            this.txt_InicioDeCiclo = new System.Windows.Forms.TextBox();
            this.txt_SueldoCobrado = new System.Windows.Forms.TextBox();
            this.txt_ObjetivoAhorro = new System.Windows.Forms.TextBox();
            this.lbl_Pago = new System.Windows.Forms.Label();
            this.lbl_Moneda = new System.Windows.Forms.Label();
            this.lbl_Porcentaje = new System.Windows.Forms.Label();
            this.dte_Fecha = new System.Windows.Forms.DateTimePicker();
            this.chkl_ConsumosMensualesVolatil = new System.Windows.Forms.CheckedListBox();
            this.lbl_ConsumosMensualesVolatiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha.Location = new System.Drawing.Point(10, 17);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(44, 18);
            this.lbl_Fecha.TabIndex = 0;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_InicioCiclo
            // 
            this.lbl_InicioCiclo.AutoSize = true;
            this.lbl_InicioCiclo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InicioCiclo.ForeColor = System.Drawing.Color.White;
            this.lbl_InicioCiclo.Location = new System.Drawing.Point(10, 50);
            this.lbl_InicioCiclo.Name = "lbl_InicioCiclo";
            this.lbl_InicioCiclo.Size = new System.Drawing.Size(92, 18);
            this.lbl_InicioCiclo.TabIndex = 1;
            this.lbl_InicioCiclo.Text = "Inicio de ciclo";
            // 
            // lbl_SueldoCobrado
            // 
            this.lbl_SueldoCobrado.AutoSize = true;
            this.lbl_SueldoCobrado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoCobrado.ForeColor = System.Drawing.Color.White;
            this.lbl_SueldoCobrado.Location = new System.Drawing.Point(10, 80);
            this.lbl_SueldoCobrado.Name = "lbl_SueldoCobrado";
            this.lbl_SueldoCobrado.Size = new System.Drawing.Size(107, 18);
            this.lbl_SueldoCobrado.TabIndex = 2;
            this.lbl_SueldoCobrado.Text = "Sueldo cobrado ";
            // 
            // lbl_ObjetivoAhorro
            // 
            this.lbl_ObjetivoAhorro.AutoSize = true;
            this.lbl_ObjetivoAhorro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ObjetivoAhorro.ForeColor = System.Drawing.Color.White;
            this.lbl_ObjetivoAhorro.Location = new System.Drawing.Point(10, 111);
            this.lbl_ObjetivoAhorro.Name = "lbl_ObjetivoAhorro";
            this.lbl_ObjetivoAhorro.Size = new System.Drawing.Size(106, 18);
            this.lbl_ObjetivoAhorro.TabIndex = 3;
            this.lbl_ObjetivoAhorro.Text = "Objetivo ahorro";
            // 
            // lbl_ConsumosMensualesFijos
            // 
            this.lbl_ConsumosMensualesFijos.AutoSize = true;
            this.lbl_ConsumosMensualesFijos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConsumosMensualesFijos.ForeColor = System.Drawing.Color.White;
            this.lbl_ConsumosMensualesFijos.Location = new System.Drawing.Point(10, 163);
            this.lbl_ConsumosMensualesFijos.Name = "lbl_ConsumosMensualesFijos";
            this.lbl_ConsumosMensualesFijos.Size = new System.Drawing.Size(101, 18);
            this.lbl_ConsumosMensualesFijos.TabIndex = 4;
            this.lbl_ConsumosMensualesFijos.Text = "Consumos fijos";
            // 
            // chkl_ConsumosMensualesFijos
            // 
            this.chkl_ConsumosMensualesFijos.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkl_ConsumosMensualesFijos.FormattingEnabled = true;
            this.chkl_ConsumosMensualesFijos.Location = new System.Drawing.Point(144, 163);
            this.chkl_ConsumosMensualesFijos.Name = "chkl_ConsumosMensualesFijos";
            this.chkl_ConsumosMensualesFijos.Size = new System.Drawing.Size(146, 84);
            this.chkl_ConsumosMensualesFijos.TabIndex = 5;
            this.chkl_ConsumosMensualesFijos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkl_ConsumosMensualesFijos_ItemCheck);
            // 
            // txt_InicioDeCiclo
            // 
            this.txt_InicioDeCiclo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InicioDeCiclo.Location = new System.Drawing.Point(144, 46);
            this.txt_InicioDeCiclo.Name = "txt_InicioDeCiclo";
            this.txt_InicioDeCiclo.Size = new System.Drawing.Size(146, 21);
            this.txt_InicioDeCiclo.TabIndex = 7;
            // 
            // txt_SueldoCobrado
            // 
            this.txt_SueldoCobrado.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SueldoCobrado.Location = new System.Drawing.Point(144, 76);
            this.txt_SueldoCobrado.Name = "txt_SueldoCobrado";
            this.txt_SueldoCobrado.Size = new System.Drawing.Size(146, 21);
            this.txt_SueldoCobrado.TabIndex = 8;
            // 
            // txt_ObjetivoAhorro
            // 
            this.txt_ObjetivoAhorro.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ObjetivoAhorro.Location = new System.Drawing.Point(144, 107);
            this.txt_ObjetivoAhorro.Name = "txt_ObjetivoAhorro";
            this.txt_ObjetivoAhorro.Size = new System.Drawing.Size(146, 21);
            this.txt_ObjetivoAhorro.TabIndex = 9;
            // 
            // lbl_Pago
            // 
            this.lbl_Pago.AutoSize = true;
            this.lbl_Pago.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pago.ForeColor = System.Drawing.Color.White;
            this.lbl_Pago.Location = new System.Drawing.Point(142, 144);
            this.lbl_Pago.Name = "lbl_Pago";
            this.lbl_Pago.Size = new System.Drawing.Size(46, 15);
            this.lbl_Pago.TabIndex = 10;
            this.lbl_Pago.Text = "Pagado";
            // 
            // lbl_Moneda
            // 
            this.lbl_Moneda.AutoSize = true;
            this.lbl_Moneda.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Moneda.ForeColor = System.Drawing.Color.White;
            this.lbl_Moneda.Location = new System.Drawing.Point(129, 80);
            this.lbl_Moneda.Name = "lbl_Moneda";
            this.lbl_Moneda.Size = new System.Drawing.Size(14, 15);
            this.lbl_Moneda.TabIndex = 11;
            this.lbl_Moneda.Text = "$";
            // 
            // lbl_Porcentaje
            // 
            this.lbl_Porcentaje.AutoSize = true;
            this.lbl_Porcentaje.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Porcentaje.ForeColor = System.Drawing.Color.White;
            this.lbl_Porcentaje.Location = new System.Drawing.Point(127, 111);
            this.lbl_Porcentaje.Name = "lbl_Porcentaje";
            this.lbl_Porcentaje.Size = new System.Drawing.Size(16, 15);
            this.lbl_Porcentaje.TabIndex = 12;
            this.lbl_Porcentaje.Text = "%";
            // 
            // dte_Fecha
            // 
            this.dte_Fecha.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dte_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_Fecha.Location = new System.Drawing.Point(144, 17);
            this.dte_Fecha.Name = "dte_Fecha";
            this.dte_Fecha.Size = new System.Drawing.Size(146, 21);
            this.dte_Fecha.TabIndex = 14;
            // 
            // chkl_ConsumosMensualesVolatil
            // 
            this.chkl_ConsumosMensualesVolatil.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkl_ConsumosMensualesVolatil.FormattingEnabled = true;
            this.chkl_ConsumosMensualesVolatil.Location = new System.Drawing.Point(144, 263);
            this.chkl_ConsumosMensualesVolatil.Name = "chkl_ConsumosMensualesVolatil";
            this.chkl_ConsumosMensualesVolatil.Size = new System.Drawing.Size(146, 84);
            this.chkl_ConsumosMensualesVolatil.TabIndex = 15;
            this.chkl_ConsumosMensualesVolatil.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkl_ConsumosMensualesVolatil_ItemCheck);
            // 
            // lbl_ConsumosMensualesVolatiles
            // 
            this.lbl_ConsumosMensualesVolatiles.AutoSize = true;
            this.lbl_ConsumosMensualesVolatiles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConsumosMensualesVolatiles.ForeColor = System.Drawing.Color.White;
            this.lbl_ConsumosMensualesVolatiles.Location = new System.Drawing.Point(10, 263);
            this.lbl_ConsumosMensualesVolatiles.Name = "lbl_ConsumosMensualesVolatiles";
            this.lbl_ConsumosMensualesVolatiles.Size = new System.Drawing.Size(128, 18);
            this.lbl_ConsumosMensualesVolatiles.TabIndex = 4;
            this.lbl_ConsumosMensualesVolatiles.Text = "Consumos volatiles";
            // 
            // FormNuevoMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(316, 534);
            this.Controls.Add(this.chkl_ConsumosMensualesVolatil);
            this.Controls.Add(this.dte_Fecha);
            this.Controls.Add(this.lbl_Porcentaje);
            this.Controls.Add(this.lbl_Moneda);
            this.Controls.Add(this.lbl_Pago);
            this.Controls.Add(this.txt_ObjetivoAhorro);
            this.Controls.Add(this.txt_SueldoCobrado);
            this.Controls.Add(this.txt_InicioDeCiclo);
            this.Controls.Add(this.chkl_ConsumosMensualesFijos);
            this.Controls.Add(this.lbl_ConsumosMensualesVolatiles);
            this.Controls.Add(this.lbl_ConsumosMensualesFijos);
            this.Controls.Add(this.lbl_ObjetivoAhorro);
            this.Controls.Add(this.lbl_SueldoCobrado);
            this.Controls.Add(this.lbl_InicioCiclo);
            this.Controls.Add(this.lbl_Fecha);
            this.Name = "FormNuevoMes";
            this.Text = "Crear nuevo mes";
            this.Load += new System.EventHandler(this.FormNuevoMes_Load);
            this.Controls.SetChildIndex(this.lbl_Fecha, 0);
            this.Controls.SetChildIndex(this.lbl_InicioCiclo, 0);
            this.Controls.SetChildIndex(this.lbl_SueldoCobrado, 0);
            this.Controls.SetChildIndex(this.lbl_ObjetivoAhorro, 0);
            this.Controls.SetChildIndex(this.lbl_ConsumosMensualesFijos, 0);
            this.Controls.SetChildIndex(this.lbl_ConsumosMensualesVolatiles, 0);
            this.Controls.SetChildIndex(this.chkl_ConsumosMensualesFijos, 0);
            this.Controls.SetChildIndex(this.txt_InicioDeCiclo, 0);
            this.Controls.SetChildIndex(this.txt_SueldoCobrado, 0);
            this.Controls.SetChildIndex(this.txt_ObjetivoAhorro, 0);
            this.Controls.SetChildIndex(this.lbl_Pago, 0);
            this.Controls.SetChildIndex(this.lbl_Moneda, 0);
            this.Controls.SetChildIndex(this.lbl_Porcentaje, 0);
            this.Controls.SetChildIndex(this.dte_Fecha, 0);
            this.Controls.SetChildIndex(this.chkl_ConsumosMensualesVolatil, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_InicioCiclo;
        private System.Windows.Forms.Label lbl_SueldoCobrado;
        private System.Windows.Forms.Label lbl_ObjetivoAhorro;
        private System.Windows.Forms.Label lbl_ConsumosMensualesFijos;
        private System.Windows.Forms.CheckedListBox chkl_ConsumosMensualesFijos;
        private System.Windows.Forms.TextBox txt_InicioDeCiclo;
        private System.Windows.Forms.TextBox txt_SueldoCobrado;
        private System.Windows.Forms.TextBox txt_ObjetivoAhorro;
        private System.Windows.Forms.Label lbl_Pago;
        private System.Windows.Forms.Label lbl_Moneda;
        private System.Windows.Forms.Label lbl_Porcentaje;
        private System.Windows.Forms.DateTimePicker dte_Fecha;
        private System.Windows.Forms.CheckedListBox chkl_ConsumosMensualesVolatil;
        private System.Windows.Forms.Label lbl_ConsumosMensualesVolatiles;
    }
}