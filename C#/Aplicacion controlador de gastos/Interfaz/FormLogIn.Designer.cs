namespace Interfaz
{
    partial class FormLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_IngresoRapido = new System.Windows.Forms.Button();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_NuevoUsuario = new System.Windows.Forms.Label();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Ingresar
            // 
            resources.ApplyResources(this.btn_Ingresar, "btn_Ingresar");
            this.btn_Ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // btn_IngresoRapido
            // 
            resources.ApplyResources(this.btn_IngresoRapido, "btn_IngresoRapido");
            this.btn_IngresoRapido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_IngresoRapido.Name = "btn_IngresoRapido";
            this.btn_IngresoRapido.UseVisualStyleBackColor = true;
            this.btn_IngresoRapido.Click += new System.EventHandler(this.btn_IngresoRapido_Click);
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_Contraseña, "txt_Contraseña");
            this.txt_Contraseña.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_Contraseña.Name = "txt_Contraseña";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.Black;
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_Usuario, "txt_Usuario");
            this.txt_Usuario.ForeColor = System.Drawing.SystemColors.Menu;
            this.txt_Usuario.Name = "txt_Usuario";
            // 
            // btn_Cancelar
            // 
            resources.ApplyResources(this.btn_Cancelar, "btn_Cancelar");
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.txt_Cancelar_Click);
            // 
            // lbl_NuevoUsuario
            // 
            resources.ApplyResources(this.lbl_NuevoUsuario, "lbl_NuevoUsuario");
            this.lbl_NuevoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NuevoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lbl_NuevoUsuario.Name = "lbl_NuevoUsuario";
            // 
            // btn_CrearUsuario
            // 
            resources.ApplyResources(this.btn_CrearUsuario, "btn_CrearUsuario");
            this.btn_CrearUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            this.btn_CrearUsuario.Click += new System.EventHandler(this.btn_CrearUsuario_Click);
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // FormLogIn
            // 
            this.AcceptButton = this.btn_Ingresar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.lbl_NuevoUsuario);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.btn_IngresoRapido);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormLogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_IngresoRapido;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_NuevoUsuario;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.Panel panel;
    }
}

