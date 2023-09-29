<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mnu_MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuItem_Clientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_CargarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_BuscarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItem_Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_CargarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_BuscarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItem_Ventas = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_CrearVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubMenu_BuscarVenta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItem_Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.subMenuItem_ListadoDeProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.grp_Filtro = New System.Windows.Forms.GroupBox()
        Me.txt_Filtro = New System.Windows.Forms.TextBox()
        Me.rdb_filtroTres = New System.Windows.Forms.RadioButton()
        Me.rdb_filtroDos = New System.Windows.Forms.RadioButton()
        Me.rdb_filtroUno = New System.Windows.Forms.RadioButton()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.dta_Lista = New System.Windows.Forms.DataGridView()
        Me.time_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pic_linea2 = New System.Windows.Forms.PictureBox()
        Me.mnu_MenuPrincipal.SuspendLayout()
        Me.grp_Filtro.SuspendLayout()
        CType(Me.dta_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_linea2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnu_MenuPrincipal
        '
        Me.mnu_MenuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.mnu_MenuPrincipal.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuItem_Clientes, Me.mnuItem_Productos, Me.mnuItem_Ventas, Me.mnuItem_Reportes})
        Me.mnu_MenuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.mnu_MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnu_MenuPrincipal.Name = "mnu_MenuPrincipal"
        Me.mnu_MenuPrincipal.Size = New System.Drawing.Size(639, 28)
        Me.mnu_MenuPrincipal.TabIndex = 1
        Me.mnu_MenuPrincipal.Text = "MenuStrip1"
        '
        'mnuItem_Clientes
        '
        Me.mnuItem_Clientes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubMenu_CargarCliente, Me.SubMenu_BuscarCliente})
        Me.mnuItem_Clientes.ForeColor = System.Drawing.Color.DodgerBlue
        Me.mnuItem_Clientes.Name = "mnuItem_Clientes"
        Me.mnuItem_Clientes.Size = New System.Drawing.Size(74, 24)
        Me.mnuItem_Clientes.Text = "Clientes"
        '
        'SubMenu_CargarCliente
        '
        Me.SubMenu_CargarCliente.Name = "SubMenu_CargarCliente"
        Me.SubMenu_CargarCliente.Size = New System.Drawing.Size(180, 24)
        Me.SubMenu_CargarCliente.Text = "Cargar cliente"
        '
        'SubMenu_BuscarCliente
        '
        Me.SubMenu_BuscarCliente.Name = "SubMenu_BuscarCliente"
        Me.SubMenu_BuscarCliente.Size = New System.Drawing.Size(180, 24)
        Me.SubMenu_BuscarCliente.Text = "Buscar cliente"
        '
        'mnuItem_Productos
        '
        Me.mnuItem_Productos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubMenu_CargarProducto, Me.SubMenu_BuscarProducto})
        Me.mnuItem_Productos.ForeColor = System.Drawing.Color.DodgerBlue
        Me.mnuItem_Productos.Name = "mnuItem_Productos"
        Me.mnuItem_Productos.Size = New System.Drawing.Size(90, 24)
        Me.mnuItem_Productos.Text = "Productos"
        '
        'SubMenu_CargarProducto
        '
        Me.SubMenu_CargarProducto.Name = "SubMenu_CargarProducto"
        Me.SubMenu_CargarProducto.Size = New System.Drawing.Size(191, 24)
        Me.SubMenu_CargarProducto.Text = "Cargar producto"
        '
        'SubMenu_BuscarProducto
        '
        Me.SubMenu_BuscarProducto.Name = "SubMenu_BuscarProducto"
        Me.SubMenu_BuscarProducto.Size = New System.Drawing.Size(191, 24)
        Me.SubMenu_BuscarProducto.Text = "Buscar producto"
        '
        'mnuItem_Ventas
        '
        Me.mnuItem_Ventas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubMenu_CrearVenta, Me.SubMenu_BuscarVenta})
        Me.mnuItem_Ventas.ForeColor = System.Drawing.Color.DodgerBlue
        Me.mnuItem_Ventas.Name = "mnuItem_Ventas"
        Me.mnuItem_Ventas.Size = New System.Drawing.Size(66, 24)
        Me.mnuItem_Ventas.Text = "Ventas"
        '
        'SubMenu_CrearVenta
        '
        Me.SubMenu_CrearVenta.Name = "SubMenu_CrearVenta"
        Me.SubMenu_CrearVenta.Size = New System.Drawing.Size(180, 24)
        Me.SubMenu_CrearVenta.Text = "Cargar venta"
        '
        'SubMenu_BuscarVenta
        '
        Me.SubMenu_BuscarVenta.Name = "SubMenu_BuscarVenta"
        Me.SubMenu_BuscarVenta.Size = New System.Drawing.Size(180, 24)
        Me.SubMenu_BuscarVenta.Text = "Buscar venta"
        '
        'mnuItem_Reportes
        '
        Me.mnuItem_Reportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subMenuItem_ListadoDeProductos})
        Me.mnuItem_Reportes.ForeColor = System.Drawing.Color.DodgerBlue
        Me.mnuItem_Reportes.Name = "mnuItem_Reportes"
        Me.mnuItem_Reportes.Size = New System.Drawing.Size(81, 24)
        Me.mnuItem_Reportes.Text = "Reportes"
        '
        'subMenuItem_ListadoDeProductos
        '
        Me.subMenuItem_ListadoDeProductos.Name = "subMenuItem_ListadoDeProductos"
        Me.subMenuItem_ListadoDeProductos.Size = New System.Drawing.Size(220, 24)
        Me.subMenuItem_ListadoDeProductos.Text = "Listado de productos"
        '
        'grp_Filtro
        '
        Me.grp_Filtro.Controls.Add(Me.time_Fecha)
        Me.grp_Filtro.Controls.Add(Me.txt_Filtro)
        Me.grp_Filtro.Controls.Add(Me.rdb_filtroTres)
        Me.grp_Filtro.Controls.Add(Me.rdb_filtroDos)
        Me.grp_Filtro.Controls.Add(Me.rdb_filtroUno)
        Me.grp_Filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Filtro.ForeColor = System.Drawing.Color.DodgerBlue
        Me.grp_Filtro.Location = New System.Drawing.Point(12, 70)
        Me.grp_Filtro.Name = "grp_Filtro"
        Me.grp_Filtro.Size = New System.Drawing.Size(342, 91)
        Me.grp_Filtro.TabIndex = 2
        Me.grp_Filtro.TabStop = False
        Me.grp_Filtro.Text = "Categoria de filtro"
        Me.grp_Filtro.Visible = False
        '
        'txt_Filtro
        '
        Me.txt_Filtro.Location = New System.Drawing.Point(11, 57)
        Me.txt_Filtro.Name = "txt_Filtro"
        Me.txt_Filtro.Size = New System.Drawing.Size(318, 22)
        Me.txt_Filtro.TabIndex = 3
        '
        'rdb_filtroTres
        '
        Me.rdb_filtroTres.AutoSize = True
        Me.rdb_filtroTres.ForeColor = System.Drawing.Color.DodgerBlue
        Me.rdb_filtroTres.Location = New System.Drawing.Point(228, 26)
        Me.rdb_filtroTres.Name = "rdb_filtroTres"
        Me.rdb_filtroTres.Size = New System.Drawing.Size(107, 20)
        Me.rdb_filtroTres.TabIndex = 2
        Me.rdb_filtroTres.TabStop = True
        Me.rdb_filtroTres.Text = "RadioButton1"
        Me.rdb_filtroTres.UseVisualStyleBackColor = True
        '
        'rdb_filtroDos
        '
        Me.rdb_filtroDos.AutoSize = True
        Me.rdb_filtroDos.ForeColor = System.Drawing.Color.DodgerBlue
        Me.rdb_filtroDos.Location = New System.Drawing.Point(119, 26)
        Me.rdb_filtroDos.Name = "rdb_filtroDos"
        Me.rdb_filtroDos.Size = New System.Drawing.Size(107, 20)
        Me.rdb_filtroDos.TabIndex = 1
        Me.rdb_filtroDos.TabStop = True
        Me.rdb_filtroDos.Text = "RadioButton1"
        Me.rdb_filtroDos.UseVisualStyleBackColor = True
        '
        'rdb_filtroUno
        '
        Me.rdb_filtroUno.AutoSize = True
        Me.rdb_filtroUno.ForeColor = System.Drawing.Color.DodgerBlue
        Me.rdb_filtroUno.Location = New System.Drawing.Point(7, 26)
        Me.rdb_filtroUno.Name = "rdb_filtroUno"
        Me.rdb_filtroUno.Size = New System.Drawing.Size(107, 20)
        Me.rdb_filtroUno.TabIndex = 0
        Me.rdb_filtroUno.TabStop = True
        Me.rdb_filtroUno.Text = "RadioButton1"
        Me.rdb_filtroUno.UseVisualStyleBackColor = True
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_Editar.FlatAppearance.BorderSize = 0
        Me.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Editar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Editar.Location = New System.Drawing.Point(12, 416)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(155, 23)
        Me.btn_Editar.TabIndex = 4
        Me.btn_Editar.Text = "Editar"
        Me.btn_Editar.UseVisualStyleBackColor = False
        Me.btn_Editar.Visible = False
        '
        'btn_Borrar
        '
        Me.btn_Borrar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Borrar.FlatAppearance.BorderSize = 0
        Me.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Borrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Borrar.Location = New System.Drawing.Point(199, 416)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(155, 23)
        Me.btn_Borrar.TabIndex = 5
        Me.btn_Borrar.Text = "Borrar"
        Me.btn_Borrar.UseVisualStyleBackColor = False
        Me.btn_Borrar.Visible = False
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Titulo.Location = New System.Drawing.Point(16, 39)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(57, 18)
        Me.lbl_Titulo.TabIndex = 6
        Me.lbl_Titulo.Text = "Label1"
        Me.lbl_Titulo.Visible = False
        '
        'dta_Lista
        '
        Me.dta_Lista.AllowUserToAddRows = False
        Me.dta_Lista.AllowUserToDeleteRows = False
        Me.dta_Lista.AllowUserToOrderColumns = True
        Me.dta_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dta_Lista.BackgroundColor = System.Drawing.Color.White
        Me.dta_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dta_Lista.Location = New System.Drawing.Point(12, 173)
        Me.dta_Lista.Name = "dta_Lista"
        Me.dta_Lista.ReadOnly = True
        Me.dta_Lista.Size = New System.Drawing.Size(342, 228)
        Me.dta_Lista.TabIndex = 3
        Me.dta_Lista.Visible = False
        '
        'time_Fecha
        '
        Me.time_Fecha.Location = New System.Drawing.Point(11, 56)
        Me.time_Fecha.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.time_Fecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.time_Fecha.Name = "time_Fecha"
        Me.time_Fecha.Size = New System.Drawing.Size(318, 22)
        Me.time_Fecha.TabIndex = 7
        Me.time_Fecha.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(642, 2)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pic_linea2
        '
        Me.pic_linea2.BackColor = System.Drawing.Color.White
        Me.pic_linea2.Location = New System.Drawing.Point(367, 30)
        Me.pic_linea2.Name = "pic_linea2"
        Me.pic_linea2.Size = New System.Drawing.Size(2, 425)
        Me.pic_linea2.TabIndex = 8
        Me.pic_linea2.TabStop = False
        Me.pic_linea2.Visible = False
        '
        'FormMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(639, 451)
        Me.Controls.Add(Me.pic_linea2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Controls.Add(Me.btn_Borrar)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.dta_Lista)
        Me.Controls.Add(Me.grp_Filtro)
        Me.Controls.Add(Me.mnu_MenuPrincipal)
        Me.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal"
        Me.mnu_MenuPrincipal.ResumeLayout(False)
        Me.mnu_MenuPrincipal.PerformLayout()
        Me.grp_Filtro.ResumeLayout(False)
        Me.grp_Filtro.PerformLayout()
        CType(Me.dta_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_linea2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnu_MenuPrincipal As MenuStrip
    Friend WithEvents mnuItem_Clientes As ToolStripMenuItem
    Friend WithEvents SubMenu_CargarCliente As ToolStripMenuItem
    Friend WithEvents SubMenu_BuscarCliente As ToolStripMenuItem
    Friend WithEvents mnuItem_Productos As ToolStripMenuItem
    Friend WithEvents SubMenu_CargarProducto As ToolStripMenuItem
    Friend WithEvents SubMenu_BuscarProducto As ToolStripMenuItem
    Friend WithEvents mnuItem_Ventas As ToolStripMenuItem
    Friend WithEvents SubMenu_CrearVenta As ToolStripMenuItem
    Friend WithEvents SubMenu_BuscarVenta As ToolStripMenuItem
    Friend WithEvents mnuItem_Reportes As ToolStripMenuItem
    Friend WithEvents subMenuItem_ListadoDeProductos As ToolStripMenuItem
    Friend WithEvents grp_Filtro As GroupBox
    Friend WithEvents rdb_filtroTres As RadioButton
    Friend WithEvents rdb_filtroDos As RadioButton
    Friend WithEvents rdb_filtroUno As RadioButton
    Friend WithEvents txt_Filtro As TextBox
    Friend WithEvents btn_Editar As Button
    Friend WithEvents btn_Borrar As Button
    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents time_Fecha As DateTimePicker
    Friend WithEvents dta_Lista As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pic_linea2 As PictureBox
End Class
