namespace Interfaz
{
    partial class FormNuevoConsumo
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
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.lbl_SignoPesos = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.cbo_TipoConsumo = new System.Windows.Forms.ComboBox();
            this.cbo_Categorias = new System.Windows.Forms.ComboBox();
            this.lbl_FechaDeGasto = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Consumo = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.txt_Cuotas = new System.Windows.Forms.TextBox();
            this.lbl_Cuotas = new System.Windows.Forms.Label();
            this.lbl_Nota = new System.Windows.Forms.Label();
            this.dte_Fecha = new System.Windows.Forms.DateTimePicker();
            this.rad_Pagado = new System.Windows.Forms.RadioButton();
            this.rad_NoPagado = new System.Windows.Forms.RadioButton();
            this.grp_Pago = new System.Windows.Forms.GroupBox();
            this.cbo_Descripcion = new System.Windows.Forms.ComboBox();
            this.grp_Pago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monto.ForeColor = System.Drawing.Color.White;
            this.lbl_Monto.Location = new System.Drawing.Point(168, 10);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(113, 18);
            this.lbl_Monto.TabIndex = 0;
            this.lbl_Monto.Text = "Monto (por mes)";
            // 
            // lbl_SignoPesos
            // 
            this.lbl_SignoPesos.AutoSize = true;
            this.lbl_SignoPesos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignoPesos.ForeColor = System.Drawing.Color.White;
            this.lbl_SignoPesos.Location = new System.Drawing.Point(156, 39);
            this.lbl_SignoPesos.Name = "lbl_SignoPesos";
            this.lbl_SignoPesos.Size = new System.Drawing.Size(14, 15);
            this.lbl_SignoPesos.TabIndex = 1;
            this.lbl_SignoPesos.Text = "$";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Monto.Location = new System.Drawing.Point(170, 36);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(122, 23);
            this.txt_Monto.TabIndex = 2;
            // 
            // cbo_TipoConsumo
            // 
            this.cbo_TipoConsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TipoConsumo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TipoConsumo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbo_TipoConsumo.FormattingEnabled = true;
            this.cbo_TipoConsumo.Location = new System.Drawing.Point(13, 90);
            this.cbo_TipoConsumo.Name = "cbo_TipoConsumo";
            this.cbo_TipoConsumo.Size = new System.Drawing.Size(126, 23);
            this.cbo_TipoConsumo.TabIndex = 3;
            this.cbo_TipoConsumo.SelectedIndexChanged += new System.EventHandler(this.cbo_TipoConsumo_SelectedIndexChanged);
            // 
            // cbo_Categorias
            // 
            this.cbo_Categorias.BackColor = System.Drawing.SystemColors.Window;
            this.cbo_Categorias.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Categorias.ForeColor = System.Drawing.Color.Black;
            this.cbo_Categorias.FormattingEnabled = true;
            this.cbo_Categorias.Location = new System.Drawing.Point(15, 153);
            this.cbo_Categorias.Name = "cbo_Categorias";
            this.cbo_Categorias.Size = new System.Drawing.Size(277, 23);
            this.cbo_Categorias.TabIndex = 5;
            this.cbo_Categorias.Text = "Escribir / seleccionar categoria";
            this.cbo_Categorias.SelectedIndexChanged += new System.EventHandler(this.cbo_Categorias_SelectedIndexChanged);
            // 
            // lbl_FechaDeGasto
            // 
            this.lbl_FechaDeGasto.AutoSize = true;
            this.lbl_FechaDeGasto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaDeGasto.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaDeGasto.Location = new System.Drawing.Point(12, 189);
            this.lbl_FechaDeGasto.Name = "lbl_FechaDeGasto";
            this.lbl_FechaDeGasto.Size = new System.Drawing.Size(44, 18);
            this.lbl_FechaDeGasto.TabIndex = 16;
            this.lbl_FechaDeGasto.Text = "Fecha";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(14, 36);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(120, 23);
            this.txt_Descripcion.TabIndex = 1;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(10, 9);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(80, 18);
            this.lbl_Descripcion.TabIndex = 17;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // lbl_Consumo
            // 
            this.lbl_Consumo.AutoSize = true;
            this.lbl_Consumo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consumo.ForeColor = System.Drawing.Color.White;
            this.lbl_Consumo.Location = new System.Drawing.Point(10, 67);
            this.lbl_Consumo.Name = "lbl_Consumo";
            this.lbl_Consumo.Size = new System.Drawing.Size(113, 18);
            this.lbl_Consumo.TabIndex = 22;
            this.lbl_Consumo.Text = "Tipo de consumo";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(12, 128);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(67, 18);
            this.lbl_Categoria.TabIndex = 23;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // txt_Cuotas
            // 
            this.txt_Cuotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cuotas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cuotas.Location = new System.Drawing.Point(170, 91);
            this.txt_Cuotas.Name = "txt_Cuotas";
            this.txt_Cuotas.Size = new System.Drawing.Size(122, 23);
            this.txt_Cuotas.TabIndex = 4;
            // 
            // lbl_Cuotas
            // 
            this.lbl_Cuotas.AutoSize = true;
            this.lbl_Cuotas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cuotas.ForeColor = System.Drawing.Color.White;
            this.lbl_Cuotas.Location = new System.Drawing.Point(167, 67);
            this.lbl_Cuotas.Name = "lbl_Cuotas";
            this.lbl_Cuotas.Size = new System.Drawing.Size(106, 18);
            this.lbl_Cuotas.TabIndex = 24;
            this.lbl_Cuotas.Text = "Cantidad cuotas";
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.AutoSize = true;
            this.lbl_Nota.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nota.ForeColor = System.Drawing.Color.White;
            this.lbl_Nota.Location = new System.Drawing.Point(13, 457);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(33, 15);
            this.lbl_Nota.TabIndex = 25;
            this.lbl_Nota.Text = "Nota";
            // 
            // dte_Fecha
            // 
            this.dte_Fecha.CalendarForeColor = System.Drawing.Color.OliveDrab;
            this.dte_Fecha.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dte_Fecha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dte_Fecha.Location = new System.Drawing.Point(15, 211);
            this.dte_Fecha.Name = "dte_Fecha";
            this.dte_Fecha.Size = new System.Drawing.Size(277, 23);
            this.dte_Fecha.TabIndex = 6;
            // 
            // rad_Pagado
            // 
            this.rad_Pagado.AutoSize = true;
            this.rad_Pagado.Checked = true;
            this.rad_Pagado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Pagado.ForeColor = System.Drawing.Color.White;
            this.rad_Pagado.Location = new System.Drawing.Point(11, 26);
            this.rad_Pagado.Name = "rad_Pagado";
            this.rad_Pagado.Size = new System.Drawing.Size(64, 19);
            this.rad_Pagado.TabIndex = 7;
            this.rad_Pagado.TabStop = true;
            this.rad_Pagado.Text = "Pagado";
            this.rad_Pagado.UseVisualStyleBackColor = true;
            // 
            // rad_NoPagado
            // 
            this.rad_NoPagado.AutoSize = true;
            this.rad_NoPagado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_NoPagado.ForeColor = System.Drawing.Color.White;
            this.rad_NoPagado.Location = new System.Drawing.Point(163, 26);
            this.rad_NoPagado.Name = "rad_NoPagado";
            this.rad_NoPagado.Size = new System.Drawing.Size(83, 19);
            this.rad_NoPagado.TabIndex = 8;
            this.rad_NoPagado.Text = "No pagado";
            this.rad_NoPagado.UseVisualStyleBackColor = true;
            // 
            // grp_Pago
            // 
            this.grp_Pago.Controls.Add(this.rad_NoPagado);
            this.grp_Pago.Controls.Add(this.rad_Pagado);
            this.grp_Pago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_Pago.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Pago.ForeColor = System.Drawing.Color.White;
            this.grp_Pago.Location = new System.Drawing.Point(16, 252);
            this.grp_Pago.Name = "grp_Pago";
            this.grp_Pago.Size = new System.Drawing.Size(276, 54);
            this.grp_Pago.TabIndex = 5;
            this.grp_Pago.TabStop = false;
            this.grp_Pago.Text = "Pago realizado";
            // 
            // cbo_Descripcion
            // 
            this.cbo_Descripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Descripcion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbo_Descripcion.FormattingEnabled = true;
            this.cbo_Descripcion.Location = new System.Drawing.Point(14, 36);
            this.cbo_Descripcion.Name = "cbo_Descripcion";
            this.cbo_Descripcion.Size = new System.Drawing.Size(126, 23);
            this.cbo_Descripcion.TabIndex = 32;
            this.cbo_Descripcion.SelectedIndexChanged += new System.EventHandler(this.cbo_Descripcion_SelectedIndexChanged);
            this.cbo_Descripcion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbo_Descripcion_MouseClick);
            // 
            // FormNuevoConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(316, 534);
            this.Controls.Add(this.cbo_Descripcion);
            this.Controls.Add(this.lbl_Nota);
            this.Controls.Add(this.txt_Cuotas);
            this.Controls.Add(this.lbl_Cuotas);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Consumo);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_FechaDeGasto);
            this.Controls.Add(this.dte_Fecha);
            this.Controls.Add(this.grp_Pago);
            this.Controls.Add(this.cbo_Categorias);
            this.Controls.Add(this.cbo_TipoConsumo);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.lbl_SignoPesos);
            this.Controls.Add(this.lbl_Monto);
            this.Name = "FormNuevoConsumo";
            this.Text = "Crear gasto";
            this.Load += new System.EventHandler(this.FormNuevoGasto_Load);
            this.Controls.SetChildIndex(this.lbl_Monto, 0);
            this.Controls.SetChildIndex(this.lbl_SignoPesos, 0);
            this.Controls.SetChildIndex(this.txt_Monto, 0);
            this.Controls.SetChildIndex(this.cbo_TipoConsumo, 0);
            this.Controls.SetChildIndex(this.cbo_Categorias, 0);
            this.Controls.SetChildIndex(this.grp_Pago, 0);
            this.Controls.SetChildIndex(this.dte_Fecha, 0);
            this.Controls.SetChildIndex(this.lbl_FechaDeGasto, 0);
            this.Controls.SetChildIndex(this.lbl_Descripcion, 0);
            this.Controls.SetChildIndex(this.txt_Descripcion, 0);
            this.Controls.SetChildIndex(this.lbl_Consumo, 0);
            this.Controls.SetChildIndex(this.lbl_Categoria, 0);
            this.Controls.SetChildIndex(this.lbl_Cuotas, 0);
            this.Controls.SetChildIndex(this.txt_Cuotas, 0);
            this.Controls.SetChildIndex(this.lbl_Nota, 0);
            this.Controls.SetChildIndex(this.cbo_Descripcion, 0);
            this.grp_Pago.ResumeLayout(false);
            this.grp_Pago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.Label lbl_SignoPesos;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.ComboBox cbo_TipoConsumo;
        private System.Windows.Forms.ComboBox cbo_Categorias;
        private System.Windows.Forms.Label lbl_FechaDeGasto;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Consumo;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.TextBox txt_Cuotas;
        private System.Windows.Forms.Label lbl_Cuotas;
        private System.Windows.Forms.Label lbl_Nota;
        private System.Windows.Forms.DateTimePicker dte_Fecha;
        private System.Windows.Forms.RadioButton rad_Pagado;
        private System.Windows.Forms.RadioButton rad_NoPagado;
        private System.Windows.Forms.GroupBox grp_Pago;
        private System.Windows.Forms.ComboBox cbo_Descripcion;
    }
}