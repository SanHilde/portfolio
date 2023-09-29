Imports System.Windows.Forms
Imports Clases

Public Class FormABM
    Private _primerDato As String
    Private _segundoDato As String
    Private _tercerDato As String
    Private _opcion As String
    Private _tabla As String

    Public Property PrimerDato As String
        Get
            Return _primerDato
        End Get
        Set(value As String)
            _primerDato = value
        End Set
    End Property

    Public Property SegundoDato As String
        Get
            Return _segundoDato
        End Get
        Set(value As String)
            _segundoDato = value
        End Set
    End Property

    Public Property TercerDato As String
        Get
            Return _tercerDato
        End Get
        Set(value As String)
            _tercerDato = value
        End Set
    End Property

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_OK.Click

        If txtBox_Primero.Enabled Then
            _primerDato = txtBox_Primero.Text
        Else
            _primerDato = cbo_Primero.Text
        End If

        _segundoDato = txtBox_Segundo.Text
        _tercerDato = txtBox_Tercero.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Public Sub New(opcion As String, tabla As String, label1 As String, label2 As String, label3 As String)

        InitializeComponent()
        _opcion = opcion
        _tabla = tabla
        lbl_PrimerBox.Text = label1
        lbl_SegundoBox.Text = label2
        lbl_TercerBox.Text = label3
        lbl_Titulo.Text = opcion + " " + tabla

    End Sub

    Public Sub New(opcion As String, tabla As String, label1 As String, label2 As String, label3 As String, label4 As String)
        InitializeComponent()
        _opcion = opcion
        _tabla = tabla
        lbl_PrimerBox.Text = label1
        lbl_SegundoBox.Text = label2
        lbl_TercerBox.Text = label3
        lbl_Titulo.Text = opcion + " " + tabla
        lbl_Cuarto.Text = label4

    End Sub

    Private Sub FormDosBotones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim eleccion As Integer = 0
        If (_opcion = "Cargar" OrElse _opcion = "Modificar") AndAlso (_tabla = "producto" OrElse _tabla = "venta de items") Then
            eleccion = 1
        End If

        If eleccion = 1 Then
            Dim comboBox As List(Of String)
            txtBox_Primero.Enabled = False
            txtBox_Primero.Visible = False
            cbo_Primero.Enabled = True
            cbo_Primero.Visible = True
            If _tabla = "venta de items" Then
                lbl_Cuarto.Visible = True
                lbl_Quinto.Visible = True
                comboBox = BaseDeDatos.ObtenerLista("ID", "Nombre", "productos")
            Else
                comboBox = BaseDeDatos.ObtenerLista("Categoria", "productos")
            End If
            cbo_Primero.Items.AddRange(comboBox.ToArray())

        End If

    End Sub
    Public Sub PasarDatos(primerDato As String, segundoDato As String, tercerDato As String)
        txtBox_Primero.Text = primerDato
        cbo_Primero.Text = primerDato
        txtBox_Segundo.Text = segundoDato
        txtBox_Tercero.Text = tercerDato
    End Sub

    Private Sub cbo_Primero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Primero.SelectedIndexChanged
        HacerMultiplicacion()
    End Sub
    Private Sub HacerMultiplicacion()
        If _tabla = "venta de items" Then
            Dim cantidad As Single = Nothing
            Dim id As String = FormNuevaVenta.ObtenerID(cbo_Primero.Text)
            If id IsNot Nothing AndAlso Single.TryParse(txtBox_Segundo.Text, cantidad) = True Then
                Dim producto As Producto = BaseDeDatos.TraerProducto(id)
                Dim total As Single = cantidad * producto.Precio
                txtBox_Tercero.Text = producto.Precio
                lbl_Quinto.Text = $"${total}"
            End If
        End If
    End Sub

    Private Sub txtBox_Segundo_TextChanged(sender As Object, e As EventArgs) Handles txtBox_Segundo.TextChanged
        HacerMultiplicacion()
    End Sub

    Private Sub txtBox_Tercero_TextChanged(sender As Object, e As EventArgs) Handles txtBox_Tercero.TextChanged
        HacerMultiplicacion()
    End Sub
End Class