Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports System.Configuration
Imports Clases

Public Class BaseDeDatos
    Private Shared _connection As SqlConnection
    Private Shared _command As SqlCommand
    Private Shared _connectionString As String


    Shared Sub New()
        _connectionString = ConfigurationManager.ConnectionStrings("Examen_Tactica.My.MySettings.StrCon").ConnectionString
        _connection = New SqlConnection(_connectionString)
        _command = _connection.CreateCommand()

        _command.CommandType = System.Data.CommandType.Text

    End Sub

    Public Shared Sub Agregar(clientePasado As Cliente)
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"

            _command.CommandText = query
            _command.Parameters.AddWithValue("@Cliente", clientePasado.Cliente)
            _command.Parameters.AddWithValue("@Telefono", clientePasado.Telefono)
            _command.Parameters.AddWithValue("@Correo", clientePasado.Correo)
            _command.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub

    Public Shared Sub Agregar(venta As Ventas)
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "INSERT INTO ventas (IdCliente, Fecha, Total) VALUES (@IdCliente, @Fecha, @Total)"
            _command.CommandText = query
            _command.Parameters.AddWithValue("@IdCliente", venta.IdCliente)
            _command.Parameters.AddWithValue("@Fecha", venta.Fecha)
            _command.Parameters.AddWithValue("@Total", venta.Total)
            _command.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub

    Public Shared Sub Agregar(productoPasado As Producto)

        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "INSERT INTO productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"

            _command.CommandText = query
            _command.Parameters.AddWithValue("@Nombre", productoPasado.Nombre)
            _command.Parameters.AddWithValue("@Precio", productoPasado.Precio)
            _command.Parameters.AddWithValue("@Categoria", productoPasado.Categoria)
            _command.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub
    Public Shared Sub Agregar(ventaItemPasado As VentasItems)
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"
            _command.CommandText = query
            _command.Parameters.AddWithValue("@IDVenta", ventaItemPasado.IdVenta)
            _command.Parameters.AddWithValue("@IDProducto", ventaItemPasado.IdProducto)
            _command.Parameters.AddWithValue("@PrecioUnitario", ventaItemPasado.PrecioUnitario)
            _command.Parameters.AddWithValue("@Cantidad", ventaItemPasado.Cantidad)
            _command.Parameters.AddWithValue("@PrecioTotal", ventaItemPasado.PrecioTotal)
            _command.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub

    Public Shared Sub TraerConFiltro(lista As List(Of Producto), filtro As String, columnaAFiltrar As String)
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "SELECT ID, Nombre, Precio, Categoria FROM productos"

            If Not String.IsNullOrEmpty(filtro) AndAlso Not String.IsNullOrEmpty(columnaAFiltrar) Then
                query &= $" WHERE {columnaAFiltrar} LIKE @Filtro"
                _command.Parameters.AddWithValue("@Filtro", "%" & filtro & "%")
            End If

            _command.CommandText = query

            Using reader As SqlDataReader = _command.ExecuteReader()
                While reader.Read()
                    Dim producto As New Producto()
                    producto.Id = reader.GetInt32(0)
                    producto.Nombre = reader.GetString(1)
                    producto.Precio = reader.GetDouble(2)
                    producto.Categoria = reader.GetString(3)
                    lista.Add(producto)
                End While
            End Using
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub
    Public Shared Sub TraerConFiltro(lista As List(Of Ventas), filtro As String, columnaAFiltrar As String)
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "SELECT ID, IDCliente, Fecha, Total FROM ventas"

            If Not String.IsNullOrEmpty(filtro) AndAlso Not String.IsNullOrEmpty(columnaAFiltrar) Then
                If columnaAFiltrar = "Fecha" Then
                    Dim filtroFecha As DateTime
                    If DateTime.TryParse(filtro, filtroFecha) Then
                        ' Crear un rango de fechas para el filtro (desde el inicio del día hasta el final del día)
                        Dim fechaInicio As DateTime = filtroFecha.Date
                        Dim fechaFin As DateTime = fechaInicio.AddDays(1)

                        query &= $" WHERE {columnaAFiltrar} >= @FechaInicio AND {columnaAFiltrar} < @FechaFin"
                        _command.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                        _command.Parameters.AddWithValue("@FechaFin", fechaFin)
                    Else
                        ' La conversión de la fecha falló, no se agrega ningún filtro
                    End If
                Else
                    query &= $" WHERE {columnaAFiltrar} LIKE @FiltroTexto"
                    _command.Parameters.AddWithValue("@FiltroTexto", "%" & filtro & "%")
                End If
            End If

            _command.CommandText = query

            Using reader As SqlDataReader = _command.ExecuteReader()
                While reader.Read()
                    Dim venta As New Ventas()
                    venta.Id = reader.GetInt32(0)
                    venta.IdCliente = reader.GetInt32(1)
                    venta.Fecha = reader.GetDateTime(2)
                    venta.Total = reader.GetDouble(3)
                    lista.Add(venta)
                End While
            End Using
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub

    Public Shared Sub TraerConFiltroMesElegido(lista As List(Of Ventas), filtro As String, columnaAFiltrar As String)
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "SELECT ID, IDCliente, Fecha, Total FROM ventas"

            If Not String.IsNullOrEmpty(filtro) AndAlso Not String.IsNullOrEmpty(columnaAFiltrar) Then
                If columnaAFiltrar = "Fecha" Then
                    Dim filtroFecha As DateTime
                    If DateTime.TryParse(filtro, filtroFecha) Then
                        Dim primerDiaDelMesElegido As New DateTime(filtroFecha.Year, filtroFecha.Month, 1)
                        Dim ultimoDiaDelMesElegido As DateTime = New Date(filtroFecha.Year, filtroFecha.Month, DateTime.DaysInMonth(filtroFecha.Year, filtroFecha.Month))

                        query &= $" WHERE {columnaAFiltrar} >= @PrimerDiaDelMesElegido AND {columnaAFiltrar} <= @UltimoDiaDelMesElegido"
                        _command.Parameters.AddWithValue("@PrimerDiaDelMesElegido", primerDiaDelMesElegido)
                        _command.Parameters.AddWithValue("@UltimoDiaDelMesElegido", ultimoDiaDelMesElegido)
                    End If
                Else
                    query &= $" WHERE {columnaAFiltrar} LIKE @FiltroTexto"
                    _command.Parameters.AddWithValue("@FiltroTexto", "%" & filtro & "%")
                End If
            End If

            _command.CommandText = query

            Using reader As SqlDataReader = _command.ExecuteReader()
                While reader.Read()
                    Dim venta As New Ventas()
                    venta.Id = reader.GetInt32(0)
                    venta.IdCliente = reader.GetInt32(1)
                    venta.Fecha = reader.GetDateTime(2)
                    venta.Total = reader.GetDouble(3)
                    lista.Add(venta)
                End While
            End Using
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub

    Public Shared Sub TraerConFiltro(lista As List(Of Cliente), filtro As String, columnaAFiltrar As String)
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "SELECT ID, Cliente, Telefono, Correo FROM clientes"

            If Not String.IsNullOrEmpty(filtro) AndAlso Not String.IsNullOrEmpty(columnaAFiltrar) Then
                query &= $" WHERE {columnaAFiltrar} LIKE @Filtro"
                _command.Parameters.AddWithValue("@Filtro", "%" & filtro & "%")
            End If

            _command.CommandText = query

            Using reader As SqlDataReader = _command.ExecuteReader()
                While reader.Read()
                    Dim cliente As New Cliente()
                    cliente.Id = reader.GetInt32(0)
                    cliente.Cliente = reader.GetString(1)
                    cliente.Telefono = reader.GetString(2)
                    cliente.Correo = reader.GetString(3)
                    lista.Add(cliente)
                End While
            End Using
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub

    Public Shared Function TraerCliente(idCliente As Integer) As Cliente
        Dim cliente As Cliente = Nothing
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "SELECT Cliente, Telefono, Correo FROM clientes WHERE ID = @IdCliente"
            _command.CommandText = query
            _command.Parameters.AddWithValue("@IdCliente", idCliente)

            Using reader As SqlDataReader = _command.ExecuteReader()
                If reader.Read() Then
                    cliente = New Cliente()
                    cliente.Id = idCliente
                    cliente.Cliente = reader.GetString(0)
                    cliente.Telefono = reader.GetString(1)
                    cliente.Correo = reader.GetString(2)
                End If
            End Using

            Return cliente
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Function
    Public Shared Function TraerProducto(idProducto As Integer) As Producto
        Dim producto As Producto = Nothing
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "SELECT Nombre, Precio, Categoria FROM productos WHERE ID = @IdProducto"
            _command.CommandText = query
            _command.Parameters.AddWithValue("@IdProducto", idProducto)

            Using reader As SqlDataReader = _command.ExecuteReader()
                If reader.Read() Then
                    producto = New Producto()
                    producto.Id = idProducto
                    producto.Nombre = reader.GetString(0)
                    producto.Precio = reader.GetDouble(1)
                    producto.Categoria = reader.GetString(2)
                End If
            End Using

            Return producto
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Function

    Public Shared Sub Actualizar(objetoPasado As Object)
        Try
            _command.Parameters.Clear()
            _connection.Open()
            If TypeOf objetoPasado Is Cliente Then
                Dim clientePasado As Cliente = DirectCast(objetoPasado, Cliente)
                Dim query As String = "UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID"
                _command.CommandText = query
                _command.Parameters.AddWithValue("@Cliente", clientePasado.Cliente)
                _command.Parameters.AddWithValue("@Telefono", clientePasado.Telefono)
                _command.Parameters.AddWithValue("@Correo", clientePasado.Correo)
                _command.Parameters.AddWithValue("@ID", clientePasado.Id)

            ElseIf TypeOf objetoPasado Is Producto Then
                Dim productoPasado As Producto = DirectCast(objetoPasado, Producto)
                Dim query As String = "UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID"
                _command.CommandText = query
                _command.Parameters.AddWithValue("@Nombre", productoPasado.Nombre)
                _command.Parameters.AddWithValue("@Precio", productoPasado.Precio)
                _command.Parameters.AddWithValue("@Categoria", productoPasado.Categoria)
                _command.Parameters.AddWithValue("@ID", productoPasado.Id)

            ElseIf TypeOf objetoPasado Is VentasItems Then
                Dim ventaPasada As VentasItems = DirectCast(objetoPasado, VentasItems)
                Dim query As String = "UPDATE ventasitems SET IDVenta = @IDVenta, IDProducto = @IDProducto, PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal WHERE ID = @ID"
                _command.CommandText = query
                _command.Parameters.AddWithValue("@IDVenta", ventaPasada.IdVenta)
                _command.Parameters.AddWithValue("@IDProducto", ventaPasada.IdProducto)
                _command.Parameters.AddWithValue("@PrecioUnitario", ventaPasada.PrecioUnitario)
                _command.Parameters.AddWithValue("@Cantidad", ventaPasada.Cantidad)
                _command.Parameters.AddWithValue("@PrecioTotal", ventaPasada.PrecioTotal)
                _command.Parameters.AddWithValue("@ID", ventaPasada.Id)

            ElseIf TypeOf objetoPasado Is Ventas Then
                Dim ventaPasada As Ventas = DirectCast(objetoPasado, Ventas)
                Dim query As String = "UPDATE ventas SET IDCliente = @IDCliente, Fecha = @Fecha, Total = @Total WHERE ID = @ID"
                _command.CommandText = query
                _command.Parameters.AddWithValue("@IDCliente", ventaPasada.IdCliente)
                _command.Parameters.AddWithValue("@Fecha", ventaPasada.Fecha)
                _command.Parameters.AddWithValue("@Total", ventaPasada.Total)
                _command.Parameters.AddWithValue("@ID", ventaPasada.Id)
            End If

            _command.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub

    Public Shared Function ObtenerLista(columna As String, tabla As String) As List(Of String)
        Dim lista As New List(Of String)()

        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = $"SELECT DISTINCT {columna} FROM {tabla}"
            _command.CommandText = query

            Using reader As SqlDataReader = _command.ExecuteReader()
                While reader.Read()
                    Dim dato As String = reader(columna).ToString()
                    lista.Add(dato)
                End While
            End Using
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try

        Return lista
    End Function
    Public Shared Function ObtenerLista(columna1 As String, columna2 As String, tabla As String) As List(Of String)
        Dim lista As New List(Of String)()

        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = $"SELECT DISTINCT {columna1}, {columna2} FROM {tabla}"
            _command.CommandText = query

            Using reader As SqlDataReader = _command.ExecuteReader()
                While reader.Read()
                    Dim dato1 As String = reader(columna1).ToString()
                    Dim dato2 As String = reader(columna2).ToString()
                    Dim datoCompleto As String = $"{dato1}-{dato2}"
                    lista.Add(datoCompleto)
                End While
            End Using
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try

        Return lista
    End Function

    Public Shared Sub Borrar(objetoPasado As Object)
        Try
            _command.Parameters.Clear()
            _connection.Open()

            If TypeOf objetoPasado Is Cliente Then
                Dim clientePasado As Cliente = DirectCast(objetoPasado, Cliente)
                Dim query As String = "DELETE FROM clientes WHERE ID = @ID"
                _command.CommandText = query
                _command.Parameters.AddWithValue("@ID", clientePasado.Id)
            ElseIf TypeOf objetoPasado Is Producto Then
                Dim productoPasado As Producto = DirectCast(objetoPasado, Producto)
                Dim query As String = "DELETE FROM productos WHERE ID = @ID"
                _command.CommandText = query
                _command.Parameters.AddWithValue("@ID", productoPasado.Id)
            ElseIf TypeOf objetoPasado Is VentasItems Then
                Dim ventaItem As VentasItems = DirectCast(objetoPasado, VentasItems)
                Dim query As String = "DELETE FROM ventasitems WHERE ID = @ID"
                _command.CommandText = query
                _command.Parameters.AddWithValue("@ID", ventaItem.Id)
            ElseIf TypeOf objetoPasado Is Ventas Then
                Dim ventaPasada As Ventas = DirectCast(objetoPasado, Ventas)
                Dim query As String = "DELETE FROM ventas WHERE ID = @ID"
                _command.CommandText = query
                _command.Parameters.AddWithValue("@ID", ventaPasada.Id)
            End If

            _command.ExecuteNonQuery()
            MessageBox.Show("Se realizó la operación con éxito")
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Sub

    Public Shared Function ObtenerUltimoID(tabla As String) As Integer
        Dim ultimoID As Integer = 0

        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = $"SELECT MAX(ID) FROM {tabla}"
            _command.CommandText = query

            Dim result As Object = _command.ExecuteScalar()

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                ultimoID = Convert.ToInt32(result)
            End If
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try

        Return ultimoID + 1
    End Function
    Public Shared Function ExisteIdEnTabla(id As Integer, tabla As String) As Boolean
        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = $"SELECT COUNT(*) FROM {tabla} WHERE ID = @ID"
            _command.CommandText = query
            _command.Parameters.AddWithValue("@ID", id)

            Dim count As Integer = Convert.ToInt32(_command.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try
    End Function
    Public Shared Function TraerVentasItems(idVenta As Integer) As List(Of VentasItems)
        Dim listaVentasItems As New List(Of VentasItems)()

        Try
            _command.Parameters.Clear()
            _connection.Open()

            Dim query As String = "SELECT ID, IDProducto, PrecioUnitario, Cantidad, PrecioTotal FROM ventasitems WHERE IDVenta = @IDVenta"
            _command.CommandText = query
            _command.Parameters.AddWithValue("@IDVenta", idVenta)

            Using reader As SqlDataReader = _command.ExecuteReader()
                While reader.Read()
                    Dim ventaItem As New VentasItems()
                    ventaItem.Id = reader.GetInt32(0)
                    ventaItem.IdProducto = reader.GetInt32(1)
                    ventaItem.PrecioUnitario = reader.GetDouble(2)
                    ventaItem.Cantidad = reader.GetDouble(3)
                    ventaItem.PrecioTotal = reader.GetDouble(4)
                    ventaItem.IdVenta = idVenta
                    listaVentasItems.Add(ventaItem)
                End While
            End Using
        Catch ex As Exception
            Throw
        Finally
            _connection.Close()
        End Try

        Return listaVentasItems
    End Function

End Class
