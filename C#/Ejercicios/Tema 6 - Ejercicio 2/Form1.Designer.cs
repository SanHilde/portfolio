namespace Tema_6___Ejercicio_2
{
    partial class Form1
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.radNoBinario = new System.Windows.Forms.RadioButton();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.chkTres = new System.Windows.Forms.CheckBox();
            this.chkDos = new System.Windows.Forms.CheckBox();
            this.chkUno = new System.Windows.Forms.CheckBox();
            this.grpDetallesDelUsuario = new System.Windows.Forms.GroupBox();
            this.lvlEdad = new System.Windows.Forms.Label();
            this.lvlDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nupEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstPais = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.grpGenero.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.grpDetallesDelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIngresar.Location = new System.Drawing.Point(294, 263);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 25);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.radNoBinario);
            this.grpGenero.Controls.Add(this.radFemenino);
            this.grpGenero.Controls.Add(this.radMasculino);
            this.grpGenero.Location = new System.Drawing.Point(273, 25);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(115, 100);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Genero";
            // 
            // radNoBinario
            // 
            this.radNoBinario.AutoSize = true;
            this.radNoBinario.Location = new System.Drawing.Point(21, 68);
            this.radNoBinario.Name = "radNoBinario";
            this.radNoBinario.Size = new System.Drawing.Size(73, 17);
            this.radNoBinario.TabIndex = 2;
            this.radNoBinario.TabStop = true;
            this.radNoBinario.Text = "No binario";
            this.radNoBinario.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Location = new System.Drawing.Point(21, 44);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(71, 17);
            this.radFemenino.TabIndex = 1;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(21, 20);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(73, 17);
            this.radMasculino.TabIndex = 0;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.chkTres);
            this.grpCursos.Controls.Add(this.chkDos);
            this.grpCursos.Controls.Add(this.chkUno);
            this.grpCursos.Location = new System.Drawing.Point(273, 142);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(115, 103);
            this.grpCursos.TabIndex = 2;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Cursos";
            // 
            // chkTres
            // 
            this.chkTres.AutoSize = true;
            this.chkTres.Location = new System.Drawing.Point(21, 72);
            this.chkTres.Name = "chkTres";
            this.chkTres.Size = new System.Drawing.Size(76, 17);
            this.chkTres.TabIndex = 2;
            this.chkTres.Text = "JavaScript";
            this.chkTres.UseVisualStyleBackColor = true;
            // 
            // chkDos
            // 
            this.chkDos.AutoSize = true;
            this.chkDos.Location = new System.Drawing.Point(21, 48);
            this.chkDos.Name = "chkDos";
            this.chkDos.Size = new System.Drawing.Size(45, 17);
            this.chkDos.TabIndex = 1;
            this.chkDos.Text = "C++";
            this.chkDos.UseVisualStyleBackColor = true;
            // 
            // chkUno
            // 
            this.chkUno.AutoSize = true;
            this.chkUno.Location = new System.Drawing.Point(21, 24);
            this.chkUno.Name = "chkUno";
            this.chkUno.Size = new System.Drawing.Size(40, 17);
            this.chkUno.TabIndex = 0;
            this.chkUno.Text = "C#";
            this.chkUno.UseVisualStyleBackColor = true;
            // 
            // grpDetallesDelUsuario
            // 
            this.grpDetallesDelUsuario.Controls.Add(this.lvlEdad);
            this.grpDetallesDelUsuario.Controls.Add(this.lvlDireccion);
            this.grpDetallesDelUsuario.Controls.Add(this.lblNombre);
            this.grpDetallesDelUsuario.Controls.Add(this.nupEdad);
            this.grpDetallesDelUsuario.Controls.Add(this.txtDireccion);
            this.grpDetallesDelUsuario.Controls.Add(this.txtNombre);
            this.grpDetallesDelUsuario.Location = new System.Drawing.Point(23, 25);
            this.grpDetallesDelUsuario.Name = "grpDetallesDelUsuario";
            this.grpDetallesDelUsuario.Size = new System.Drawing.Size(186, 145);
            this.grpDetallesDelUsuario.TabIndex = 3;
            this.grpDetallesDelUsuario.TabStop = false;
            this.grpDetallesDelUsuario.Text = "Detalles del usuario";
            // 
            // lvlEdad
            // 
            this.lvlEdad.AutoSize = true;
            this.lvlEdad.Location = new System.Drawing.Point(10, 111);
            this.lvlEdad.Name = "lvlEdad";
            this.lvlEdad.Size = new System.Drawing.Size(32, 13);
            this.lvlEdad.TabIndex = 5;
            this.lvlEdad.Text = "Edad";
            // 
            // lvlDireccion
            // 
            this.lvlDireccion.AutoSize = true;
            this.lvlDireccion.Location = new System.Drawing.Point(10, 72);
            this.lvlDireccion.Name = "lvlDireccion";
            this.lvlDireccion.Size = new System.Drawing.Size(52, 13);
            this.lvlDireccion.TabIndex = 4;
            this.lvlDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // nupEdad
            // 
            this.nupEdad.Location = new System.Drawing.Point(64, 109);
            this.nupEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nupEdad.Name = "nupEdad";
            this.nupEdad.Size = new System.Drawing.Size(100, 20);
            this.nupEdad.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(64, 69);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lstPais
            // 
            this.lstPais.FormattingEnabled = true;
            this.lstPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lstPais.Location = new System.Drawing.Point(23, 203);
            this.lstPais.Name = "lstPais";
            this.lstPais.Size = new System.Drawing.Size(186, 82);
            this.lstPais.TabIndex = 4;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(23, 182);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "Pais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 306);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lstPais);
            this.Controls.Add(this.grpDetallesDelUsuario);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Registro";
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.grpDetallesDelUsuario.ResumeLayout(false);
            this.grpDetallesDelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton radNoBinario;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.CheckBox chkTres;
        private System.Windows.Forms.CheckBox chkDos;
        private System.Windows.Forms.CheckBox chkUno;
        private System.Windows.Forms.GroupBox grpDetallesDelUsuario;
        private System.Windows.Forms.Label lvlEdad;
        private System.Windows.Forms.Label lvlDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nupEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstPais;
        private System.Windows.Forms.Label lblPais;
    }
}

