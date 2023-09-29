namespace Interfaz
{
    partial class FormEditarCategorias
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
            this.lbl_CategoriaActual = new System.Windows.Forms.Label();
            this.lbl_CategoriaEditada = new System.Windows.Forms.Label();
            this.cbo_CategoriaActual = new System.Windows.Forms.ComboBox();
            this.txt_CategoriaEditada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_CategoriaActual
            // 
            this.lbl_CategoriaActual.AutoSize = true;
            this.lbl_CategoriaActual.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoriaActual.ForeColor = System.Drawing.Color.White;
            this.lbl_CategoriaActual.Location = new System.Drawing.Point(24, 15);
            this.lbl_CategoriaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CategoriaActual.Name = "lbl_CategoriaActual";
            this.lbl_CategoriaActual.Size = new System.Drawing.Size(107, 18);
            this.lbl_CategoriaActual.TabIndex = 0;
            this.lbl_CategoriaActual.Text = "Categoria actual";
            // 
            // lbl_CategoriaEditada
            // 
            this.lbl_CategoriaEditada.AutoSize = true;
            this.lbl_CategoriaEditada.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoriaEditada.ForeColor = System.Drawing.Color.White;
            this.lbl_CategoriaEditada.Location = new System.Drawing.Point(24, 85);
            this.lbl_CategoriaEditada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CategoriaEditada.Name = "lbl_CategoriaEditada";
            this.lbl_CategoriaEditada.Size = new System.Drawing.Size(180, 18);
            this.lbl_CategoriaEditada.TabIndex = 1;
            this.lbl_CategoriaEditada.Text = "Nuevo nombre de categoria";
            // 
            // cbo_CategoriaActual
            // 
            this.cbo_CategoriaActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_CategoriaActual.FormattingEnabled = true;
            this.cbo_CategoriaActual.Location = new System.Drawing.Point(27, 42);
            this.cbo_CategoriaActual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_CategoriaActual.Name = "cbo_CategoriaActual";
            this.cbo_CategoriaActual.Size = new System.Drawing.Size(264, 23);
            this.cbo_CategoriaActual.TabIndex = 2;
            // 
            // txt_CategoriaEditada
            // 
            this.txt_CategoriaEditada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_CategoriaEditada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoriaEditada.Location = new System.Drawing.Point(26, 115);
            this.txt_CategoriaEditada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_CategoriaEditada.Name = "txt_CategoriaEditada";
            this.txt_CategoriaEditada.Size = new System.Drawing.Size(264, 23);
            this.txt_CategoriaEditada.TabIndex = 3;
            this.txt_CategoriaEditada.Text = "Ingrese nuevo nombre";
            // 
            // FormEditarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(316, 534);
            this.Controls.Add(this.txt_CategoriaEditada);
            this.Controls.Add(this.cbo_CategoriaActual);
            this.Controls.Add(this.lbl_CategoriaEditada);
            this.Controls.Add(this.lbl_CategoriaActual);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormEditarCategorias";
            this.Text = "Editar categoria";
            this.Load += new System.EventHandler(this.FormEditarCategorias_Load);
            this.Controls.SetChildIndex(this.lbl_CategoriaActual, 0);
            this.Controls.SetChildIndex(this.lbl_CategoriaEditada, 0);
            this.Controls.SetChildIndex(this.cbo_CategoriaActual, 0);
            this.Controls.SetChildIndex(this.txt_CategoriaEditada, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CategoriaActual;
        private System.Windows.Forms.Label lbl_CategoriaEditada;
        private System.Windows.Forms.ComboBox cbo_CategoriaActual;
        private System.Windows.Forms.TextBox txt_CategoriaEditada;
    }
}