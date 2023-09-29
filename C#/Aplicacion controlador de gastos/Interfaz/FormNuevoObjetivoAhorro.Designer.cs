namespace Interfaz
{
    partial class FormNuevoObjetivoAhorro
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
            this.lbl_NuevoObjetivo = new System.Windows.Forms.Label();
            this.txt_NuevoObjetivo = new System.Windows.Forms.TextBox();
            this.lbl_Porcentaje = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.txt_ObjetivoNeto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_NuevoObjetivo
            // 
            this.lbl_NuevoObjetivo.AutoSize = true;
            this.lbl_NuevoObjetivo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevoObjetivo.ForeColor = System.Drawing.Color.White;
            this.lbl_NuevoObjetivo.Location = new System.Drawing.Point(35, 13);
            this.lbl_NuevoObjetivo.Name = "lbl_NuevoObjetivo";
            this.lbl_NuevoObjetivo.Size = new System.Drawing.Size(167, 18);
            this.lbl_NuevoObjetivo.TabIndex = 0;
            this.lbl_NuevoObjetivo.Text = "Nuevo objetivo de ahorro";
            // 
            // txt_NuevoObjetivo
            // 
            this.txt_NuevoObjetivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoObjetivo.Location = new System.Drawing.Point(38, 43);
            this.txt_NuevoObjetivo.Name = "txt_NuevoObjetivo";
            this.txt_NuevoObjetivo.Size = new System.Drawing.Size(252, 23);
            this.txt_NuevoObjetivo.TabIndex = 2;
            this.txt_NuevoObjetivo.TextChanged += new System.EventHandler(this.txt_NuevoObjetivo_TextChanged);
            // 
            // lbl_Porcentaje
            // 
            this.lbl_Porcentaje.AutoSize = true;
            this.lbl_Porcentaje.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Porcentaje.ForeColor = System.Drawing.Color.White;
            this.lbl_Porcentaje.Location = new System.Drawing.Point(11, 45);
            this.lbl_Porcentaje.Name = "lbl_Porcentaje";
            this.lbl_Porcentaje.Size = new System.Drawing.Size(19, 18);
            this.lbl_Porcentaje.TabIndex = 4;
            this.lbl_Porcentaje.Text = "%";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peso.ForeColor = System.Drawing.Color.White;
            this.lbl_Peso.Location = new System.Drawing.Point(11, 87);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(15, 18);
            this.lbl_Peso.TabIndex = 34;
            this.lbl_Peso.Text = "$";
            this.lbl_Peso.Visible = false;
            // 
            // txt_ObjetivoNeto
            // 
            this.txt_ObjetivoNeto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ObjetivoNeto.Location = new System.Drawing.Point(38, 85);
            this.txt_ObjetivoNeto.Name = "txt_ObjetivoNeto";
            this.txt_ObjetivoNeto.Size = new System.Drawing.Size(252, 23);
            this.txt_ObjetivoNeto.TabIndex = 33;
            this.txt_ObjetivoNeto.Visible = false;
            this.txt_ObjetivoNeto.TextChanged += new System.EventHandler(this.txt_ObjetivoNeto_TextChanged);
            // 
            // FormNuevoObjetivoAhorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(316, 534);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.txt_ObjetivoNeto);
            this.Controls.Add(this.lbl_Porcentaje);
            this.Controls.Add(this.txt_NuevoObjetivo);
            this.Controls.Add(this.lbl_NuevoObjetivo);
            this.Name = "FormNuevoObjetivoAhorro";
            this.Text = "Nuevo objetivo de ahorro";
            this.Load += new System.EventHandler(this.FormNuevoObjetivoAhorro_Load);
            this.Controls.SetChildIndex(this.lbl_NuevoObjetivo, 0);
            this.Controls.SetChildIndex(this.txt_NuevoObjetivo, 0);
            this.Controls.SetChildIndex(this.lbl_Porcentaje, 0);
            this.Controls.SetChildIndex(this.txt_ObjetivoNeto, 0);
            this.Controls.SetChildIndex(this.lbl_Peso, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NuevoObjetivo;
        private System.Windows.Forms.TextBox txt_NuevoObjetivo;
        private System.Windows.Forms.Label lbl_Porcentaje;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.TextBox txt_ObjetivoNeto;
    }
}