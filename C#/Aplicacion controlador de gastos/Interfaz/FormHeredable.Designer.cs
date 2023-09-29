namespace Interfaz
{
    partial class FormHeredable
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
            this.pic_BarraLateral = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_GuardarYSalir = new System.Windows.Forms.Button();
            this.btn_GuardarYContinuar = new System.Windows.Forms.Button();
            this.pic_Divisor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BarraLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Divisor)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_BarraLateral
            // 
            this.pic_BarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            this.pic_BarraLateral.Location = new System.Drawing.Point(306, 0);
            this.pic_BarraLateral.Name = "pic_BarraLateral";
            this.pic_BarraLateral.Size = new System.Drawing.Size(10, 70);
            this.pic_BarraLateral.TabIndex = 30;
            this.pic_BarraLateral.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(16, 409);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(276, 30);
            this.btn_Salir.TabIndex = 29;
            this.btn_Salir.Text = "Cancelar";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_GuardarYSalir
            // 
            this.btn_GuardarYSalir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarYSalir.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarYSalir.Location = new System.Drawing.Point(16, 367);
            this.btn_GuardarYSalir.Name = "btn_GuardarYSalir";
            this.btn_GuardarYSalir.Size = new System.Drawing.Size(276, 30);
            this.btn_GuardarYSalir.TabIndex = 28;
            this.btn_GuardarYSalir.Text = "Guardar y salir";
            this.btn_GuardarYSalir.UseVisualStyleBackColor = true;
            this.btn_GuardarYSalir.Click += new System.EventHandler(this.btn_GuardarYSalir_Click);
            // 
            // btn_GuardarYContinuar
            // 
            this.btn_GuardarYContinuar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarYContinuar.ForeColor = System.Drawing.Color.White;
            this.btn_GuardarYContinuar.Location = new System.Drawing.Point(16, 324);
            this.btn_GuardarYContinuar.Name = "btn_GuardarYContinuar";
            this.btn_GuardarYContinuar.Size = new System.Drawing.Size(276, 30);
            this.btn_GuardarYContinuar.TabIndex = 27;
            this.btn_GuardarYContinuar.Text = "Guardar";
            this.btn_GuardarYContinuar.UseVisualStyleBackColor = true;
            this.btn_GuardarYContinuar.Click += new System.EventHandler(this.btn_GuardarYContinuar_Click);
            // 
            // pic_Divisor
            // 
            this.pic_Divisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pic_Divisor.Location = new System.Drawing.Point(1, 0);
            this.pic_Divisor.Name = "pic_Divisor";
            this.pic_Divisor.Size = new System.Drawing.Size(1, 565);
            this.pic_Divisor.TabIndex = 31;
            this.pic_Divisor.TabStop = false;
            // 
            // FormHeredable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(316, 534);
            this.Controls.Add(this.pic_Divisor);
            this.Controls.Add(this.pic_BarraLateral);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_GuardarYSalir);
            this.Controls.Add(this.btn_GuardarYContinuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHeredable";
            this.Text = "FormPadre";
            this.Load += new System.EventHandler(this.FormHeredable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_BarraLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Divisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_BarraLateral;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_GuardarYSalir;
        private System.Windows.Forms.Button btn_GuardarYContinuar;
        private System.Windows.Forms.PictureBox pic_Divisor;
    }
}