namespace Interfaz
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnu_MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnu_ComenzarMes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ConsumoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ConsumoPagado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_EditarDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_EditarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_EditarObjetivo = new System.Windows.Forms.ToolStripMenuItem();
            this.consumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Detalles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SubMenuVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SubMenuRojo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SubMenuAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarTemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SubMenuClaro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_SubMenuOscuro = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Saludo = new System.Windows.Forms.Label();
            this.crt_GraficoTorta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pic_BarraLateral = new System.Windows.Forms.PictureBox();
            this.prb_Mes = new System.Windows.Forms.ProgressBar();
            this.lbl_Ciclo = new System.Windows.Forms.Label();
            this.prb_Consumo = new System.Windows.Forms.ProgressBar();
            this.lbl_Progreso = new System.Windows.Forms.Label();
            this.rch_Datos = new System.Windows.Forms.RichTextBox();
            this.pnl_Datos = new System.Windows.Forms.Panel();
            this.pnl_Pagos = new System.Windows.Forms.Panel();
            this.rch_Pagos = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Saludo = new System.Windows.Forms.Panel();
            this.mnu_MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crt_GraficoTorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BarraLateral)).BeginInit();
            this.pnl_Pagos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Saludo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_MenuPrincipal
            // 
            this.mnu_MenuPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mnu_MenuPrincipal.AutoSize = false;
            this.mnu_MenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.mnu_MenuPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.mnu_MenuPrincipal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_MenuPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.mnu_MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ComenzarMes,
            this.mnu_ConsumoNuevo,
            this.mnu_ConsumoPagado,
            this.mnu_EditarDatos,
            this.mnu_Detalles,
            this.mnu_Guardar,
            this.mnu_Configuracion});
            this.mnu_MenuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnu_MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnu_MenuPrincipal.Name = "mnu_MenuPrincipal";
            this.mnu_MenuPrincipal.Padding = new System.Windows.Forms.Padding(6, 6, 0, 2);
            this.mnu_MenuPrincipal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnu_MenuPrincipal.ShowItemToolTips = true;
            this.mnu_MenuPrincipal.Size = new System.Drawing.Size(60, 565);
            this.mnu_MenuPrincipal.TabIndex = 2;
            this.mnu_MenuPrincipal.Text = "menuStrip1";
            // 
            // mnu_ComenzarMes
            // 
            this.mnu_ComenzarMes.AccessibleDescription = "";
            this.mnu_ComenzarMes.AccessibleName = "";
            this.mnu_ComenzarMes.AutoToolTip = true;
            this.mnu_ComenzarMes.BackColor = System.Drawing.Color.Transparent;
            this.mnu_ComenzarMes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnu_ComenzarMes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_ComenzarMes.ForeColor = System.Drawing.Color.White;
            this.mnu_ComenzarMes.Image = ((System.Drawing.Image)(resources.GetObject("mnu_ComenzarMes.Image")));
            this.mnu_ComenzarMes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_ComenzarMes.ImageTransparentColor = System.Drawing.Color.Coral;
            this.mnu_ComenzarMes.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.mnu_ComenzarMes.Name = "mnu_ComenzarMes";
            this.mnu_ComenzarMes.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_ComenzarMes.Size = new System.Drawing.Size(53, 29);
            this.mnu_ComenzarMes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_ComenzarMes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_ComenzarMes.ToolTipText = "Comienza un nuevo mes";
            this.mnu_ComenzarMes.Click += new System.EventHandler(this.mnu_ComenzarMes_Click);
            // 
            // mnu_ConsumoNuevo
            // 
            this.mnu_ConsumoNuevo.AccessibleDescription = "";
            this.mnu_ConsumoNuevo.AutoToolTip = true;
            this.mnu_ConsumoNuevo.BackColor = System.Drawing.Color.Transparent;
            this.mnu_ConsumoNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnu_ConsumoNuevo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_ConsumoNuevo.ForeColor = System.Drawing.Color.White;
            this.mnu_ConsumoNuevo.Image = ((System.Drawing.Image)(resources.GetObject("mnu_ConsumoNuevo.Image")));
            this.mnu_ConsumoNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_ConsumoNuevo.ImageTransparentColor = System.Drawing.Color.Coral;
            this.mnu_ConsumoNuevo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.mnu_ConsumoNuevo.Name = "mnu_ConsumoNuevo";
            this.mnu_ConsumoNuevo.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_ConsumoNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnu_ConsumoNuevo.Size = new System.Drawing.Size(53, 34);
            this.mnu_ConsumoNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_ConsumoNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_ConsumoNuevo.ToolTipText = "Carga un consumo nuevo";
            this.mnu_ConsumoNuevo.Click += new System.EventHandler(this.mnu_ConsumoNuevo_Click);
            // 
            // mnu_ConsumoPagado
            // 
            this.mnu_ConsumoPagado.AccessibleDescription = "";
            this.mnu_ConsumoPagado.AutoToolTip = true;
            this.mnu_ConsumoPagado.BackColor = System.Drawing.Color.Transparent;
            this.mnu_ConsumoPagado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnu_ConsumoPagado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_ConsumoPagado.ForeColor = System.Drawing.Color.White;
            this.mnu_ConsumoPagado.Image = ((System.Drawing.Image)(resources.GetObject("mnu_ConsumoPagado.Image")));
            this.mnu_ConsumoPagado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_ConsumoPagado.ImageTransparentColor = System.Drawing.Color.Coral;
            this.mnu_ConsumoPagado.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.mnu_ConsumoPagado.Name = "mnu_ConsumoPagado";
            this.mnu_ConsumoPagado.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_ConsumoPagado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnu_ConsumoPagado.Size = new System.Drawing.Size(53, 34);
            this.mnu_ConsumoPagado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_ConsumoPagado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_ConsumoPagado.ToolTipText = "Cambia el valor de pagado/no pagado de un consumo";
            this.mnu_ConsumoPagado.Click += new System.EventHandler(this.mnu_ConsumoPagado_Click);
            // 
            // mnu_EditarDatos
            // 
            this.mnu_EditarDatos.AccessibleDescription = "";
            this.mnu_EditarDatos.AutoToolTip = true;
            this.mnu_EditarDatos.BackColor = System.Drawing.Color.Transparent;
            this.mnu_EditarDatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnu_EditarDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_EditarCategorias,
            this.mnu_EditarObjetivo,
            this.consumoToolStripMenuItem,
            this.sueldoToolStripMenuItem});
            this.mnu_EditarDatos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_EditarDatos.ForeColor = System.Drawing.Color.White;
            this.mnu_EditarDatos.Image = ((System.Drawing.Image)(resources.GetObject("mnu_EditarDatos.Image")));
            this.mnu_EditarDatos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_EditarDatos.ImageTransparentColor = System.Drawing.Color.Coral;
            this.mnu_EditarDatos.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.mnu_EditarDatos.Name = "mnu_EditarDatos";
            this.mnu_EditarDatos.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_EditarDatos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnu_EditarDatos.Size = new System.Drawing.Size(53, 34);
            this.mnu_EditarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_EditarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_EditarDatos.ToolTipText = "Edita datos";
            // 
            // mnu_EditarCategorias
            // 
            this.mnu_EditarCategorias.AutoToolTip = true;
            this.mnu_EditarCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.mnu_EditarCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnu_EditarCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnu_EditarCategorias.ForeColor = System.Drawing.Color.White;
            this.mnu_EditarCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_EditarCategorias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_EditarCategorias.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnu_EditarCategorias.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.mnu_EditarCategorias.Name = "mnu_EditarCategorias";
            this.mnu_EditarCategorias.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_EditarCategorias.Size = new System.Drawing.Size(180, 20);
            this.mnu_EditarCategorias.Text = "Categorias";
            this.mnu_EditarCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_EditarCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_EditarCategorias.ToolTipText = "Edita las categorias";
            this.mnu_EditarCategorias.Click += new System.EventHandler(this.mnu_EditarCategorias_Click);
            // 
            // mnu_EditarObjetivo
            // 
            this.mnu_EditarObjetivo.AutoToolTip = true;
            this.mnu_EditarObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.mnu_EditarObjetivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnu_EditarObjetivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnu_EditarObjetivo.ForeColor = System.Drawing.Color.White;
            this.mnu_EditarObjetivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_EditarObjetivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_EditarObjetivo.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnu_EditarObjetivo.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.mnu_EditarObjetivo.Name = "mnu_EditarObjetivo";
            this.mnu_EditarObjetivo.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_EditarObjetivo.Size = new System.Drawing.Size(180, 20);
            this.mnu_EditarObjetivo.Text = "Objetivo";
            this.mnu_EditarObjetivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_EditarObjetivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_EditarObjetivo.ToolTipText = "Editar el objetivo de ahorro";
            this.mnu_EditarObjetivo.Click += new System.EventHandler(this.mnu_EditarObjetivo_Click);
            // 
            // consumoToolStripMenuItem
            // 
            this.consumoToolStripMenuItem.Name = "consumoToolStripMenuItem";
            this.consumoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consumoToolStripMenuItem.Text = "Consumo";
            this.consumoToolStripMenuItem.Click += new System.EventHandler(this.consumoToolStripMenuItem_Click);
            // 
            // sueldoToolStripMenuItem
            // 
            this.sueldoToolStripMenuItem.Name = "sueldoToolStripMenuItem";
            this.sueldoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sueldoToolStripMenuItem.Text = "Sueldo";
            this.sueldoToolStripMenuItem.Click += new System.EventHandler(this.sueldoToolStripMenuItem_Click);
            // 
            // mnu_Detalles
            // 
            this.mnu_Detalles.AccessibleDescription = "";
            this.mnu_Detalles.AutoToolTip = true;
            this.mnu_Detalles.BackColor = System.Drawing.Color.Transparent;
            this.mnu_Detalles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnu_Detalles.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_Detalles.ForeColor = System.Drawing.Color.White;
            this.mnu_Detalles.Image = ((System.Drawing.Image)(resources.GetObject("mnu_Detalles.Image")));
            this.mnu_Detalles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_Detalles.ImageTransparentColor = System.Drawing.Color.Coral;
            this.mnu_Detalles.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.mnu_Detalles.Name = "mnu_Detalles";
            this.mnu_Detalles.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_Detalles.Size = new System.Drawing.Size(53, 34);
            this.mnu_Detalles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_Detalles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_Detalles.ToolTipText = "Detalles del mes";
            this.mnu_Detalles.Click += new System.EventHandler(this.detallesDelMesToolStripMenuItem_Click);
            // 
            // mnu_Guardar
            // 
            this.mnu_Guardar.AccessibleDescription = "";
            this.mnu_Guardar.AutoToolTip = true;
            this.mnu_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.mnu_Guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnu_Guardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_Guardar.ForeColor = System.Drawing.Color.White;
            this.mnu_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("mnu_Guardar.Image")));
            this.mnu_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_Guardar.ImageTransparentColor = System.Drawing.Color.Coral;
            this.mnu_Guardar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.mnu_Guardar.Name = "mnu_Guardar";
            this.mnu_Guardar.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_Guardar.Size = new System.Drawing.Size(53, 34);
            this.mnu_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_Guardar.ToolTipText = "Guardar cambios";
            this.mnu_Guardar.Click += new System.EventHandler(this.guardarCambiosToolStripMenuItem_Click);
            // 
            // mnu_Configuracion
            // 
            this.mnu_Configuracion.AutoToolTip = true;
            this.mnu_Configuracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnu_Configuracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarColorToolStripMenuItem,
            this.personalizarTemaToolStripMenuItem,
            this.restaurarBackupToolStripMenuItem});
            this.mnu_Configuracion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu_Configuracion.Image = ((System.Drawing.Image)(resources.GetObject("mnu_Configuracion.Image")));
            this.mnu_Configuracion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_Configuracion.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.mnu_Configuracion.Name = "mnu_Configuracion";
            this.mnu_Configuracion.Padding = new System.Windows.Forms.Padding(0);
            this.mnu_Configuracion.Size = new System.Drawing.Size(53, 34);
            this.mnu_Configuracion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnu_Configuracion.ToolTipText = "Configuracion";
            // 
            // personalizarColorToolStripMenuItem
            // 
            this.personalizarColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_SubMenuVerde,
            this.mnu_SubMenuRojo,
            this.mnu_SubMenuAzul});
            this.personalizarColorToolStripMenuItem.Name = "personalizarColorToolStripMenuItem";
            this.personalizarColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personalizarColorToolStripMenuItem.Text = "Personalizar color";
            // 
            // mnu_SubMenuVerde
            // 
            this.mnu_SubMenuVerde.Name = "mnu_SubMenuVerde";
            this.mnu_SubMenuVerde.Size = new System.Drawing.Size(104, 22);
            this.mnu_SubMenuVerde.Text = "Verde";
            this.mnu_SubMenuVerde.Click += new System.EventHandler(this.mnu_SubMenuVerde_Click);
            // 
            // mnu_SubMenuRojo
            // 
            this.mnu_SubMenuRojo.Name = "mnu_SubMenuRojo";
            this.mnu_SubMenuRojo.Size = new System.Drawing.Size(104, 22);
            this.mnu_SubMenuRojo.Text = "Rojo";
            this.mnu_SubMenuRojo.Click += new System.EventHandler(this.mnu_SubMenuRojo_Click);
            // 
            // mnu_SubMenuAzul
            // 
            this.mnu_SubMenuAzul.Name = "mnu_SubMenuAzul";
            this.mnu_SubMenuAzul.Size = new System.Drawing.Size(104, 22);
            this.mnu_SubMenuAzul.Text = "Azul";
            this.mnu_SubMenuAzul.Click += new System.EventHandler(this.mnu_SubMenuAzul_Click);
            // 
            // personalizarTemaToolStripMenuItem
            // 
            this.personalizarTemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_SubMenuClaro,
            this.mnu_SubMenuOscuro});
            this.personalizarTemaToolStripMenuItem.Name = "personalizarTemaToolStripMenuItem";
            this.personalizarTemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personalizarTemaToolStripMenuItem.Text = "Personalizar tema";
            // 
            // mnu_SubMenuClaro
            // 
            this.mnu_SubMenuClaro.Name = "mnu_SubMenuClaro";
            this.mnu_SubMenuClaro.Size = new System.Drawing.Size(114, 22);
            this.mnu_SubMenuClaro.Text = "Claro";
            this.mnu_SubMenuClaro.Click += new System.EventHandler(this.mnu_SubMenuClaro_Click);
            // 
            // mnu_SubMenuOscuro
            // 
            this.mnu_SubMenuOscuro.Name = "mnu_SubMenuOscuro";
            this.mnu_SubMenuOscuro.Size = new System.Drawing.Size(114, 22);
            this.mnu_SubMenuOscuro.Text = "Oscuro";
            this.mnu_SubMenuOscuro.Click += new System.EventHandler(this.mnu_SubMenuOscuro_Click);
            // 
            // restaurarBackupToolStripMenuItem
            // 
            this.restaurarBackupToolStripMenuItem.Name = "restaurarBackupToolStripMenuItem";
            this.restaurarBackupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurarBackupToolStripMenuItem.Text = "Restaurar backup";
            this.restaurarBackupToolStripMenuItem.Click += new System.EventHandler(this.restaurarBackupToolStripMenuItem_Click);
            // 
            // lbl_Saludo
            // 
            this.lbl_Saludo.AutoSize = true;
            this.lbl_Saludo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Saludo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saludo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            this.lbl_Saludo.Location = new System.Drawing.Point(128, 24);
            this.lbl_Saludo.Name = "lbl_Saludo";
            this.lbl_Saludo.Size = new System.Drawing.Size(70, 26);
            this.lbl_Saludo.TabIndex = 4;
            this.lbl_Saludo.Text = "Saludo";
            this.lbl_Saludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crt_GraficoTorta
            // 
            this.crt_GraficoTorta.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Transparent;
            this.crt_GraficoTorta.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.crt_GraficoTorta.Legends.Add(legend2);
            this.crt_GraficoTorta.Location = new System.Drawing.Point(-1, -1);
            this.crt_GraficoTorta.Name = "crt_GraficoTorta";
            this.crt_GraficoTorta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.crt_GraficoTorta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Consumo";
            series2.YValuesPerPoint = 2;
            this.crt_GraficoTorta.Series.Add(series2);
            this.crt_GraficoTorta.Size = new System.Drawing.Size(745, 298);
            this.crt_GraficoTorta.TabIndex = 12;
            // 
            // pic_BarraLateral
            // 
            this.pic_BarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pic_BarraLateral.Location = new System.Drawing.Point(60, 0);
            this.pic_BarraLateral.Name = "pic_BarraLateral";
            this.pic_BarraLateral.Size = new System.Drawing.Size(1, 565);
            this.pic_BarraLateral.TabIndex = 31;
            this.pic_BarraLateral.TabStop = false;
            // 
            // prb_Mes
            // 
            this.prb_Mes.BackColor = System.Drawing.Color.White;
            this.prb_Mes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(31)))));
            this.prb_Mes.Location = new System.Drawing.Point(457, 27);
            this.prb_Mes.Name = "prb_Mes";
            this.prb_Mes.Size = new System.Drawing.Size(347, 21);
            this.prb_Mes.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prb_Mes.TabIndex = 35;
            // 
            // lbl_Ciclo
            // 
            this.lbl_Ciclo.AutoSize = true;
            this.lbl_Ciclo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ciclo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciclo.ForeColor = System.Drawing.Color.White;
            this.lbl_Ciclo.Location = new System.Drawing.Point(239, 11);
            this.lbl_Ciclo.Name = "lbl_Ciclo";
            this.lbl_Ciclo.Size = new System.Drawing.Size(102, 15);
            this.lbl_Ciclo.TabIndex = 36;
            this.lbl_Ciclo.Text = "Progreso del mes";
            // 
            // prb_Consumo
            // 
            this.prb_Consumo.BackColor = System.Drawing.Color.White;
            this.prb_Consumo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prb_Consumo.Location = new System.Drawing.Point(457, 55);
            this.prb_Consumo.Name = "prb_Consumo";
            this.prb_Consumo.Size = new System.Drawing.Size(347, 21);
            this.prb_Consumo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prb_Consumo.TabIndex = 37;
            // 
            // lbl_Progreso
            // 
            this.lbl_Progreso.AutoSize = true;
            this.lbl_Progreso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Progreso.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Progreso.ForeColor = System.Drawing.Color.White;
            this.lbl_Progreso.Location = new System.Drawing.Point(323, 58);
            this.lbl_Progreso.Name = "lbl_Progreso";
            this.lbl_Progreso.Size = new System.Drawing.Size(125, 15);
            this.lbl_Progreso.TabIndex = 38;
            this.lbl_Progreso.Text = "Progreso de consumo";
            // 
            // rch_Datos
            // 
            this.rch_Datos.BackColor = System.Drawing.Color.Black;
            this.rch_Datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rch_Datos.BulletIndent = 5;
            this.rch_Datos.Cursor = System.Windows.Forms.Cursors.Default;
            this.rch_Datos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_Datos.ForeColor = System.Drawing.Color.White;
            this.rch_Datos.Location = new System.Drawing.Point(99, 429);
            this.rch_Datos.Name = "rch_Datos";
            this.rch_Datos.ReadOnly = true;
            this.rch_Datos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rch_Datos.Size = new System.Drawing.Size(337, 111);
            this.rch_Datos.TabIndex = 40;
            this.rch_Datos.Text = "Datos";
            // 
            // pnl_Datos
            // 
            this.pnl_Datos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Datos.Location = new System.Drawing.Point(83, 420);
            this.pnl_Datos.Name = "pnl_Datos";
            this.pnl_Datos.Size = new System.Drawing.Size(367, 123);
            this.pnl_Datos.TabIndex = 41;
            // 
            // pnl_Pagos
            // 
            this.pnl_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Pagos.Controls.Add(this.rch_Pagos);
            this.pnl_Pagos.Location = new System.Drawing.Point(475, 420);
            this.pnl_Pagos.Name = "pnl_Pagos";
            this.pnl_Pagos.Size = new System.Drawing.Size(339, 123);
            this.pnl_Pagos.TabIndex = 42;
            // 
            // rch_Pagos
            // 
            this.rch_Pagos.BackColor = System.Drawing.Color.Black;
            this.rch_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rch_Pagos.BulletIndent = 5;
            this.rch_Pagos.Cursor = System.Windows.Forms.Cursors.Default;
            this.rch_Pagos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_Pagos.ForeColor = System.Drawing.Color.White;
            this.rch_Pagos.Location = new System.Drawing.Point(15, 8);
            this.rch_Pagos.Name = "rch_Pagos";
            this.rch_Pagos.ReadOnly = true;
            this.rch_Pagos.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rch_Pagos.Size = new System.Drawing.Size(313, 110);
            this.rch_Pagos.TabIndex = 44;
            this.rch_Pagos.Text = "Gastos";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.crt_GraficoTorta);
            this.panel2.Location = new System.Drawing.Point(83, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 300);
            this.panel2.TabIndex = 43;
            // 
            // pnl_Saludo
            // 
            this.pnl_Saludo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Saludo.Controls.Add(this.lbl_Ciclo);
            this.pnl_Saludo.Location = new System.Drawing.Point(83, 20);
            this.pnl_Saludo.Name = "pnl_Saludo";
            this.pnl_Saludo.Size = new System.Drawing.Size(731, 64);
            this.pnl_Saludo.TabIndex = 43;
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 565);
            this.Controls.Add(this.lbl_Progreso);
            this.Controls.Add(this.prb_Consumo);
            this.Controls.Add(this.prb_Mes);
            this.Controls.Add(this.lbl_Saludo);
            this.Controls.Add(this.pic_BarraLateral);
            this.Controls.Add(this.mnu_MenuPrincipal);
            this.Controls.Add(this.rch_Datos);
            this.Controls.Add(this.pnl_Datos);
            this.Controls.Add(this.pnl_Pagos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Saludo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de gastos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.mnu_MenuPrincipal.ResumeLayout(false);
            this.mnu_MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crt_GraficoTorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BarraLateral)).EndInit();
            this.pnl_Pagos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_Saludo.ResumeLayout(false);
            this.pnl_Saludo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnu_MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnu_ComenzarMes;
        private System.Windows.Forms.ToolStripMenuItem mnu_ConsumoNuevo;
        private System.Windows.Forms.ToolStripMenuItem mnu_ConsumoPagado;
        private System.Windows.Forms.ToolStripMenuItem mnu_EditarDatos;
        private System.Windows.Forms.ToolStripMenuItem mnu_EditarCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnu_EditarObjetivo;
        private System.Windows.Forms.Label lbl_Saludo;
        private System.Windows.Forms.ToolStripMenuItem mnu_Detalles;
        private System.Windows.Forms.ToolStripMenuItem mnu_Guardar;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_GraficoTorta;
        private System.Windows.Forms.PictureBox pic_BarraLateral;
        private System.Windows.Forms.ProgressBar prb_Mes;
        private System.Windows.Forms.Label lbl_Ciclo;
        private System.Windows.Forms.ProgressBar prb_Consumo;
        private System.Windows.Forms.Label lbl_Progreso;
        private System.Windows.Forms.RichTextBox rch_Datos;
        private System.Windows.Forms.Panel pnl_Datos;
        private System.Windows.Forms.Panel pnl_Pagos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Saludo;
        private System.Windows.Forms.RichTextBox rch_Pagos;
        private System.Windows.Forms.ToolStripMenuItem mnu_Configuracion;
        private System.Windows.Forms.ToolStripMenuItem personalizarTemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_SubMenuVerde;
        private System.Windows.Forms.ToolStripMenuItem mnu_SubMenuRojo;
        private System.Windows.Forms.ToolStripMenuItem mnu_SubMenuAzul;
        private System.Windows.Forms.ToolStripMenuItem mnu_SubMenuClaro;
        private System.Windows.Forms.ToolStripMenuItem mnu_SubMenuOscuro;
        private System.Windows.Forms.ToolStripMenuItem consumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoToolStripMenuItem;
    }
}