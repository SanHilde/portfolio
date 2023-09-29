namespace Interfaz
{
    partial class FormDetallesDelMes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtaGrid_Detalles = new System.Windows.Forms.DataGridView();
            this.Clna_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clna_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clna_TipoDeGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clna_Categorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clna_CantCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clna_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clna_Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clna_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_Tipo = new System.Windows.Forms.CheckBox();
            this.cbo_Tipos = new System.Windows.Forms.ComboBox();
            this.cbo_Categorias = new System.Windows.Forms.ComboBox();
            this.chk_Categorias = new System.Windows.Forms.CheckBox();
            this.consumoVolatilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrid_Detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumoVolatilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGrid_Detalles
            // 
            this.dtaGrid_Detalles.AllowUserToAddRows = false;
            this.dtaGrid_Detalles.AllowUserToDeleteRows = false;
            this.dtaGrid_Detalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGrid_Detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGrid_Detalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtaGrid_Detalles.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGrid_Detalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaGrid_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGrid_Detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clna_Id,
            this.Clna_Descripcion,
            this.Clna_TipoDeGasto,
            this.Clna_Categorias,
            this.Clna_CantCuotas,
            this.Clna_Monto,
            this.Clna_Pagado,
            this.Clna_Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGrid_Detalles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtaGrid_Detalles.EnableHeadersVisualStyles = false;
            this.dtaGrid_Detalles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dtaGrid_Detalles.Location = new System.Drawing.Point(0, 50);
            this.dtaGrid_Detalles.Name = "dtaGrid_Detalles";
            this.dtaGrid_Detalles.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGrid_Detalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtaGrid_Detalles.RowHeadersVisible = false;
            this.dtaGrid_Detalles.Size = new System.Drawing.Size(790, 400);
            this.dtaGrid_Detalles.TabIndex = 0;
            this.dtaGrid_Detalles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGrid_Detalles_CellClick);
            // 
            // Clna_Id
            // 
            this.Clna_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clna_Id.Frozen = true;
            this.Clna_Id.HeaderText = "ID";
            this.Clna_Id.Name = "Clna_Id";
            this.Clna_Id.ReadOnly = true;
            this.Clna_Id.Width = 44;
            // 
            // Clna_Descripcion
            // 
            this.Clna_Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clna_Descripcion.Frozen = true;
            this.Clna_Descripcion.HeaderText = "Descripcion";
            this.Clna_Descripcion.Name = "Clna_Descripcion";
            this.Clna_Descripcion.ReadOnly = true;
            this.Clna_Descripcion.Width = 150;
            // 
            // Clna_TipoDeGasto
            // 
            this.Clna_TipoDeGasto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clna_TipoDeGasto.Frozen = true;
            this.Clna_TipoDeGasto.HeaderText = "Tipo de gasto";
            this.Clna_TipoDeGasto.Name = "Clna_TipoDeGasto";
            this.Clna_TipoDeGasto.ReadOnly = true;
            this.Clna_TipoDeGasto.Width = 125;
            // 
            // Clna_Categorias
            // 
            this.Clna_Categorias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clna_Categorias.Frozen = true;
            this.Clna_Categorias.HeaderText = "Categoria";
            this.Clna_Categorias.Name = "Clna_Categorias";
            this.Clna_Categorias.ReadOnly = true;
            this.Clna_Categorias.Width = 85;
            // 
            // Clna_CantCuotas
            // 
            this.Clna_CantCuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clna_CantCuotas.Frozen = true;
            this.Clna_CantCuotas.HeaderText = "Cuotas restantes";
            this.Clna_CantCuotas.Name = "Clna_CantCuotas";
            this.Clna_CantCuotas.ReadOnly = true;
            this.Clna_CantCuotas.Width = 140;
            // 
            // Clna_Monto
            // 
            this.Clna_Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clna_Monto.Frozen = true;
            this.Clna_Monto.HeaderText = "Monto";
            this.Clna_Monto.Name = "Clna_Monto";
            this.Clna_Monto.ReadOnly = true;
            this.Clna_Monto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Clna_Monto.Width = 68;
            // 
            // Clna_Pagado
            // 
            this.Clna_Pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clna_Pagado.Frozen = true;
            this.Clna_Pagado.HeaderText = "Pagado";
            this.Clna_Pagado.Name = "Clna_Pagado";
            this.Clna_Pagado.ReadOnly = true;
            this.Clna_Pagado.Width = 73;
            // 
            // Clna_Fecha
            // 
            this.Clna_Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Clna_Fecha.Frozen = true;
            this.Clna_Fecha.HeaderText = "Fecha";
            this.Clna_Fecha.Name = "Clna_Fecha";
            this.Clna_Fecha.ReadOnly = true;
            // 
            // chk_Tipo
            // 
            this.chk_Tipo.AutoSize = true;
            this.chk_Tipo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Tipo.ForeColor = System.Drawing.Color.White;
            this.chk_Tipo.Location = new System.Drawing.Point(13, 13);
            this.chk_Tipo.Name = "chk_Tipo";
            this.chk_Tipo.Size = new System.Drawing.Size(166, 19);
            this.chk_Tipo.TabIndex = 1;
            this.chk_Tipo.Text = "Filtrar tipos de consumos";
            this.chk_Tipo.UseVisualStyleBackColor = true;
            this.chk_Tipo.CheckedChanged += new System.EventHandler(this.FormDetallesDelMes_Load);
            // 
            // cbo_Tipos
            // 
            this.cbo_Tipos.FormattingEnabled = true;
            this.cbo_Tipos.Location = new System.Drawing.Point(202, 10);
            this.cbo_Tipos.Name = "cbo_Tipos";
            this.cbo_Tipos.Size = new System.Drawing.Size(133, 21);
            this.cbo_Tipos.TabIndex = 2;
            this.cbo_Tipos.SelectedIndexChanged += new System.EventHandler(this.FormDetallesDelMes_Load);
            // 
            // cbo_Categorias
            // 
            this.cbo_Categorias.FormattingEnabled = true;
            this.cbo_Categorias.Location = new System.Drawing.Point(495, 10);
            this.cbo_Categorias.Name = "cbo_Categorias";
            this.cbo_Categorias.Size = new System.Drawing.Size(133, 21);
            this.cbo_Categorias.TabIndex = 4;
            this.cbo_Categorias.SelectedIndexChanged += new System.EventHandler(this.FormDetallesDelMes_Load);
            // 
            // chk_Categorias
            // 
            this.chk_Categorias.AutoSize = true;
            this.chk_Categorias.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Categorias.ForeColor = System.Drawing.Color.White;
            this.chk_Categorias.Location = new System.Drawing.Point(359, 13);
            this.chk_Categorias.Name = "chk_Categorias";
            this.chk_Categorias.Size = new System.Drawing.Size(122, 19);
            this.chk_Categorias.TabIndex = 3;
            this.chk_Categorias.Text = "Filtrar categorias";
            this.chk_Categorias.UseVisualStyleBackColor = true;
            this.chk_Categorias.CheckedChanged += new System.EventHandler(this.FormDetallesDelMes_Load);
            // 
            // consumoVolatilBindingSource
            // 
            this.consumoVolatilBindingSource.DataSource = typeof(Entidades.ConsumoVolatil);
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exportar.Location = new System.Drawing.Point(655, 10);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(122, 23);
            this.btn_Exportar.TabIndex = 5;
            this.btn_Exportar.Text = "Exportar datos";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // FormDetallesDelMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.cbo_Categorias);
            this.Controls.Add(this.chk_Categorias);
            this.Controls.Add(this.cbo_Tipos);
            this.Controls.Add(this.chk_Tipo);
            this.Controls.Add(this.dtaGrid_Detalles);
            this.Name = "FormDetallesDelMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del mes";
            this.Load += new System.EventHandler(this.FormDetallesDelMes_Load);
            this.SizeChanged += new System.EventHandler(this.FormDetallesDelMes_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGrid_Detalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumoVolatilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGrid_Detalles;
        private System.Windows.Forms.BindingSource consumoVolatilBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clna_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clna_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clna_TipoDeGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clna_Categorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clna_CantCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clna_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clna_Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clna_Fecha;
        private System.Windows.Forms.CheckBox chk_Tipo;
        private System.Windows.Forms.ComboBox cbo_Tipos;
        private System.Windows.Forms.ComboBox cbo_Categorias;
        private System.Windows.Forms.CheckBox chk_Categorias;
        private System.Windows.Forms.Button btn_Exportar;
    }
}