<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormABM
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
        Me.lbl_PrimerBox = New System.Windows.Forms.Label()
        Me.lbl_SegundoBox = New System.Windows.Forms.Label()
        Me.lbl_TercerBox = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.txtBox_Primero = New System.Windows.Forms.TextBox()
        Me.txtBox_Segundo = New System.Windows.Forms.TextBox()
        Me.txtBox_Tercero = New System.Windows.Forms.TextBox()
        Me.lbl_Cuarto = New System.Windows.Forms.Label()
        Me.lbl_Quinto = New System.Windows.Forms.Label()
        Me.cbo_Primero = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Titulo.Location = New System.Drawing.Point(14, 16)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(50, 18)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Titulo"
        '
        'lbl_PrimerBox
        '
        Me.lbl_PrimerBox.AutoSize = True
        Me.lbl_PrimerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PrimerBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_PrimerBox.Location = New System.Drawing.Point(15, 51)
        Me.lbl_PrimerBox.Name = "lbl_PrimerBox"
        Me.lbl_PrimerBox.Size = New System.Drawing.Size(49, 16)
        Me.lbl_PrimerBox.TabIndex = 1
        Me.lbl_PrimerBox.Text = "Label1"
        '
        'lbl_SegundoBox
        '
        Me.lbl_SegundoBox.AutoSize = True
        Me.lbl_SegundoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SegundoBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_SegundoBox.Location = New System.Drawing.Point(15, 116)
        Me.lbl_SegundoBox.Name = "lbl_SegundoBox"
        Me.lbl_SegundoBox.Size = New System.Drawing.Size(49, 16)
        Me.lbl_SegundoBox.TabIndex = 2
        Me.lbl_SegundoBox.Text = "Label2"
        '
        'lbl_TercerBox
        '
        Me.lbl_TercerBox.AutoSize = True
        Me.lbl_TercerBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TercerBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_TercerBox.Location = New System.Drawing.Point(15, 185)
        Me.lbl_TercerBox.Name = "lbl_TercerBox"
        Me.lbl_TercerBox.Size = New System.Drawing.Size(49, 16)
        Me.lbl_TercerBox.TabIndex = 3
        Me.lbl_TercerBox.Text = "Label3"
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_OK.FlatAppearance.BorderSize = 0
        Me.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_OK.Location = New System.Drawing.Point(18, 374)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(100, 23)
        Me.btn_OK.TabIndex = 4
        Me.btn_OK.Text = "Guardar"
        Me.btn_OK.UseVisualStyleBackColor = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancelar.Location = New System.Drawing.Point(146, 374)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(101, 23)
        Me.btn_Cancelar.TabIndex = 5
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = False
        '
        'txtBox_Primero
        '
        Me.txtBox_Primero.Location = New System.Drawing.Point(18, 77)
        Me.txtBox_Primero.Name = "txtBox_Primero"
        Me.txtBox_Primero.Size = New System.Drawing.Size(229, 20)
        Me.txtBox_Primero.TabIndex = 6
        '
        'txtBox_Segundo
        '
        Me.txtBox_Segundo.Location = New System.Drawing.Point(18, 146)
        Me.txtBox_Segundo.Name = "txtBox_Segundo"
        Me.txtBox_Segundo.Size = New System.Drawing.Size(229, 20)
        Me.txtBox_Segundo.TabIndex = 7
        '
        'txtBox_Tercero
        '
        Me.txtBox_Tercero.Location = New System.Drawing.Point(18, 215)
        Me.txtBox_Tercero.Name = "txtBox_Tercero"
        Me.txtBox_Tercero.Size = New System.Drawing.Size(229, 20)
        Me.txtBox_Tercero.TabIndex = 8
        '
        'lbl_Cuarto
        '
        Me.lbl_Cuarto.AutoSize = True
        Me.lbl_Cuarto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuarto.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Cuarto.Location = New System.Drawing.Point(15, 263)
        Me.lbl_Cuarto.Name = "lbl_Cuarto"
        Me.lbl_Cuarto.Size = New System.Drawing.Size(49, 16)
        Me.lbl_Cuarto.TabIndex = 9
        Me.lbl_Cuarto.Text = "Label4"
        Me.lbl_Cuarto.Visible = False
        '
        'lbl_Quinto
        '
        Me.lbl_Quinto.AutoSize = True
        Me.lbl_Quinto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Quinto.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_Quinto.Location = New System.Drawing.Point(15, 291)
        Me.lbl_Quinto.Name = "lbl_Quinto"
        Me.lbl_Quinto.Size = New System.Drawing.Size(15, 16)
        Me.lbl_Quinto.TabIndex = 10
        Me.lbl_Quinto.Text = "$"
        Me.lbl_Quinto.Visible = False
        '
        'cbo_Primero
        '
        Me.cbo_Primero.Enabled = False
        Me.cbo_Primero.FormattingEnabled = True
        Me.cbo_Primero.Location = New System.Drawing.Point(18, 77)
        Me.cbo_Primero.Name = "cbo_Primero"
        Me.cbo_Primero.Size = New System.Drawing.Size(229, 21)
        Me.cbo_Primero.TabIndex = 11
        Me.cbo_Primero.Visible = False
        '
        'FormABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(265, 410)
        Me.Controls.Add(Me.cbo_Primero)
        Me.Controls.Add(Me.lbl_Quinto)
        Me.Controls.Add(Me.lbl_Cuarto)
        Me.Controls.Add(Me.txtBox_Tercero)
        Me.Controls.Add(Me.txtBox_Segundo)
        Me.Controls.Add(Me.txtBox_Primero)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.lbl_TercerBox)
        Me.Controls.Add(Me.lbl_SegundoBox)
        Me.Controls.Add(Me.lbl_PrimerBox)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormABM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormCrear"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_PrimerBox As Label
    Friend WithEvents lbl_SegundoBox As Label
    Friend WithEvents lbl_TercerBox As Label
    Friend WithEvents btn_OK As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents txtBox_Primero As TextBox
    Friend WithEvents txtBox_Segundo As TextBox
    Friend WithEvents txtBox_Tercero As TextBox
    Friend WithEvents lbl_Cuarto As Label
    Friend WithEvents lbl_Quinto As Label
    Friend WithEvents cbo_Primero As ComboBox
End Class
