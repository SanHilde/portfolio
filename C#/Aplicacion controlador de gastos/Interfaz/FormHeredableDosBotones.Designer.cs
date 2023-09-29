namespace Interfaz
{
    partial class FormHeredableDosBotones
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
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
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_Cancelar.Location = new System.Drawing.Point(16, 425);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(274, 30);
            this.btn_Cancelar.TabIndex = 29;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_Guardar.Location = new System.Drawing.Point(16, 378);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(274, 30);
            this.btn_Guardar.TabIndex = 28;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // pic_Divisor
            // 
            this.pic_Divisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pic_Divisor.Location = new System.Drawing.Point(1, 0);
            this.pic_Divisor.Name = "pic_Divisor";
            this.pic_Divisor.Size = new System.Drawing.Size(1, 534);
            this.pic_Divisor.TabIndex = 32;
            this.pic_Divisor.TabStop = false;
            // 
            // FormHeredableDosBotones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(316, 534);
            this.Controls.Add(this.pic_Divisor);
            this.Controls.Add(this.pic_BarraLateral);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHeredableDosBotones";
            this.Text = "FormHeredableDosBotones";
            this.Load += new System.EventHandler(this.FormHeredableDosBotones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_BarraLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Divisor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_BarraLateral;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.PictureBox pic_Divisor;
    }
}