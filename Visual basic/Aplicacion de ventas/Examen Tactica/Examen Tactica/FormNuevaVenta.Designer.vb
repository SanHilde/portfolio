<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevaVenta
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
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.dta_Lista = New System.Windows.Forms.DataGridView()
        Me.btn_AgregarProducto = New System.Windows.Forms.Button()
        Me.time_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Cliente = New System.Windows.Forms.Label()
        Me.cbo_Cliente = New System.Windows.Forms.ComboBox()
        Me.lbl_Total = New System.Windows.Forms.Label()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.lbl_Productos = New System.Windows.Forms.Label()
        Me.btn_CancelarVenta = New System.Windows.Forms.Button()
        Me.btn_GuardarVenta = New System.Windows.Forms.Button()
        Me.lbl_TotalValor = New System.Windows.Forms.Label()
        Me.btn_Factura = New System.Windows.Forms.Button()
        CType(Me.dta_Lista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.Location = New System.Drawing.Point(8, 14)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(57, 20)
        Me.lbl_Titulo.TabIndex = 11
        Me.lbl_Titulo.Text = "Label1"
        '
        'btn_Borrar
        '
        Me.btn_Borrar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Borrar.FlatAppearance.BorderSize = 0
        Me.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Borrar.ForeColor = System.Drawing.Color.Black
        Me.btn_Borrar.Location = New System.Drawing.Point(250, 347)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(104, 23)
        Me.btn_Borrar.TabIndex = 10
        Me.btn_Borrar.Text = "Borrar producto"
        Me.btn_Borrar.UseVisualStyleBackColor = False
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Editar.FlatAppearance.BorderSize = 0
        Me.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Editar.ForeColor = System.Drawing.Color.Black
        Me.btn_Editar.Location = New System.Drawing.Point(131, 347)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(104, 23)
        Me.btn_Editar.TabIndex = 9
        Me.btn_Editar.Text = "Editar producto"
        Me.btn_Editar.UseVisualStyleBackColor = False
        '
        'dta_Lista
        '
        Me.dta_Lista.AllowUserToAddRows = False
        Me.dta_Lista.AllowUserToDeleteRows = False
        Me.dta_Lista.AllowUserToOrderColumns = True
        Me.dta_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dta_Lista.BackgroundColor = System.Drawing.Color.White
        Me.dta_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dta_Lista.Location = New System.Drawing.Point(11, 136)
        Me.dta_Lista.Name = "dta_Lista"
        Me.dta_Lista.ReadOnly = True
        Me.dta_Lista.Size = New System.Drawing.Size(342, 205)
        Me.dta_Lista.TabIndex = 7
        '
        'btn_AgregarProducto
        '
        Me.btn_AgregarProducto.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_AgregarProducto.FlatAppearance.BorderSize = 0
        Me.btn_AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AgregarProducto.ForeColor = System.Drawing.Color.Black
        Me.btn_AgregarProducto.Location = New System.Drawing.Point(12, 347)
        Me.btn_AgregarProducto.Name = "btn_AgregarProducto"
        Me.btn_AgregarProducto.Size = New System.Drawing.Size(104, 23)
        Me.btn_AgregarProducto.TabIndex = 12
        Me.btn_AgregarProducto.Text = "Agregar producto"
        Me.btn_AgregarProducto.UseVisualStyleBackColor = False
        '
        'time_Fecha
        '
        Me.time_Fecha.Location = New System.Drawing.Point(72, 80)
        Me.time_Fecha.Name = "time_Fecha"
        Me.time_Fecha.Size = New System.Drawing.Size(194, 20)
        Me.time_Fecha.TabIndex = 13
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cliente.Location = New System.Drawing.Point(9, 45)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(49, 16)
        Me.lbl_Cliente.TabIndex = 15
        Me.lbl_Cliente.Text = "Cliente"
        '
        'cbo_Cliente
        '
        Me.cbo_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Cliente.FormattingEnabled = True
        Me.cbo_Cliente.Location = New System.Drawing.Point(72, 44)
        Me.cbo_Cliente.Name = "cbo_Cliente"
        Me.cbo_Cliente.Size = New System.Drawing.Size(194, 21)
        Me.cbo_Cliente.TabIndex = 16
        '
        'lbl_Total
        '
        Me.lbl_Total.AutoSize = True
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(9, 382)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(63, 16)
        Me.lbl_Total.TabIndex = 17
        Me.lbl_Total.Text = "Total: $"
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fecha.Location = New System.Drawing.Point(9, 82)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(46, 16)
        Me.lbl_Fecha.TabIndex = 14
        Me.lbl_Fecha.Text = "Fecha"
        '
        'lbl_Productos
        '
        Me.lbl_Productos.AutoSize = True
        Me.lbl_Productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Productos.Location = New System.Drawing.Point(9, 113)
        Me.lbl_Productos.Name = "lbl_Productos"
        Me.lbl_Productos.Size = New System.Drawing.Size(69, 16)
        Me.lbl_Productos.TabIndex = 18
        Me.lbl_Productos.Text = "Productos"
        '
        'btn_CancelarVenta
        '
        Me.btn_CancelarVenta.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_CancelarVenta.FlatAppearance.BorderSize = 0
        Me.btn_CancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_CancelarVenta.ForeColor = System.Drawing.Color.Black
        Me.btn_CancelarVenta.Location = New System.Drawing.Point(250, 377)
        Me.btn_CancelarVenta.Name = "btn_CancelarVenta"
        Me.btn_CancelarVenta.Size = New System.Drawing.Size(103, 24)
        Me.btn_CancelarVenta.TabIndex = 20
        Me.btn_CancelarVenta.Text = "Cancelar venta"
        Me.btn_CancelarVenta.UseVisualStyleBackColor = False
        '
        'btn_GuardarVenta
        '
        Me.btn_GuardarVenta.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_GuardarVenta.FlatAppearance.BorderSize = 0
        Me.btn_GuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GuardarVenta.ForeColor = System.Drawing.Color.Black
        Me.btn_GuardarVenta.Location = New System.Drawing.Point(131, 377)
        Me.btn_GuardarVenta.Name = "btn_GuardarVenta"
        Me.btn_GuardarVenta.Size = New System.Drawing.Size(103, 24)
        Me.btn_GuardarVenta.TabIndex = 21
        Me.btn_GuardarVenta.Text = "Guardar venta"
        Me.btn_GuardarVenta.UseVisualStyleBackColor = False
        '
        'lbl_TotalValor
        '
        Me.lbl_TotalValor.AutoSize = True
        Me.lbl_TotalValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalValor.Location = New System.Drawing.Point(64, 382)
        Me.lbl_TotalValor.Name = "lbl_TotalValor"
        Me.lbl_TotalValor.Size = New System.Drawing.Size(17, 16)
        Me.lbl_TotalValor.TabIndex = 22
        Me.lbl_TotalValor.Text = "0"
        '
        'btn_Factura
        '
        Me.btn_Factura.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_Factura.FlatAppearance.BorderSize = 0
        Me.btn_Factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Factura.ForeColor = System.Drawing.Color.Black
        Me.btn_Factura.Location = New System.Drawing.Point(289, 45)
        Me.btn_Factura.Name = "btn_Factura"
        Me.btn_Factura.Size = New System.Drawing.Size(64, 55)
        Me.btn_Factura.TabIndex = 23
        Me.btn_Factura.Text = "Generar factura"
        Me.btn_Factura.UseVisualStyleBackColor = False
        '
        'FormNuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(365, 410)
        Me.Controls.Add(Me.btn_Factura)
        Me.Controls.Add(Me.lbl_TotalValor)
        Me.Controls.Add(Me.btn_GuardarVenta)
        Me.Controls.Add(Me.btn_CancelarVenta)
        Me.Controls.Add(Me.lbl_Productos)
        Me.Controls.Add(Me.lbl_Total)
        Me.Controls.Add(Me.cbo_Cliente)
        Me.Controls.Add(Me.lbl_Cliente)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.time_Fecha)
        Me.Controls.Add(Me.btn_AgregarProducto)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Controls.Add(Me.btn_Borrar)
        Me.Controls.Add(Me.btn_Editar)
        Me.Controls.Add(Me.dta_Lista)
        Me.ForeColor = System.Drawing.Color.DodgerBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNuevaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Nueva venta"
        CType(Me.dta_Lista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents btn_Borrar As Button
    Friend WithEvents btn_Editar As Button
    Friend WithEvents dta_Lista As DataGridView
    Friend WithEvents btn_AgregarProducto As Button
    Friend WithEvents time_Fecha As DateTimePicker
    Friend WithEvents lbl_Cliente As Label
    Friend WithEvents cbo_Cliente As ComboBox
    Friend WithEvents lbl_Total As Label
    Friend WithEvents lbl_Fecha As Label
    Friend WithEvents lbl_Productos As Label
    Friend WithEvents btn_CancelarVenta As Button
    Friend WithEvents btn_GuardarVenta As Button
    Friend WithEvents lbl_TotalValor As Label
    Friend WithEvents btn_Factura As Button
End Class
