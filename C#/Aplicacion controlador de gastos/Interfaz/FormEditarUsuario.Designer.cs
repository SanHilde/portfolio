namespace Interfaz
{
    partial class FormEditarUsuario
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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_ContraseñaRepetida = new System.Windows.Forms.TextBox();
            this.txt_NuevoUsuario = new System.Windows.Forms.TextBox();
            this.lbl_ContraseñaRepetida = new System.Windows.Forms.Label();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_UsuarioAEditar = new System.Windows.Forms.Label();
            this.cbo_Usuarios = new System.Windows.Forms.ComboBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.cbo_TipoDeUsuario = new System.Windows.Forms.ComboBox();
            this.lbl_TipoDeUsuario = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.cbo_Estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(146, 86);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_Nombre.TabIndex = 8;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_Nombre.Location = new System.Drawing.Point(13, 91);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(90, 14);
            this.lbl_Nombre.TabIndex = 14;
            this.lbl_Nombre.Text = "Nombre/Apodo";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.Location = new System.Drawing.Point(146, 160);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 22);
            this.txt_Contraseña.TabIndex = 12;
            // 
            // txt_ContraseñaRepetida
            // 
            this.txt_ContraseñaRepetida.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContraseñaRepetida.Location = new System.Drawing.Point(146, 196);
            this.txt_ContraseñaRepetida.Name = "txt_ContraseñaRepetida";
            this.txt_ContraseñaRepetida.Size = new System.Drawing.Size(100, 22);
            this.txt_ContraseñaRepetida.TabIndex = 13;
            // 
            // txt_NuevoUsuario
            // 
            this.txt_NuevoUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NuevoUsuario.Location = new System.Drawing.Point(146, 122);
            this.txt_NuevoUsuario.Name = "txt_NuevoUsuario";
            this.txt_NuevoUsuario.Size = new System.Drawing.Size(100, 22);
            this.txt_NuevoUsuario.TabIndex = 10;
            // 
            // lbl_ContraseñaRepetida
            // 
            this.lbl_ContraseñaRepetida.AutoSize = true;
            this.lbl_ContraseñaRepetida.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContraseñaRepetida.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_ContraseñaRepetida.Location = new System.Drawing.Point(13, 200);
            this.lbl_ContraseñaRepetida.Name = "lbl_ContraseñaRepetida";
            this.lbl_ContraseñaRepetida.Size = new System.Drawing.Size(107, 14);
            this.lbl_ContraseñaRepetida.TabIndex = 11;
            this.lbl_ContraseñaRepetida.Text = "Repita contraseña";
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contraseña.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_Contraseña.Location = new System.Drawing.Point(13, 165);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(69, 14);
            this.lbl_Contraseña.TabIndex = 9;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_Usuario.Location = new System.Drawing.Point(13, 129);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(112, 14);
            this.lbl_Usuario.TabIndex = 7;
            this.lbl_Usuario.Text = "Nombre de usuario";
            // 
            // lbl_UsuarioAEditar
            // 
            this.lbl_UsuarioAEditar.AutoSize = true;
            this.lbl_UsuarioAEditar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuarioAEditar.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_UsuarioAEditar.Location = new System.Drawing.Point(13, 52);
            this.lbl_UsuarioAEditar.Name = "lbl_UsuarioAEditar";
            this.lbl_UsuarioAEditar.Size = new System.Drawing.Size(96, 14);
            this.lbl_UsuarioAEditar.TabIndex = 17;
            this.lbl_UsuarioAEditar.Text = "Usuario a editar";
            // 
            // cbo_Usuarios
            // 
            this.cbo_Usuarios.BackColor = System.Drawing.Color.Black;
            this.cbo_Usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Usuarios.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Usuarios.ForeColor = System.Drawing.Color.OliveDrab;
            this.cbo_Usuarios.FormattingEnabled = true;
            this.cbo_Usuarios.Location = new System.Drawing.Point(146, 46);
            this.cbo_Usuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Usuarios.Name = "cbo_Usuarios";
            this.cbo_Usuarios.Size = new System.Drawing.Size(100, 22);
            this.cbo_Usuarios.TabIndex = 18;
            this.cbo_Usuarios.SelectedIndexChanged += new System.EventHandler(this.cbo_Usuarios_SelectedIndexChanged);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_Titulo.Location = new System.Drawing.Point(88, 13);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(105, 19);
            this.lbl_Titulo.TabIndex = 31;
            this.lbl_Titulo.Text = "Editar usuario";
            // 
            // cbo_TipoDeUsuario
            // 
            this.cbo_TipoDeUsuario.BackColor = System.Drawing.Color.Black;
            this.cbo_TipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TipoDeUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TipoDeUsuario.ForeColor = System.Drawing.Color.OliveDrab;
            this.cbo_TipoDeUsuario.FormattingEnabled = true;
            this.cbo_TipoDeUsuario.Location = new System.Drawing.Point(146, 237);
            this.cbo_TipoDeUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_TipoDeUsuario.Name = "cbo_TipoDeUsuario";
            this.cbo_TipoDeUsuario.Size = new System.Drawing.Size(100, 22);
            this.cbo_TipoDeUsuario.TabIndex = 33;
            // 
            // lbl_TipoDeUsuario
            // 
            this.lbl_TipoDeUsuario.AutoSize = true;
            this.lbl_TipoDeUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoDeUsuario.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_TipoDeUsuario.Location = new System.Drawing.Point(13, 243);
            this.lbl_TipoDeUsuario.Name = "lbl_TipoDeUsuario";
            this.lbl_TipoDeUsuario.Size = new System.Drawing.Size(93, 14);
            this.lbl_TipoDeUsuario.TabIndex = 32;
            this.lbl_TipoDeUsuario.Text = "Tipo de usuario";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbl_Estado.Location = new System.Drawing.Point(13, 279);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(44, 14);
            this.lbl_Estado.TabIndex = 34;
            this.lbl_Estado.Text = "Estado";
            // 
            // cbo_Estado
            // 
            this.cbo_Estado.BackColor = System.Drawing.Color.Black;
            this.cbo_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Estado.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Estado.ForeColor = System.Drawing.Color.OliveDrab;
            this.cbo_Estado.FormattingEnabled = true;
            this.cbo_Estado.Location = new System.Drawing.Point(146, 272);
            this.cbo_Estado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbo_Estado.Name = "cbo_Estado";
            this.cbo_Estado.Size = new System.Drawing.Size(100, 22);
            this.cbo_Estado.TabIndex = 35;
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(295, 459);
            this.Controls.Add(this.cbo_Estado);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.cbo_TipoDeUsuario);
            this.Controls.Add(this.lbl_TipoDeUsuario);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.cbo_Usuarios);
            this.Controls.Add(this.lbl_UsuarioAEditar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_ContraseñaRepetida);
            this.Controls.Add(this.txt_NuevoUsuario);
            this.Controls.Add(this.lbl_ContraseñaRepetida);
            this.Controls.Add(this.lbl_Contraseña);
            this.Controls.Add(this.lbl_Usuario);
            this.Name = "FormEditarUsuario";
            this.Text = "FormEditarUsuario";
            this.Load += new System.EventHandler(this.FormEditarUsuario_Load);
            this.Controls.SetChildIndex(this.lbl_Usuario, 0);
            this.Controls.SetChildIndex(this.lbl_Contraseña, 0);
            this.Controls.SetChildIndex(this.lbl_ContraseñaRepetida, 0);
            this.Controls.SetChildIndex(this.txt_NuevoUsuario, 0);
            this.Controls.SetChildIndex(this.txt_ContraseñaRepetida, 0);
            this.Controls.SetChildIndex(this.txt_Contraseña, 0);
            this.Controls.SetChildIndex(this.lbl_Nombre, 0);
            this.Controls.SetChildIndex(this.txt_Nombre, 0);
            this.Controls.SetChildIndex(this.lbl_UsuarioAEditar, 0);
            this.Controls.SetChildIndex(this.cbo_Usuarios, 0);
            this.Controls.SetChildIndex(this.lbl_Titulo, 0);
            this.Controls.SetChildIndex(this.lbl_TipoDeUsuario, 0);
            this.Controls.SetChildIndex(this.cbo_TipoDeUsuario, 0);
            this.Controls.SetChildIndex(this.lbl_Estado, 0);
            this.Controls.SetChildIndex(this.cbo_Estado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_ContraseñaRepetida;
        private System.Windows.Forms.TextBox txt_NuevoUsuario;
        private System.Windows.Forms.Label lbl_ContraseñaRepetida;
        private System.Windows.Forms.Label lbl_Contraseña;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_UsuarioAEditar;
        private System.Windows.Forms.ComboBox cbo_Usuarios;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.ComboBox cbo_TipoDeUsuario;
        private System.Windows.Forms.Label lbl_TipoDeUsuario;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.ComboBox cbo_Estado;
    }
}