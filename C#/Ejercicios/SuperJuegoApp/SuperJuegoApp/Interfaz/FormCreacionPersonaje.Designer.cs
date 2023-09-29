namespace Interfaz
{
    partial class FormCreacionPersonaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreacionPersonaje));
            this.imglst_Clases = new System.Windows.Forms.ImageList(this.components);
            this.pic_Clase = new System.Windows.Forms.PictureBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_NombrePersonaje = new System.Windows.Forms.TextBox();
            this.txt_Nivel = new System.Windows.Forms.TextBox();
            this.lbl_Nivel = new System.Windows.Forms.Label();
            this.cmb_Clase = new System.Windows.Forms.ComboBox();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Clase)).BeginInit();
            this.SuspendLayout();
            // 
            // imglst_Clases
            // 
            this.imglst_Clases.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglst_Clases.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst_Clases.ImageStream")));
            this.imglst_Clases.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst_Clases.Images.SetKeyName(0, "shield.png");
            this.imglst_Clases.Images.SetKeyName(1, "sword.png");
            this.imglst_Clases.Images.SetKeyName(2, "wand.png");
            this.imglst_Clases.Images.SetKeyName(3, "dagger.png");
            // 
            // pic_Clase
            // 
            this.pic_Clase.Location = new System.Drawing.Point(47, 141);
            this.pic_Clase.Name = "pic_Clase";
            this.pic_Clase.Size = new System.Drawing.Size(113, 102);
            this.pic_Clase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Clase.TabIndex = 0;
            this.pic_Clase.TabStop = false;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(209, 62);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(192, 22);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre del Personaje";
            // 
            // txt_NombrePersonaje
            // 
            this.txt_NombrePersonaje.BackColor = System.Drawing.Color.Silver;
            this.txt_NombrePersonaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NombrePersonaje.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NombrePersonaje.Location = new System.Drawing.Point(209, 97);
            this.txt_NombrePersonaje.Name = "txt_NombrePersonaje";
            this.txt_NombrePersonaje.Size = new System.Drawing.Size(192, 29);
            this.txt_NombrePersonaje.TabIndex = 6;
            // 
            // txt_Nivel
            // 
            this.txt_Nivel.BackColor = System.Drawing.Color.Silver;
            this.txt_Nivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nivel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nivel.Location = new System.Drawing.Point(209, 278);
            this.txt_Nivel.Name = "txt_Nivel";
            this.txt_Nivel.Size = new System.Drawing.Size(192, 29);
            this.txt_Nivel.TabIndex = 8;
            // 
            // lbl_Nivel
            // 
            this.lbl_Nivel.AutoSize = true;
            this.lbl_Nivel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Nivel.Location = new System.Drawing.Point(209, 243);
            this.lbl_Nivel.Name = "lbl_Nivel";
            this.lbl_Nivel.Size = new System.Drawing.Size(52, 22);
            this.lbl_Nivel.TabIndex = 7;
            this.lbl_Nivel.Text = "Nivel";
            // 
            // cmb_Clase
            // 
            this.cmb_Clase.BackColor = System.Drawing.Color.Silver;
            this.cmb_Clase.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Clase.FormattingEnabled = true;
            this.cmb_Clase.Location = new System.Drawing.Point(209, 192);
            this.cmb_Clase.Name = "cmb_Clase";
            this.cmb_Clase.Size = new System.Drawing.Size(192, 29);
            this.cmb_Clase.TabIndex = 9;
            this.cmb_Clase.SelectedIndexChanged += new System.EventHandler(this.cmb_Clase_SelectedIndexChanged);
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Clase.Location = new System.Drawing.Point(209, 157);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(52, 22);
            this.lbl_Clase.TabIndex = 10;
            this.lbl_Clase.Text = "Clase";
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.DimGray;
            this.btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Crear.Location = new System.Drawing.Point(38, 360);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(153, 75);
            this.btn_Crear.TabIndex = 11;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(293, 360);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(153, 75);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // FormCreacionPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(500, 466);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.lbl_Clase);
            this.Controls.Add(this.cmb_Clase);
            this.Controls.Add(this.txt_Nivel);
            this.Controls.Add(this.lbl_Nivel);
            this.Controls.Add(this.txt_NombrePersonaje);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.pic_Clase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCreacionPersonaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Juego 3000 - Creacion de Personaje";
            this.Load += new System.EventHandler(this.FormCreacionPersonaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Clase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageList imglst_Clases;
        private PictureBox pic_Clase;
        private Label lbl_Nombre;
        private TextBox txt_NombrePersonaje;
        private TextBox txt_Nivel;
        private Label lbl_Nivel;
        private ComboBox cmb_Clase;
        private Label lbl_Clase;
        private Button btn_Crear;
        private Button btn_Cancelar;
    }
}