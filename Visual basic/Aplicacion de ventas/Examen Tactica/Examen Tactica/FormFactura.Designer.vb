<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFactura
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
        Me.lbl_TuNegocio = New System.Windows.Forms.Label()
        Me.lbl_DatosNegocio = New System.Windows.Forms.Label()
        Me.lbl_Logo = New System.Windows.Forms.Label()
        Me.lbl_TituloCliente = New System.Windows.Forms.Label()
        Me.lbl_NombreCliente = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.lbl_Correo = New System.Windows.Forms.Label()
        Me.lbl_FacturaTitulo = New System.Windows.Forms.Label()
        Me.lbl_FechaTitulo = New System.Windows.Forms.Label()
        Me.lbl_ConceptoTitulo = New System.Windows.Forms.Label()
        Me.lbl_CantidadTitulo = New System.Windows.Forms.Label()
        Me.lbl_PrecioTitulo = New System.Windows.Forms.Label()
        Me.lbl_PrecioTotalTitulo = New System.Windows.Forms.Label()
        Me.lbl_TotalDatos = New System.Windows.Forms.Label()
        Me.lbl_PrecioDatos = New System.Windows.Forms.Label()
        Me.lbl_CantidaDatos = New System.Windows.Forms.Label()
        Me.lbl_ConceptoDatos = New System.Windows.Forms.Label()
        Me.pic_Linea1 = New System.Windows.Forms.PictureBox()
        Me.pic_Linea2 = New System.Windows.Forms.PictureBox()
        Me.lbl_TotalTitulo = New System.Windows.Forms.Label()
        Me.lbl_SumatoriaTotal = New System.Windows.Forms.Label()
        Me.lbl_FechaDato = New System.Windows.Forms.Label()
        Me.lbl_FacturaDato = New System.Windows.Forms.Label()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        CType(Me.pic_Linea1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Linea2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_TuNegocio
        '
        Me.lbl_TuNegocio.AutoSize = True
        Me.lbl_TuNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TuNegocio.Location = New System.Drawing.Point(13, 13)
        Me.lbl_TuNegocio.Name = "lbl_TuNegocio"
        Me.lbl_TuNegocio.Size = New System.Drawing.Size(97, 20)
        Me.lbl_TuNegocio.TabIndex = 0
        Me.lbl_TuNegocio.Text = "Tu negocio"
        '
        'lbl_DatosNegocio
        '
        Me.lbl_DatosNegocio.AutoSize = True
        Me.lbl_DatosNegocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DatosNegocio.Location = New System.Drawing.Point(14, 37)
        Me.lbl_DatosNegocio.Name = "lbl_DatosNegocio"
        Me.lbl_DatosNegocio.Size = New System.Drawing.Size(115, 16)
        Me.lbl_DatosNegocio.TabIndex = 1
        Me.lbl_DatosNegocio.Text = "Datos de negocio"
        '
        'lbl_Logo
        '
        Me.lbl_Logo.AutoSize = True
        Me.lbl_Logo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Logo.Location = New System.Drawing.Point(329, 37)
        Me.lbl_Logo.Name = "lbl_Logo"
        Me.lbl_Logo.Size = New System.Drawing.Size(106, 42)
        Me.lbl_Logo.TabIndex = 2
        Me.lbl_Logo.Text = "Logo"
        '
        'lbl_TituloCliente
        '
        Me.lbl_TituloCliente.AutoSize = True
        Me.lbl_TituloCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloCliente.Location = New System.Drawing.Point(20, 132)
        Me.lbl_TituloCliente.Name = "lbl_TituloCliente"
        Me.lbl_TituloCliente.Size = New System.Drawing.Size(101, 16)
        Me.lbl_TituloCliente.TabIndex = 3
        Me.lbl_TituloCliente.Text = "Datos cliente"
        '
        'lbl_NombreCliente
        '
        Me.lbl_NombreCliente.AutoSize = True
        Me.lbl_NombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreCliente.Location = New System.Drawing.Point(23, 152)
        Me.lbl_NombreCliente.Name = "lbl_NombreCliente"
        Me.lbl_NombreCliente.Size = New System.Drawing.Size(51, 15)
        Me.lbl_NombreCliente.TabIndex = 4
        Me.lbl_NombreCliente.Text = "Cliente: "
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Telefono.Location = New System.Drawing.Point(23, 170)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(61, 15)
        Me.lbl_Telefono.TabIndex = 5
        Me.lbl_Telefono.Text = "Telefono: "
        '
        'lbl_Correo
        '
        Me.lbl_Correo.AutoSize = True
        Me.lbl_Correo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Correo.Location = New System.Drawing.Point(23, 190)
        Me.lbl_Correo.Name = "lbl_Correo"
        Me.lbl_Correo.Size = New System.Drawing.Size(50, 15)
        Me.lbl_Correo.TabIndex = 6
        Me.lbl_Correo.Text = "Correo: "
        '
        'lbl_FacturaTitulo
        '
        Me.lbl_FacturaTitulo.AutoSize = True
        Me.lbl_FacturaTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FacturaTitulo.Location = New System.Drawing.Point(294, 152)
        Me.lbl_FacturaTitulo.Name = "lbl_FacturaTitulo"
        Me.lbl_FacturaTitulo.Size = New System.Drawing.Size(75, 15)
        Me.lbl_FacturaTitulo.TabIndex = 7
        Me.lbl_FacturaTitulo.Text = "Factura N°"
        '
        'lbl_FechaTitulo
        '
        Me.lbl_FechaTitulo.AutoSize = True
        Me.lbl_FechaTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaTitulo.Location = New System.Drawing.Point(294, 170)
        Me.lbl_FechaTitulo.Name = "lbl_FechaTitulo"
        Me.lbl_FechaTitulo.Size = New System.Drawing.Size(46, 15)
        Me.lbl_FechaTitulo.TabIndex = 8
        Me.lbl_FechaTitulo.Text = "Fecha"
        '
        'lbl_ConceptoTitulo
        '
        Me.lbl_ConceptoTitulo.AutoSize = True
        Me.lbl_ConceptoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConceptoTitulo.Location = New System.Drawing.Point(20, 223)
        Me.lbl_ConceptoTitulo.Name = "lbl_ConceptoTitulo"
        Me.lbl_ConceptoTitulo.Size = New System.Drawing.Size(67, 15)
        Me.lbl_ConceptoTitulo.TabIndex = 9
        Me.lbl_ConceptoTitulo.Text = "Concepto"
        '
        'lbl_CantidadTitulo
        '
        Me.lbl_CantidadTitulo.AutoSize = True
        Me.lbl_CantidadTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantidadTitulo.Location = New System.Drawing.Point(262, 223)
        Me.lbl_CantidadTitulo.Name = "lbl_CantidadTitulo"
        Me.lbl_CantidadTitulo.Size = New System.Drawing.Size(64, 15)
        Me.lbl_CantidadTitulo.TabIndex = 10
        Me.lbl_CantidadTitulo.Text = "Cantidad"
        '
        'lbl_PrecioTitulo
        '
        Me.lbl_PrecioTitulo.AutoSize = True
        Me.lbl_PrecioTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrecioTitulo.Location = New System.Drawing.Point(339, 223)
        Me.lbl_PrecioTitulo.Name = "lbl_PrecioTitulo"
        Me.lbl_PrecioTitulo.Size = New System.Drawing.Size(48, 15)
        Me.lbl_PrecioTitulo.TabIndex = 11
        Me.lbl_PrecioTitulo.Text = "Precio"
        '
        'lbl_PrecioTotalTitulo
        '
        Me.lbl_PrecioTotalTitulo.AutoSize = True
        Me.lbl_PrecioTotalTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrecioTotalTitulo.Location = New System.Drawing.Point(401, 223)
        Me.lbl_PrecioTotalTitulo.Name = "lbl_PrecioTotalTitulo"
        Me.lbl_PrecioTotalTitulo.Size = New System.Drawing.Size(80, 15)
        Me.lbl_PrecioTotalTitulo.TabIndex = 12
        Me.lbl_PrecioTotalTitulo.Text = "Precio total"
        '
        'lbl_TotalDatos
        '
        Me.lbl_TotalDatos.AutoSize = True
        Me.lbl_TotalDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalDatos.Location = New System.Drawing.Point(401, 245)
        Me.lbl_TotalDatos.Name = "lbl_TotalDatos"
        Me.lbl_TotalDatos.Size = New System.Drawing.Size(34, 15)
        Me.lbl_TotalDatos.TabIndex = 16
        Me.lbl_TotalDatos.Text = "Total"
        '
        'lbl_PrecioDatos
        '
        Me.lbl_PrecioDatos.AutoSize = True
        Me.lbl_PrecioDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrecioDatos.Location = New System.Drawing.Point(339, 245)
        Me.lbl_PrecioDatos.Name = "lbl_PrecioDatos"
        Me.lbl_PrecioDatos.Size = New System.Drawing.Size(42, 15)
        Me.lbl_PrecioDatos.TabIndex = 15
        Me.lbl_PrecioDatos.Text = "Precio"
        '
        'lbl_CantidaDatos
        '
        Me.lbl_CantidaDatos.AutoSize = True
        Me.lbl_CantidaDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantidaDatos.Location = New System.Drawing.Point(262, 245)
        Me.lbl_CantidaDatos.Name = "lbl_CantidaDatos"
        Me.lbl_CantidaDatos.Size = New System.Drawing.Size(56, 15)
        Me.lbl_CantidaDatos.TabIndex = 14
        Me.lbl_CantidaDatos.Text = "Cantidad"
        '
        'lbl_ConceptoDatos
        '
        Me.lbl_ConceptoDatos.AutoSize = True
        Me.lbl_ConceptoDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConceptoDatos.Location = New System.Drawing.Point(20, 245)
        Me.lbl_ConceptoDatos.Name = "lbl_ConceptoDatos"
        Me.lbl_ConceptoDatos.Size = New System.Drawing.Size(59, 15)
        Me.lbl_ConceptoDatos.TabIndex = 13
        Me.lbl_ConceptoDatos.Text = "Concepto"
        '
        'pic_Linea1
        '
        Me.pic_Linea1.BackColor = System.Drawing.Color.Black
        Me.pic_Linea1.Location = New System.Drawing.Point(10, 241)
        Me.pic_Linea1.Name = "pic_Linea1"
        Me.pic_Linea1.Size = New System.Drawing.Size(476, 2)
        Me.pic_Linea1.TabIndex = 17
        Me.pic_Linea1.TabStop = False
        '
        'pic_Linea2
        '
        Me.pic_Linea2.BackColor = System.Drawing.Color.Black
        Me.pic_Linea2.Location = New System.Drawing.Point(11, 267)
        Me.pic_Linea2.Name = "pic_Linea2"
        Me.pic_Linea2.Size = New System.Drawing.Size(476, 2)
        Me.pic_Linea2.TabIndex = 18
        Me.pic_Linea2.TabStop = False
        '
        'lbl_TotalTitulo
        '
        Me.lbl_TotalTitulo.AutoSize = True
        Me.lbl_TotalTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalTitulo.Location = New System.Drawing.Point(319, 276)
        Me.lbl_TotalTitulo.Name = "lbl_TotalTitulo"
        Me.lbl_TotalTitulo.Size = New System.Drawing.Size(80, 15)
        Me.lbl_TotalTitulo.TabIndex = 19
        Me.lbl_TotalTitulo.Text = "Precio final"
        '
        'lbl_SumatoriaTotal
        '
        Me.lbl_SumatoriaTotal.AutoSize = True
        Me.lbl_SumatoriaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SumatoriaTotal.Location = New System.Drawing.Point(401, 276)
        Me.lbl_SumatoriaTotal.Name = "lbl_SumatoriaTotal"
        Me.lbl_SumatoriaTotal.Size = New System.Drawing.Size(34, 15)
        Me.lbl_SumatoriaTotal.TabIndex = 20
        Me.lbl_SumatoriaTotal.Text = "Total"
        '
        'lbl_FechaDato
        '
        Me.lbl_FechaDato.AutoSize = True
        Me.lbl_FechaDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaDato.Location = New System.Drawing.Point(370, 170)
        Me.lbl_FechaDato.Name = "lbl_FechaDato"
        Me.lbl_FechaDato.Size = New System.Drawing.Size(41, 15)
        Me.lbl_FechaDato.TabIndex = 22
        Me.lbl_FechaDato.Text = "Fecha"
        '
        'lbl_FacturaDato
        '
        Me.lbl_FacturaDato.AutoSize = True
        Me.lbl_FacturaDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FacturaDato.Location = New System.Drawing.Point(370, 152)
        Me.lbl_FacturaDato.Name = "lbl_FacturaDato"
        Me.lbl_FacturaDato.Size = New System.Drawing.Size(65, 15)
        Me.lbl_FacturaDato.TabIndex = 21
        Me.lbl_FacturaDato.Text = "Factura N°"
        '
        'btn_Exportar
        '
        Me.btn_Exportar.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_Exportar.FlatAppearance.BorderSize = 0
        Me.btn_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exportar.Location = New System.Drawing.Point(406, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exportar.TabIndex = 23
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.UseVisualStyleBackColor = False
        '
        'FormFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(498, 633)
        Me.Controls.Add(Me.btn_Exportar)
        Me.Controls.Add(Me.lbl_FechaDato)
        Me.Controls.Add(Me.lbl_FacturaDato)
        Me.Controls.Add(Me.lbl_SumatoriaTotal)
        Me.Controls.Add(Me.lbl_TotalTitulo)
        Me.Controls.Add(Me.pic_Linea2)
        Me.Controls.Add(Me.pic_Linea1)
        Me.Controls.Add(Me.lbl_TotalDatos)
        Me.Controls.Add(Me.lbl_PrecioDatos)
        Me.Controls.Add(Me.lbl_CantidaDatos)
        Me.Controls.Add(Me.lbl_ConceptoDatos)
        Me.Controls.Add(Me.lbl_PrecioTotalTitulo)
        Me.Controls.Add(Me.lbl_PrecioTitulo)
        Me.Controls.Add(Me.lbl_CantidadTitulo)
        Me.Controls.Add(Me.lbl_ConceptoTitulo)
        Me.Controls.Add(Me.lbl_FechaTitulo)
        Me.Controls.Add(Me.lbl_FacturaTitulo)
        Me.Controls.Add(Me.lbl_Correo)
        Me.Controls.Add(Me.lbl_Telefono)
        Me.Controls.Add(Me.lbl_NombreCliente)
        Me.Controls.Add(Me.lbl_TituloCliente)
        Me.Controls.Add(Me.lbl_Logo)
        Me.Controls.Add(Me.lbl_DatosNegocio)
        Me.Controls.Add(Me.lbl_TuNegocio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "FormFactura"
        Me.Text = "Factura"
        CType(Me.pic_Linea1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Linea2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_TuNegocio As Label
    Friend WithEvents lbl_DatosNegocio As Label
    Friend WithEvents lbl_Logo As Label
    Friend WithEvents lbl_TituloCliente As Label
    Friend WithEvents lbl_NombreCliente As Label
    Friend WithEvents lbl_Telefono As Label
    Friend WithEvents lbl_Correo As Label
    Friend WithEvents lbl_FacturaTitulo As Label
    Friend WithEvents lbl_FechaTitulo As Label
    Friend WithEvents lbl_ConceptoTitulo As Label
    Friend WithEvents lbl_CantidadTitulo As Label
    Friend WithEvents lbl_PrecioTitulo As Label
    Friend WithEvents lbl_PrecioTotalTitulo As Label
    Friend WithEvents lbl_TotalDatos As Label
    Friend WithEvents lbl_PrecioDatos As Label
    Friend WithEvents lbl_CantidaDatos As Label
    Friend WithEvents lbl_ConceptoDatos As Label
    Friend WithEvents pic_Linea1 As PictureBox
    Friend WithEvents pic_Linea2 As PictureBox
    Friend WithEvents lbl_TotalTitulo As Label
    Friend WithEvents lbl_SumatoriaTotal As Label
    Friend WithEvents lbl_FechaDato As Label
    Friend WithEvents lbl_FacturaDato As Label
    Friend WithEvents btn_Exportar As Button
End Class
