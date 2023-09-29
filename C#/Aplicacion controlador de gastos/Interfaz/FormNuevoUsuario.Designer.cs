namespace Interfaz
{
    partial class FormNuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoUsuario));
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_ContraseñaRepetida = new System.Windows.Forms.Label();
            this.txt_NuevoUsuario = new System.Windows.Forms.TextBox();
            this.txt_ContraseñaRepetida = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_Usuario.Location = new System.Drawing.Point(56, 53);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(101, 14);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Nombre de usuario";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_Contraseña.Location = new System.Drawing.Point(56, 81);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(62, 14);
            this.lbl_Contraseña.TabIndex = 1;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // lbl_ContraseñaRepetida
            // 
            this.lbl_ContraseñaRepetida.AutoSize = true;
            this.lbl_ContraseñaRepetida.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContraseñaRepetida.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_ContraseñaRepetida.Location = new System.Drawing.Point(56, 110);
            this.lbl_ContraseñaRepetida.Name = "lbl_ContraseñaRepetida";
            this.lbl_ContraseñaRepetida.Size = new System.Drawing.Size(96, 14);
            this.lbl_ContraseñaRepetida.TabIndex = 2;
            this.lbl_ContraseñaRepetida.Text = "Repita contraseña";
            // 
            // txt_NuevoUsuario
            // 
            this.txt_NuevoUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoUsuario.Location = new System.Drawing.Point(189, 46);
            this.txt_NuevoUsuario.Name = "txt_NuevoUsuario";
            this.txt_NuevoUsuario.Size = new System.Drawing.Size(100, 22);
            this.txt_NuevoUsuario.TabIndex = 2;
            // 
            // txt_ContraseñaRepetida
            // 
            this.txt_ContraseñaRepetida.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContraseñaRepetida.Location = new System.Drawing.Point(189, 106);
            this.txt_ContraseñaRepetida.Name = "txt_ContraseñaRepetida";
            this.txt_ContraseñaRepetida.PasswordChar = '*';
            this.txt_ContraseñaRepetida.Size = new System.Drawing.Size(100, 22);
            this.txt_ContraseñaRepetida.TabIndex = 4;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.Location = new System.Drawing.Point(189, 76);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 22);
            this.txt_Contraseña.TabIndex = 3;
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearUsuario.Location = new System.Drawing.Point(189, 151);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(100, 23);
            this.btn_CrearUsuario.TabIndex = 5;
            this.btn_CrearUsuario.Text = "Crear usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            this.btn_CrearUsuario.Click += new System.EventHandler(this.btn_CrearUsuario_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(189, 17);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_Nombre.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_Nombre.Location = new System.Drawing.Point(56, 22);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(82, 14);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre/Apodo";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(53, 151);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 23);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FormNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(340, 190);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_ContraseñaRepetida);
            this.Controls.Add(this.txt_NuevoUsuario);
            this.Controls.Add(this.lbl_ContraseñaRepetida);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Crear usuario";
            this.Load += new System.EventHandler(this.FormNuevoUsuario_Load);
            this.Enter += new System.EventHandler(this.btn_CrearUsuario_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_ContraseñaRepetida;
        private System.Windows.Forms.TextBox txt_NuevoUsuario;
        private System.Windows.Forms.TextBox txt_ContraseñaRepetida;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}