namespace Interfaz
{
    partial class FormGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.crt_GraficoTorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.crt_GraficoTorta)).BeginInit();
            this.SuspendLayout();
            // 
            // crt_GraficoTorta
            // 
            this.crt_GraficoTorta.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.crt_GraficoTorta.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crt_GraficoTorta.Legends.Add(legend1);
            this.crt_GraficoTorta.Location = new System.Drawing.Point(13, 81);
            this.crt_GraficoTorta.Name = "crt_GraficoTorta";
            this.crt_GraficoTorta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.crt_GraficoTorta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Consumo";
            series1.YValuesPerPoint = 2;
            this.crt_GraficoTorta.Series.Add(series1);
            this.crt_GraficoTorta.Size = new System.Drawing.Size(629, 298);
            this.crt_GraficoTorta.TabIndex = 13;
            // 
            // FormGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(654, 460);
            this.Controls.Add(this.crt_GraficoTorta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormGraficos";
            this.Text = "FormGraficos";
            this.Load += new System.EventHandler(this.FormGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crt_GraficoTorta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crt_GraficoTorta;
    }
}