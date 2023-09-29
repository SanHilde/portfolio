<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteMensual
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
        Me.lbl_Mes = New System.Windows.Forms.Label()
        Me.time_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.pic_Linea1 = New System.Windows.Forms.PictureBox()
        Me.lbl_TotalDatos = New System.Windows.Forms.Label()
        Me.lbl_PrecioDatos = New System.Windows.Forms.Label()
        Me.lbl_CantidaDatos = New System.Windows.Forms.Label()
        Me.lbl_ConceptoDatos = New System.Windows.Forms.Label()
        Me.lbl_PrecioTotalTitulo = New System.Windows.Forms.Label()
        Me.lbl_PrecioTitulo = New System.Windows.Forms.Label()
        Me.lbl_CantidadTitulo = New System.Windows.Forms.Label()
        Me.lbl_ConceptoTitulo = New System.Windows.Forms.Label()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        CType(Me.pic_Linea1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Mes
        '
        Me.lbl_Mes.AutoSize = True
        Me.lbl_Mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mes.Location = New System.Drawing.Point(20, 11)
        Me.lbl_Mes.Name = "lbl_Mes"
        Me.lbl_Mes.Size = New System.Drawing.Size(105, 16)
        Me.lbl_Mes.TabIndex = 0
        Me.lbl_Mes.Text = "Seleccione mes"
        '
        'time_Fecha
        '
        Me.time_Fecha.Location = New System.Drawing.Point(137, 9)
        Me.time_Fecha.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.time_Fecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.time_Fecha.Name = "time_Fecha"
        Me.time_Fecha.Size = New System.Drawing.Size(200, 20)
        Me.time_Fecha.TabIndex = 1
        '
        'pic_Linea1
        '
        Me.pic_Linea1.BackColor = System.Drawing.Color.Black
        Me.pic_Linea1.Location = New System.Drawing.Point(10, 66)
        Me.pic_Linea1.Name = "pic_Linea1"
        Me.pic_Linea1.Size = New System.Drawing.Size(476, 2)
        Me.pic_Linea1.TabIndex = 26
        Me.pic_Linea1.TabStop = False
        '
        'lbl_TotalDatos
        '
        Me.lbl_TotalDatos.AutoSize = True
        Me.lbl_TotalDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalDatos.Location = New System.Drawing.Point(401, 70)
        Me.lbl_TotalDatos.Name = "lbl_TotalDatos"
        Me.lbl_TotalDatos.Size = New System.Drawing.Size(34, 15)
        Me.lbl_TotalDatos.TabIndex = 25
        Me.lbl_TotalDatos.Text = "Total"
        '
        'lbl_PrecioDatos
        '
        Me.lbl_PrecioDatos.AutoSize = True
        Me.lbl_PrecioDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrecioDatos.Location = New System.Drawing.Point(339, 70)
        Me.lbl_PrecioDatos.Name = "lbl_PrecioDatos"
        Me.lbl_PrecioDatos.Size = New System.Drawing.Size(42, 15)
        Me.lbl_PrecioDatos.TabIndex = 24
        Me.lbl_PrecioDatos.Text = "Precio"
        '
        'lbl_CantidaDatos
        '
        Me.lbl_CantidaDatos.AutoSize = True
        Me.lbl_CantidaDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantidaDatos.Location = New System.Drawing.Point(262, 70)
        Me.lbl_CantidaDatos.Name = "lbl_CantidaDatos"
        Me.lbl_CantidaDatos.Size = New System.Drawing.Size(56, 15)
        Me.lbl_CantidaDatos.TabIndex = 23
        Me.lbl_CantidaDatos.Text = "Cantidad"
        '
        'lbl_ConceptoDatos
        '
        Me.lbl_ConceptoDatos.AutoSize = True
        Me.lbl_ConceptoDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConceptoDatos.Location = New System.Drawing.Point(20, 70)
        Me.lbl_ConceptoDatos.Name = "lbl_ConceptoDatos"
        Me.lbl_ConceptoDatos.Size = New System.Drawing.Size(59, 15)
        Me.lbl_ConceptoDatos.TabIndex = 22
        Me.lbl_ConceptoDatos.Text = "Concepto"
        '
        'lbl_PrecioTotalTitulo
        '
        Me.lbl_PrecioTotalTitulo.AutoSize = True
        Me.lbl_PrecioTotalTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrecioTotalTitulo.Location = New System.Drawing.Point(401, 48)
        Me.lbl_PrecioTotalTitulo.Name = "lbl_PrecioTotalTitulo"
        Me.lbl_PrecioTotalTitulo.Size = New System.Drawing.Size(80, 15)
        Me.lbl_PrecioTotalTitulo.TabIndex = 21
        Me.lbl_PrecioTotalTitulo.Text = "Precio total"
        '
        'lbl_PrecioTitulo
        '
        Me.lbl_PrecioTitulo.AutoSize = True
        Me.lbl_PrecioTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrecioTitulo.Location = New System.Drawing.Point(339, 48)
        Me.lbl_PrecioTitulo.Name = "lbl_PrecioTitulo"
        Me.lbl_PrecioTitulo.Size = New System.Drawing.Size(48, 15)
        Me.lbl_PrecioTitulo.TabIndex = 20
        Me.lbl_PrecioTitulo.Text = "Precio"
        '
        'lbl_CantidadTitulo
        '
        Me.lbl_CantidadTitulo.AutoSize = True
        Me.lbl_CantidadTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CantidadTitulo.Location = New System.Drawing.Point(262, 48)
        Me.lbl_CantidadTitulo.Name = "lbl_CantidadTitulo"
        Me.lbl_CantidadTitulo.Size = New System.Drawing.Size(64, 15)
        Me.lbl_CantidadTitulo.TabIndex = 19
        Me.lbl_CantidadTitulo.Text = "Cantidad"
        '
        'lbl_ConceptoTitulo
        '
        Me.lbl_ConceptoTitulo.AutoSize = True
        Me.lbl_ConceptoTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConceptoTitulo.Location = New System.Drawing.Point(20, 48)
        Me.lbl_ConceptoTitulo.Name = "lbl_ConceptoTitulo"
        Me.lbl_ConceptoTitulo.Size = New System.Drawing.Size(67, 15)
        Me.lbl_ConceptoTitulo.TabIndex = 18
        Me.lbl_ConceptoTitulo.Text = "Concepto"
        '
        'btn_Exportar
        '
        Me.btn_Exportar.BackColor = System.Drawing.Color.SkyBlue
        Me.btn_Exportar.FlatAppearance.BorderSize = 0
        Me.btn_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exportar.Location = New System.Drawing.Point(424, 6)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exportar.TabIndex = 27
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.UseVisualStyleBackColor = False
        '
        'FormReporteMensual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 581)
        Me.Controls.Add(Me.btn_Exportar)
        Me.Controls.Add(Me.pic_Linea1)
        Me.Controls.Add(Me.lbl_TotalDatos)
        Me.Controls.Add(Me.lbl_PrecioDatos)
        Me.Controls.Add(Me.lbl_CantidaDatos)
        Me.Controls.Add(Me.lbl_ConceptoDatos)
        Me.Controls.Add(Me.lbl_PrecioTotalTitulo)
        Me.Controls.Add(Me.lbl_PrecioTitulo)
        Me.Controls.Add(Me.lbl_CantidadTitulo)
        Me.Controls.Add(Me.lbl_ConceptoTitulo)
        Me.Controls.Add(Me.time_Fecha)
        Me.Controls.Add(Me.lbl_Mes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormReporteMensual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte mes"
        CType(Me.pic_Linea1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Mes As Label
    Friend WithEvents time_Fecha As DateTimePicker
    Friend WithEvents pic_Linea1 As PictureBox
    Friend WithEvents lbl_TotalDatos As Label
    Friend WithEvents lbl_PrecioDatos As Label
    Friend WithEvents lbl_CantidaDatos As Label
    Friend WithEvents lbl_ConceptoDatos As Label
    Friend WithEvents lbl_PrecioTotalTitulo As Label
    Friend WithEvents lbl_PrecioTitulo As Label
    Friend WithEvents lbl_CantidadTitulo As Label
    Friend WithEvents lbl_ConceptoTitulo As Label
    Friend WithEvents btn_Exportar As Button
End Class
