namespace Interfaz
{
    partial class FormInformacionPersonaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacionPersonaje));
            this.pic_Clase = new System.Windows.Forms.PictureBox();
            this.pic_Nivel = new System.Windows.Forms.PictureBox();
            this.lbl_Nivel = new System.Windows.Forms.Label();
            this.lbl_NombrePersonaje = new System.Windows.Forms.Label();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Clase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Clase
            // 
            this.pic_Clase.Image = ((System.Drawing.Image)(resources.GetObject("pic_Clase.Image")));
            this.pic_Clase.Location = new System.Drawing.Point(101, 69);
            this.pic_Clase.Name = "pic_Clase";
            this.pic_Clase.Size = new System.Drawing.Size(50, 50);
            this.pic_Clase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Clase.TabIndex = 0;
            this.pic_Clase.TabStop = false;
            // 
            // pic_Nivel
            // 
            this.pic_Nivel.Image = ((System.Drawing.Image)(resources.GetObject("pic_Nivel.Image")));
            this.pic_Nivel.Location = new System.Drawing.Point(101, 236);
            this.pic_Nivel.Name = "pic_Nivel";
            this.pic_Nivel.Size = new System.Drawing.Size(50, 50);
            this.pic_Nivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Nivel.TabIndex = 1;
            this.pic_Nivel.TabStop = false;
            // 
            // lbl_Nivel
            // 
            this.lbl_Nivel.AutoSize = true;
            this.lbl_Nivel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nivel.Location = new System.Drawing.Point(176, 254);
            this.lbl_Nivel.Name = "lbl_Nivel";
            this.lbl_Nivel.Size = new System.Drawing.Size(52, 22);
            this.lbl_Nivel.TabIndex = 2;
            this.lbl_Nivel.Text = "Nivel";
            // 
            // lbl_NombrePersonaje
            // 
            this.lbl_NombrePersonaje.AutoSize = true;
            this.lbl_NombrePersonaje.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombrePersonaje.Location = new System.Drawing.Point(176, 84);
            this.lbl_NombrePersonaje.Name = "lbl_NombrePersonaje";
            this.lbl_NombrePersonaje.Size = new System.Drawing.Size(192, 22);
            this.lbl_NombrePersonaje.TabIndex = 3;
            this.lbl_NombrePersonaje.Text = "Nombre del Personaje";
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Clase.Location = new System.Drawing.Point(176, 164);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(166, 22);
            this.lbl_Clase.TabIndex = 5;
            this.lbl_Clase.Text = "Clase del Personaje";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormInformacionPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Clase);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_NombrePersonaje);
            this.Controls.Add(this.lbl_Nivel);
            this.Controls.Add(this.pic_Nivel);
            this.Controls.Add(this.pic_Clase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInformacionPersonaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Juego 3000 - Informacion Perfil";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Clase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pic_Clase;
        private PictureBox pic_Nivel;
        private Label lbl_Nivel;
        private Label lbl_NombrePersonaje;
        private Label lbl_Clase;
        private PictureBox pictureBox1;
    }
}