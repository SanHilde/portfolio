namespace Interfaz
{
    partial class FormMenuAdmin
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
            this.menu_Admin = new System.Windows.Forms.MenuStrip();
            this.menu_Agregar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Grafico = new System.Windows.Forms.ToolStripMenuItem();
            this.consumosPorTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_BaseDeDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Admin
            // 
            this.menu_Admin.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_Admin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Agregar,
            this.menu_Editar,
            this.menu_Grafico,
            this.menu_BaseDeDatos});
            this.menu_Admin.Location = new System.Drawing.Point(0, 0);
            this.menu_Admin.Name = "menu_Admin";
            this.menu_Admin.Size = new System.Drawing.Size(128, 491);
            this.menu_Admin.TabIndex = 0;
            this.menu_Admin.Text = "menuStrip1";
            // 
            // menu_Agregar
            // 
            this.menu_Agregar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Agregar.ForeColor = System.Drawing.Color.OliveDrab;
            this.menu_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Agregar.Name = "menu_Agregar";
            this.menu_Agregar.Size = new System.Drawing.Size(115, 23);
            this.menu_Agregar.Text = "Agregar admin";
            this.menu_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Agregar.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // menu_Editar
            // 
            this.menu_Editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Editar.ForeColor = System.Drawing.Color.OliveDrab;
            this.menu_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Editar.Name = "menu_Editar";
            this.menu_Editar.Size = new System.Drawing.Size(115, 23);
            this.menu_Editar.Text = "Editar usuario";
            this.menu_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Editar.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem_Click);
            // 
            // menu_Grafico
            // 
            this.menu_Grafico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumosPorTipoToolStripMenuItem});
            this.menu_Grafico.ForeColor = System.Drawing.Color.OliveDrab;
            this.menu_Grafico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_Grafico.Name = "menu_Grafico";
            this.menu_Grafico.Size = new System.Drawing.Size(115, 23);
            this.menu_Grafico.Text = "Ver graficos";
            this.menu_Grafico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // consumosPorTipoToolStripMenuItem
            // 
            this.consumosPorTipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosUsuariosToolStripMenuItem});
            this.consumosPorTipoToolStripMenuItem.Name = "consumosPorTipoToolStripMenuItem";
            this.consumosPorTipoToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.consumosPorTipoToolStripMenuItem.Text = "Consumos por tipo";
            // 
            // todosLosUsuariosToolStripMenuItem
            // 
            this.todosLosUsuariosToolStripMenuItem.Name = "todosLosUsuariosToolStripMenuItem";
            this.todosLosUsuariosToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.todosLosUsuariosToolStripMenuItem.Text = "Todos los usuarios";
            this.todosLosUsuariosToolStripMenuItem.Click += new System.EventHandler(this.todosLosUsuariosToolStripMenuItem_Click);
            // 
            // menu_BaseDeDatos
            // 
            this.menu_BaseDeDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem,
            this.fireBaseToolStripMenuItem});
            this.menu_BaseDeDatos.Name = "menu_BaseDeDatos";
            this.menu_BaseDeDatos.Size = new System.Drawing.Size(115, 23);
            this.menu_BaseDeDatos.Text = "Base de datos";
            this.menu_BaseDeDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // fireBaseToolStripMenuItem
            // 
            this.fireBaseToolStripMenuItem.Name = "fireBaseToolStripMenuItem";
            this.fireBaseToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.fireBaseToolStripMenuItem.Text = "FireBase";
            this.fireBaseToolStripMenuItem.Click += new System.EventHandler(this.fireBaseToolStripMenuItem_Click);
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(804, 491);
            this.Controls.Add(this.menu_Admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormMenuAdmin_Load);
            this.menu_Admin.ResumeLayout(false);
            this.menu_Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Admin;
        private System.Windows.Forms.ToolStripMenuItem menu_Agregar;
        private System.Windows.Forms.ToolStripMenuItem menu_Editar;
        private System.Windows.Forms.ToolStripMenuItem menu_Grafico;
        private System.Windows.Forms.ToolStripMenuItem consumosPorTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_BaseDeDatos;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireBaseToolStripMenuItem;
    }
}