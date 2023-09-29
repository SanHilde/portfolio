Imports Clases
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Public Class FormReporteMensual
    Private Sub FormReporteMensual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarReporte()
    End Sub
    Private Function ActualizarReporte()
        Dim cantidadesPorProducto As New Dictionary(Of Integer, Integer)()
        Dim listaVentas = New List(Of Ventas)
        Dim listaVentasItems = New List(Of VentasItems)
        BaseDeDatos.TraerConFiltroMesElegido(listaVentas, time_Fecha.Value.Date.ToString("yyyy-MM-dd"), "Fecha")
        lbl_ConceptoDatos.Text = ""
        lbl_CantidaDatos.Text = ""
        lbl_PrecioDatos.Text = ""
        lbl_TotalDatos.Text = ""
        For Each venta In listaVentas
            listaVentasItems = BaseDeDatos.TraerVentasItems(venta.Id)
            For Each ventaItems In listaVentasItems
                If cantidadesPorProducto.ContainsKey(ventaItems.IdProducto) Then
                    cantidadesPorProducto(ventaItems.IdProducto) += ventaItems.Cantidad
                Else
                    cantidadesPorProducto.Add(ventaItems.IdProducto, ventaItems.Cantidad)
                End If
            Next
        Next
        For Each kvp In cantidadesPorProducto
            Dim producto As Producto = BaseDeDatos.TraerProducto(kvp.Key)
            lbl_ConceptoDatos.Text = $"{lbl_ConceptoDatos.Text}{producto.Nombre}{vbCrLf}"
            lbl_CantidaDatos.Text = $"{lbl_CantidaDatos.Text}{kvp.Value}{vbCrLf}"
            lbl_PrecioDatos.Text = $"{lbl_PrecioDatos.Text}{producto.Precio}{vbCrLf}"
            lbl_TotalDatos.Text = $"{lbl_TotalDatos.Text}{producto.Precio * kvp.Value}{vbCrLf}"
        Next
    End Function

    Private Sub time_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles time_Fecha.ValueChanged
        ActualizarReporte()
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Dim nombreArchivo As String = $"ReporteDeVentasMes-{time_Fecha.Value.Month}-{time_Fecha.Value.Year}.jpg"
        btn_Exportar.Visible = False
        ExportarFormularioAImagen(nombreArchivo)
        btn_Exportar.Visible = True
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
End Class