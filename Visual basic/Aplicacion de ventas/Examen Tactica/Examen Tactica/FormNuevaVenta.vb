Imports Clases
Imports System.Reflection
Public Class FormNuevaVenta
    Private _listaDeItemsVendidos As List(Of VentasItems)
    Private _listaDeItemsBorrados As List(Of VentasItems)
    Private _id As Integer
    Private _idCliente As Integer
    Private _fecha As Date
    Private _total As Single
    Private _primerIDVenta As Integer

    Public Sub New()
        InitializeComponent()
        Me.Id = -1
        Me.IdCliente = -1
        Me.Fecha = DateTime.Now
        Me.Total = 0
        _listaDeItemsVendidos = New List(Of VentasItems)
        _listaDeItemsBorrados = New List(Of VentasItems)
        time_Fecha.Value = Fecha
    End Sub

    Public Property ListaDeItemsVendidos As List(Of VentasItems)
        Get
            Return _listaDeItemsVendidos
        End Get
        Set(value As List(Of VentasItems))
            _listaDeItemsVendidos = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Total As Single
        Get
            Return _total
        End Get
        Set(value As Single)
            _total = value
        End Set
    End Property


    Private Sub FormNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Me.Location.X - 135, Me.Location.Y + 25)
        Dim clientes As List(Of String) = BaseDeDatos.ObtenerLista("ID", "Cliente", "clientes")
        cbo_Cliente.Items.AddRange(clientes.ToArray())
        If Id < 0 Then
            Id = BaseDeDatos.ObtenerUltimoID("ventas")
        Else
            CargarDatosEnDataGrid(_listaDeItemsVendidos)
            Dim cliente As Cliente = BaseDeDatos.TraerCliente(_idCliente)
            cbo_Cliente.Text = $"{_idCliente}-{cliente.Cliente}"
        End If
        lbl_Titulo.Text = $"Venta N°: {Id}"
        _primerIDVenta = BaseDeDatos.ObtenerUltimoID("ventasitems")
    End Sub

    Private Sub btn_AgregarProducto_Click(sender As Object, e As EventArgs) Handles btn_AgregarProducto.Click
        Dim formCargar As New FormABM("Cargar", "venta de items", "Producto", "Cantidad", "Precio unitario", "Precio total")
        formCargar.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y + 5)
        Dim ventaDeItem As VentasItems = CargarVentaItem(formCargar)
        If ventaDeItem IsNot Nothing Then
            ventaDeItem.Id = _primerIDVenta + _listaDeItemsVendidos.Count
            _listaDeItemsVendidos.Add(ventaDeItem)
            MessageBox.Show("Se realizó la operación con éxito")
        End If
        If _listaDeItemsVendidos.Count > 0 Then
            CargarDatosEnDataGrid(_listaDeItemsVendidos)
        End If
    End Sub
    Private Function CargarVentaItem(formCargar As FormABM) As VentasItems
        Dim idProducto As String
        Dim cantidad As Single
        Dim precioTotal As Single
        Dim precioUnitario As Single
        Dim ventaItemCreado As VentasItems = Nothing
        Dim bandera As Integer = 0

        Dim dg As DialogResult = formCargar.ShowDialog()

        While bandera = 0
            If (dg = DialogResult.OK) Then
                idProducto = ObtenerID(formCargar.PrimerDato)
                Single.TryParse(formCargar.TercerDato, precioUnitario)
                If Single.TryParse(formCargar.SegundoDato, cantidad) = True Then
                    precioTotal = cantidad * precioUnitario
                    ventaItemCreado = New VentasItems(Id, idProducto, precioUnitario, cantidad, precioTotal)
                    bandera = 1
                Else
                    MessageBox.Show("No ingresó un número en el campo cantidad")
                    dg = formCargar.ShowDialog()
                End If
            Else
                bandera = 1
            End If
        End While

        Return ventaItemCreado
    End Function

    Private Sub CargarDatosEnDataGrid(Of T)(lista As List(Of T))
        dta_Lista.Rows.Clear()
        dta_Lista.Columns.Clear()
        Dim sumatoriaTotal As Single = Nothing
        Dim precioTotal As Single

        lbl_TotalValor.Text = "0"

        Dim properties As PropertyInfo() = GetType(T).GetProperties()

        For Each prop As PropertyInfo In properties
            If prop.Name <> "IdVenta" Then
                If prop.Name = "IdProducto" Then
                    dta_Lista.Columns.Add("Producto", "Producto")
                Else
                    dta_Lista.Columns.Add(prop.Name, prop.Name)
                End If
            End If
        Next

        For Each item As T In lista
            Dim values As New List(Of Object)()

            For Each prop As PropertyInfo In properties
                If prop.Name <> "IdVenta" Then
                    If prop.Name = "IdProducto" Then
                        Dim producto As Producto = BaseDeDatos.TraerProducto(prop.GetValue(item))
                        values.Add($"{prop.GetValue(item)}-{producto.Nombre}")
                    Else
                        values.Add(prop.GetValue(item))
                    End If
                    If prop.Name = "PrecioTotal" Then
                        precioTotal = prop.GetValue(item)
                    End If
                End If
            Next
            dta_Lista.Rows.Add(values.ToArray())
            Single.TryParse(lbl_TotalValor.Text, sumatoriaTotal)
            sumatoriaTotal = sumatoriaTotal + precioTotal
            lbl_TotalValor.Text = sumatoriaTotal
            _total = sumatoriaTotal
        Next
    End Sub

    Public Shared Function ObtenerID(texto As String) As String
        Dim index As Integer = texto.IndexOf("-")
        Dim parteUno As String = Nothing

        If index >= 0 Then
            parteUno = texto.Substring(0, index)
        End If
        Return parteUno
    End Function

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        EditarDato(AddressOf ModificarDeLaLista)
    End Sub

    Private Sub btn_Borrar_Click(sender As Object, e As EventArgs) Handles btn_Borrar.Click
        EditarDato(AddressOf QuitarDeLaLista)

    End Sub

    Private Sub btn_GuardarVenta_Click(sender As Object, e As EventArgs) Handles btn_GuardarVenta.Click
        If Not String.IsNullOrEmpty(cbo_Cliente.Text) Then
            If _listaDeItemsVendidos.Count <> 0 Then
                If _listaDeItemsBorrados.Count <> 0 Then
                    For Each item In _listaDeItemsBorrados
                        If BaseDeDatos.ExisteIdEnTabla(item.Id, "ventasitems") = True Then
                            BaseDeDatos.Borrar(item)
                        End If
                    Next
                End If
                For Each item In _listaDeItemsVendidos
                    If BaseDeDatos.ExisteIdEnTabla(item.Id, "ventasitems") = True Then
                        BaseDeDatos.Actualizar(item)
                    Else
                        BaseDeDatos.Agregar(item)
                    End If
                Next
                _fecha = time_Fecha.Value
                Single.TryParse(lbl_TotalValor.Text, Total)
                IdCliente = ObtenerID(cbo_Cliente.Text)
                Me.DialogResult = DialogResult.OK
            Else
                MessageBox.Show("No hay items vendidos en tu venta", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("No eligio el cliente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub btn_CancelarVenta_Click(sender As Object, e As EventArgs) Handles btn_CancelarVenta.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
    Private Sub EditarDato(metodoAImplementar As Action(Of Object))

        If dta_Lista.SelectedCells.Count > 0 Then
            Dim rowIndex As Integer = dta_Lista.SelectedCells(0).RowIndex
            Dim selectedRow As DataGridViewRow = dta_Lista.Rows(rowIndex)
            Dim idVentaItem As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)
            Dim primerColumna As String = selectedRow.Cells(1).Value.ToString()
            Dim segundaColumna As String = selectedRow.Cells(2).Value.ToString()
            Dim tercerColumna As String = selectedRow.Cells(3).Value.ToString()
            Dim objetoCreado As Object = Nothing
            Dim idProducto As Integer = Nothing

            If metodoAImplementar.Method.Name = "ModificarDeLaLista" Then
                Dim formCargar As New FormABM("Cargar", "venta de items", "Producto", "Cantidad", "Precio unitario", "Precio total")
                formCargar.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y + 5)
                formCargar.PasarDatos(primerColumna, segundaColumna, tercerColumna)
                objetoCreado = CargarVentaItem(formCargar)
            ElseIf metodoAImplementar.Method.Name = "QuitarDeLaLista" Then
                Dim precioUnitario As Single
                Dim cantidad As Single
                Dim precioTotal As Single
                Single.TryParse(segundaColumna, precioUnitario)
                Single.TryParse(tercerColumna, cantidad)
                Integer.TryParse(ObtenerID(primerColumna), idProducto)
                precioTotal = cantidad * precioUnitario
                objetoCreado = New VentasItems(Id, ObtenerID(primerColumna), precioUnitario, cantidad, precioTotal)

            End If
            If objetoCreado IsNot Nothing Then
                Dim respuesta As DialogResult = MessageBox.Show("Estas seguro que quieres realizar la siguiente operación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If respuesta = DialogResult.Yes Then
                    objetoCreado.Id = idVentaItem
                    metodoAImplementar(objetoCreado)
                    CargarDatosEnDataGrid(_listaDeItemsVendidos)
                End If
            End If
        Else
            MessageBox.Show("Seleccione una fila para cargar el cliente.")
        End If
    End Sub
    Private Sub QuitarDeLaLista(objetoPasado As Object)
        Dim venta As VentasItems = DirectCast(objetoPasado, VentasItems)
        For Each item In _listaDeItemsVendidos
            If item.Id = venta.Id Then
                _listaDeItemsVendidos.Remove(item)
                _listaDeItemsBorrados.Add(item)
                Exit For
            End If
        Next

    End Sub
    Private Sub ModificarDeLaLista(objetoPasado As Object)
        Dim venta As VentasItems = DirectCast(objetoPasado, VentasItems)
        For Each item In _listaDeItemsVendidos
            If item.Id = venta.Id Then
                item.Cantidad = venta.Cantidad
                item.IdProducto = venta.IdProducto
                item.PrecioTotal = venta.PrecioTotal
                item.PrecioUnitario = venta.PrecioUnitario
                Exit For
            End If
        Next

    End Sub
    Public Sub PasarDatos(idPasado As Integer, idClientePasado As Integer, fechaPasada As DateTime, listaDeVentasPasada As List(Of VentasItems))
        Id = idPasado
        IdCliente = idClientePasado
        Fecha = fechaPasada
        _listaDeItemsVendidos = listaDeVentasPasada
    End Sub

    Private Sub btn_Factura_Click(sender As Object, e As EventArgs) Handles btn_Factura.Click

        If ListaDeItemsVendidos.Count > 0 Then
            Dim factura As New FormFactura(_listaDeItemsVendidos, _id, _idCliente, _fecha, _total)
            factura.Show()
        Else
            MessageBox.Show("No hay items cargados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class