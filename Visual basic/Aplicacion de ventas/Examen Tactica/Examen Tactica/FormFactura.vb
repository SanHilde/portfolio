Imports System.ComponentModel
Imports Clases
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class FormFactura
    Private _listaDeItemsVendidos As List(Of VentasItems)
    Private _id As Integer
    Private _idCliente As Integer
    Private _fecha As Date
    Private _total As Single

    Public Sub New(listaDeItemsVendidos As List(Of VentasItems), id As Integer, idCliente As Integer, fecha As Date, total As Single)
        InitializeComponent()
        _listaDeItemsVendidos = listaDeItemsVendidos
        _id = id
        _idCliente = idCliente
        _fecha = fecha
        _total = total
    End Sub

    Private Sub FormFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cliente As Cliente = BaseDeDatos.TraerCliente(_idCliente)
        Dim producto As Producto = Nothing
        lbl_NombreCliente.Text = lbl_NombreCliente.Text + cliente.Cliente
        lbl_Correo.Text = lbl_Correo.Text + cliente.Correo
        lbl_Telefono.Text = lbl_Telefono.Text + cliente.Telefono
        lbl_FacturaDato.Text = _id
        lbl_FechaDato.Text = $"{_fecha.Day}/{_fecha.Month}/{_fecha.Year}"
        lbl_ConceptoDatos.Text = ""
        lbl_CantidaDatos.Text = ""
        lbl_PrecioDatos.Text = ""
        lbl_TotalDatos.Text = ""
        For Each venta In _listaDeItemsVendidos
            producto = BaseDeDatos.TraerProducto(venta.IdProducto)
            lbl_ConceptoDatos.Text = $"{lbl_ConceptoDatos.Text}{producto.Nombre}{vbCrLf}"
            lbl_CantidaDatos.Text = $"{lbl_CantidaDatos.Text}{venta.Cantidad}{vbCrLf}"
            lbl_PrecioDatos.Text = $"{lbl_PrecioDatos.Text}{venta.PrecioUnitario}{vbCrLf}"
            lbl_TotalDatos.Text = $"{lbl_TotalDatos.Text}{venta.PrecioTotal}{vbCrLf}"
        Next
        Dim yPos As Integer = lbl_ConceptoDatos.Bottom + 30

        pic_Linea2.Top = yPos - pic_Linea2.Height - 20
        lbl_TotalTitulo.Top = yPos - lbl_TotalTitulo.Height
        lbl_SumatoriaTotal.Top = yPos - lbl_SumatoriaTotal.Height
        lbl_SumatoriaTotal.Text = _total


    End Sub
    Private Sub ExportarFormularioAImagen(nombreArchivo As String)
        Dim escritorio As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim rutaArchivo As String = Path.Combine(escritorio, nombreArchivo)
        Dim contenidoRect As New Rectangle(Me.PointToScreen(Point.Empty), Me.ClientSize)
        Dim bmp As New Bitmap(contenidoRect.Width, contenidoRect.Height, PixelFormat.Format32bppArgb)
        Using gfx As Graphics = Graphics.FromImage(bmp)
            gfx.CopyFromScreen(contenidoRect.Left, contenidoRect.Top, 0, 0, contenidoRect.Size, CopyPixelOperation.SourceCopy)
        End Using
        bmp.Save(rutaArchivo, ImageFormat.Jpeg)
        bmp.Dispose()
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Dim nombreArchivo As String = $"FacturaN{_id}.jpg"
        btn_Exportar.Visible = False
        ExportarFormularioAImagen(nombreArchivo)
        btn_Exportar.Visible = True
    End Sub
End Class