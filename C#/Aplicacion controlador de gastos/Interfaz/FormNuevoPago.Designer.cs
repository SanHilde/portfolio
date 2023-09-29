namespace Interfaz
{
    partial class FormNuevoPago
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
            this.cbo_Consumo = new System.Windows.Forms.ComboBox();
            this.cbo_Categorias = new System.Windows.Forms.ComboBox();
            this.cbo_Descripcion = new System.Windows.Forms.ComboBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Consumo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.rad_NoPagado = new System.Windows.Forms.RadioButton();
            this.rad_Pagado = new System.Windows.Forms.RadioButton();
            this.grp_Pago = new System.Windows.Forms.GroupBox();
            this.lbl_MontoCargado = new System.Windows.Forms.Label();
            this.grp_Pago.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_Consumo
            // 
            this.cbo_Consumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Consumo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Consumo.FormattingEnabled = true;
            this.cbo_Consumo.Location = new System.Drawing.Point(13, 43);
            this.cbo_Consumo.Name = "cbo_Consumo";
            this.cbo_Consumo.Size = new System.Drawing.Size(277, 23);
            this.cbo_Consumo.TabIndex = 0;
            this.cbo_Consumo.SelectedIndexChanged += new System.EventHandler(this.cbo_Consumo_SelectedIndexChanged);
            // 
            // cbo_Categorias
            // 
            this.cbo_Categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Categorias.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Categorias.FormattingEnabled = true;
            this.cbo_Categorias.Location = new System.Drawing.Point(15, 99);
            this.cbo_Categorias.Name = "cbo_Categorias";
            this.cbo_Categorias.Size = new System.Drawing.Size(277, 23);
            this.cbo_Categorias.TabIndex = 1;
            this.cbo_Categorias.SelectedIndexChanged += new System.EventHandler(this.cbo_Categorias_SelectedIndexChanged);
            // 
            // cbo_Descripcion
            // 
            this.cbo_Descripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Descripcion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Descripcion.FormattingEnabled = true;
            this.cbo_Descripcion.Location = new System.Drawing.Point(15, 155);
            this.cbo_Descripcion.Name = "cbo_Descripcion";
            this.cbo_Descripcion.Size = new System.Drawing.Size(277, 23);
            this.cbo_Descripcion.TabIndex = 2;
            this.cbo_Descripcion.SelectedIndexChanged += new System.EventHandler(this.cbo_Descripcion_SelectedIndexChanged);
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.ForeColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(12, 74);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(67, 18);
            this.lbl_Categoria.TabIndex = 28;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // lbl_Consumo
            // 
            this.lbl_Consumo.AutoSize = true;
            this.lbl_Consumo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consumo.ForeColor = System.Drawing.Color.White;
            this.lbl_Consumo.Location = new System.Drawing.Point(12, 18);
            this.lbl_Consumo.Name = "lbl_Consumo";
            this.lbl_Consumo.Size = new System.Drawing.Size(113, 18);
            this.lbl_Consumo.TabIndex = 27;
            this.lbl_Consumo.Text = "Tipo de consumo";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(12, 130);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(80, 18);
            this.lbl_Descripcion.TabIndex = 26;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Monto.ForeColor = System.Drawing.Color.White;
            this.lbl_Monto.Location = new System.Drawing.Point(12, 190);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(50, 18);
            this.lbl_Monto.TabIndex = 24;
            this.lbl_Monto.Text = "Monto";
            // 
            // rad_NoPagado
            // 
            this.rad_NoPagado.AutoSize = true;
            this.rad_NoPagado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_NoPagado.ForeColor = System.Drawing.Color.White;
            this.rad_NoPagado.Location = new System.Drawing.Point(150, 27);
            this.rad_NoPagado.Name = "rad_NoPagado";
            this.rad_NoPagado.Size = new System.Drawing.Size(83, 19);
            this.rad_NoPagado.TabIndex = 8;
            this.rad_NoPagado.Text = "No pagado";
            this.rad_NoPagado.UseVisualStyleBackColor = true;
            // 
            // rad_Pagado
            // 
            this.rad_Pagado.AutoSize = true;
            this.rad_Pagado.Checked = true;
            this.rad_Pagado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Pagado.ForeColor = System.Drawing.Color.White;
            this.rad_Pagado.Location = new System.Drawing.Point(8, 27);
            this.rad_Pagado.Name = "rad_Pagado";
            this.rad_Pagado.Size = new System.Drawing.Size(64, 19);
            this.rad_Pagado.TabIndex = 7;
            this.rad_Pagado.TabStop = true;
            this.rad_Pagado.Text = "Pagado";
            this.rad_Pagado.UseVisualStyleBackColor = true;
            // 
            // grp_Pago
            // 
            this.grp_Pago.Controls.Add(this.rad_NoPagado);
            this.grp_Pago.Controls.Add(this.rad_Pagado);
            this.grp_Pago.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Pago.ForeColor = System.Drawing.Color.White;
            this.grp_Pago.Location = new System.Drawing.Point(15, 250);
            this.grp_Pago.Name = "grp_Pago";
            this.grp_Pago.Size = new System.Drawing.Size(277, 54);
            this.grp_Pago.TabIndex = 25;
            this.grp_Pago.TabStop = false;
            this.grp_Pago.Text = "Pago realizado";
            // 
            // lbl_MontoCargado
            // 
            this.lbl_MontoCargado.AutoSize = true;
            this.lbl_MontoCargado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MontoCargado.ForeColor = System.Drawing.Color.White;
            this.lbl_MontoCargado.Location = new System.Drawing.Point(12, 217);
            this.lbl_MontoCargado.Name = "lbl_MontoCargado";
            this.lbl_MontoCargado.Size = new System.Drawing.Size(14, 15);
            this.lbl_MontoCargado.TabIndex = 32;
            this.lbl_MontoCargado.Text = "$";
            // 
            // FormNuevoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(316, 534);
            this.Controls.Add(this.lbl_MontoCargado);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Consumo);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_Monto);
            this.Controls.Add(this.grp_Pago);
            this.Controls.Add(this.cbo_Descripcion);
            this.Controls.Add(this.cbo_Categorias);
            this.Controls.Add(this.cbo_Consumo);
            this.Name = "FormNuevoPago";
            this.Text = "Actualizar pago";
            this.Load += new System.EventHandler(this.FormNuevoPago_Load);
            this.Controls.SetChildIndex(this.cbo_Consumo, 0);
            this.Controls.SetChildIndex(this.cbo_Categorias, 0);
            this.Controls.SetChildIndex(this.cbo_Descripcion, 0);
            this.Controls.SetChildIndex(this.grp_Pago, 0);
            this.Controls.SetChildIndex(this.lbl_Monto, 0);
            this.Controls.SetChildIndex(this.lbl_Descripcion, 0);
            this.Controls.SetChildIndex(this.lbl_Consumo, 0);
            this.Controls.SetChildIndex(this.lbl_Categoria, 0);
            this.Controls.SetChildIndex(this.lbl_MontoCargado, 0);
            this.grp_Pago.ResumeLayout(false);
            this.grp_Pago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Consumo;
        private System.Windows.Forms.ComboBox cbo_Categorias;
        private System.Windows.Forms.ComboBox cbo_Descripcion;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Consumo;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.RadioButton rad_NoPagado;
        private System.Windows.Forms.RadioButton rad_Pagado;
        private System.Windows.Forms.GroupBox grp_Pago;
        private System.Windows.Forms.Label lbl_MontoCargado;
    }
}