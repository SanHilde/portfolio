namespace Tema_6___Ejercicio_5
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
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.btnBinarioDecimal = new System.Windows.Forms.Button();
            this.btnDecimalBinario = new System.Windows.Forms.Button();
            this.txtBinarioDecimalIngreso = new System.Windows.Forms.TextBox();
            this.txtDecimalBinarioIngreso = new System.Windows.Forms.TextBox();
            this.txtBinarioDecimalResp = new System.Windows.Forms.TextBox();
            this.txtDecimalBinarioResp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Location = new System.Drawing.Point(12, 22);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(89, 13);
            this.lblBinario.TabIndex = 0;
            this.lblBinario.Text = "Binario a Decimal";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(12, 48);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(89, 13);
            this.lblDecimal.TabIndex = 1;
            this.lblDecimal.Text = "Decimal a Binario";
            // 
            // btnBinarioDecimal
            // 
            this.btnBinarioDecimal.Location = new System.Drawing.Point(223, 17);
            this.btnBinarioDecimal.Name = "btnBinarioDecimal";
            this.btnBinarioDecimal.Size = new System.Drawing.Size(75, 23);
            this.btnBinarioDecimal.TabIndex = 2;
            this.btnBinarioDecimal.Text = "->";
            this.btnBinarioDecimal.UseVisualStyleBackColor = true;
            this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
            // 
            // btnDecimalBinario
            // 
            this.btnDecimalBinario.Location = new System.Drawing.Point(223, 42);
            this.btnDecimalBinario.Name = "btnDecimalBinario";
            this.btnDecimalBinario.Size = new System.Drawing.Size(75, 23);
            this.btnDecimalBinario.TabIndex = 3;
            this.btnDecimalBinario.Text = "->";
            this.btnDecimalBinario.UseVisualStyleBackColor = true;
            this.btnDecimalBinario.Click += new System.EventHandler(this.btnDecimalBinario_Click);
            // 
            // txtBinarioDecimalIngreso
            // 
            this.txtBinarioDecimalIngreso.Location = new System.Drawing.Point(105, 19);
            this.txtBinarioDecimalIngreso.Name = "txtBinarioDecimalIngreso";
            this.txtBinarioDecimalIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtBinarioDecimalIngreso.TabIndex = 4;
            // 
            // txtDecimalBinarioIngreso
            // 
            this.txtDecimalBinarioIngreso.Location = new System.Drawing.Point(105, 45);
            this.txtDecimalBinarioIngreso.Name = "txtDecimalBinarioIngreso";
            this.txtDecimalBinarioIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtDecimalBinarioIngreso.TabIndex = 5;
            // 
            // txtBinarioDecimalResp
            // 
            this.txtBinarioDecimalResp.Location = new System.Drawing.Point(318, 20);
            this.txtBinarioDecimalResp.Name = "txtBinarioDecimalResp";
            this.txtBinarioDecimalResp.Size = new System.Drawing.Size(100, 20);
            this.txtBinarioDecimalResp.TabIndex = 6;
            // 
            // txtDecimalBinarioResp
            // 
            this.txtDecimalBinarioResp.Location = new System.Drawing.Point(318, 45);
            this.txtDecimalBinarioResp.Name = "txtDecimalBinarioResp";
            this.txtDecimalBinarioResp.Size = new System.Drawing.Size(100, 20);
            this.txtDecimalBinarioResp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 85);
            this.Controls.Add(this.txtDecimalBinarioResp);
            this.Controls.Add(this.txtBinarioDecimalResp);
            this.Controls.Add(this.txtDecimalBinarioIngreso);
            this.Controls.Add(this.txtBinarioDecimalIngreso);
            this.Controls.Add(this.btnDecimalBinario);
            this.Controls.Add(this.btnBinarioDecimal);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblBinario);
            this.Name = "Form1";
            this.Text = "Conversor numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.Button btnBinarioDecimal;
        private System.Windows.Forms.Button btnDecimalBinario;
        private System.Windows.Forms.TextBox txtBinarioDecimalIngreso;
        private System.Windows.Forms.TextBox txtDecimalBinarioIngreso;
        private System.Windows.Forms.TextBox txtBinarioDecimalResp;
        private System.Windows.Forms.TextBox txtDecimalBinarioResp;
    }
}

