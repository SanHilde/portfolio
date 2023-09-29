Imports Clases
Imports System.Reflection
Public Class FormMenuPrincipal
    Private Sub SubMenu_CargarCliente_Click(sender As Object, e As EventArgs) Handles SubMenu_CargarCliente.Click
        Dim formCargar As New FormABM("Cargar", "cliente", "Cliente", "Correo", "Telefono")
        formCargar.Location = New Point(Me.Location.X + Me.Width - formCargar.Width - 8, Me.Location.Y + Me.Height - formCargar.Height - 8)
        Dim clienteCreado As Cliente = CargarCliente(formCargar)
        If Not clienteCreado Is Nothing Then
            BaseDeDatos.Agregar(clienteCreado)
            MessageBox.Show("Se realizó la operación con éxito")
        End If
        pic_linea2.Visible = False
    End Sub


    Private Sub SubMenu_CargarProducto_Click(sender As Object, e As EventArgs) Handles SubMenu_CargarProducto.Click
        Dim formCargar As New FormABM("Cargar", "producto", "Categoria", "Nombre", "Precio")
        formCargar.Location = New Point(Me.Location.X + Me.Width - formCargar.Width - 8, Me.Location.Y + Me.Height - formCargar.Height - 8)
        Dim productoCreado As Producto = CargarProducto(formCargar)
        If Not productoCreado Is Nothing Then
            BaseDeDatos.Agregar(productoCreado)
            MessageBox.Show("Se realizó la operación con éxito")
        End If
        pic_linea2.Visible = False
    End Sub
    Private Sub SubMenu_CrearVenta_Click(sender As Object, e As EventArgs) Handles SubMenu_CrearVenta.Click
        Dim formVenta As New FormNuevaVenta()
        formVenta.Location = New Point(Me.Location.X + 145, Me.Location.Y + 40)
        pic_linea2.Visible = True
        Dim dg As DialogResult = formVenta.ShowDialog()
        If dg = DialogResult.OK Then
            Dim ventaCreada = New Ventas(formVenta.IdCliente, formVenta.Fecha, formVenta.Total)
            BaseDeDatos.Agregar(ventaCreada)
            MessageBox.Show("Se realizó la operación con éxito")
        End If
        pic_linea2.Visible = False
    End Sub

    Private Sub SubMenu_BuscarCliente_Click(sender As Object, e As EventArgs) Handles SubMenu_BuscarCliente.Click
        SetearFiltro(True, "Cliente", "Telefono", "Correo", "clientes")
        Dim listaClientes = New List(Of Cliente)
        BaseDeDatos.TraerConFiltro(listaClientes, Nothing, Nothing)
        CargarDatosEnDataGrid(listaClientes)
    End Sub

    Private Sub SubMenu_BuscarProducto_Click(sender As Object, e As EventArgs) Handles SubMenu_BuscarProducto.Click
        SetearFiltro(True, "Categoria", "Nombre", "Precio", "productos")
        Dim listaClientes = New List(Of Producto)
        BaseDeDatos.TraerConFiltro(listaClientes, Nothing, Nothing)
        CargarDatosEnDataGrid(listaClientes)
    End Sub
    Private Sub SubMenu_BuscarVenta_Click(sender As Object, e As EventArgs) Handles SubMenu_BuscarVenta.Click
        SetearFiltro(True, "IDCliente", "Fecha", "Total", "ventas")
        Dim listaVentas = New List(Of Ventas)
        BaseDeDatos.TraerConFiltro(listaVentas, Nothing, Nothing)
        CargarDatosEnDataGrid(listaVentas)
    End Sub
    Private Sub SetearFiltro(valorBooleano As Boolean, primerFiltro As String, segundoFiltro As String, tercerFiltro As String, titulo As String)
        grp_Filtro.Visible = valorBooleano
        dta_Lista.Visible = valorBooleano
        btn_Borrar.Visible = valorBooleano
        btn_Editar.Visible = valorBooleano
        lbl_Titulo.Visible = valorBooleano
        rdb_filtroUno.Text = primerFiltro
        rdb_filtroDos.Text = segundoFiltro
        rdb_filtroTres.Text = tercerFiltro
        pic_linea2.Visible = valorBooleano
        lbl_Titulo.Text = $"Buscar {titulo}"
    End Sub
    Private Sub CargarDatosEnDataGrid(Of T)(lista As List(Of T))
        dta_Lista.Rows.Clear()
        dta_Lista.Columns.Clear()

        Dim properties As PropertyInfo() = GetType(T).GetProperties()

        For Each prop As PropertyInfo In properties

            If prop.Name = "IdCliente" Then
                dta_Lista.Columns.Add("Cliente", "Cliente")
            Else
                dta_Lista.Columns.Add(prop.Name, prop.Name)
            End If
        Next

        For Each item As T In lista
            Dim values As New List(Of Object)()

            For Each prop As PropertyInfo In properties
                If prop.Name = "IdCliente" Then
                    Dim cliente As Cliente = BaseDeDatos.TraerCliente(Convert.ToInt32(prop.GetValue(item)))
                    values.Add($"{prop.GetValue(item)}-{cliente.Cliente}")
                Else
                    values.Add(prop.GetValue(item))
                End If
            Next

            dta_Lista.Rows.Add(values.ToArray())
        Next

    End Sub

    Public Sub ActualizarFiltro()
        Dim categoriaSeleccionada As String = Nothing

        If rdb_filtroUno.Checked Then
            categoriaSeleccionada = rdb_filtroUno.Text
        Else
            If rdb_filtroDos.Checked Then
                categoriaSeleccionada = rdb_filtroDos.Text
            Else
                If rdb_filtroTres.Checked Then
                    categoriaSeleccionada = rdb_filtroTres.Text
                End If
            End If
        End If

        If categoriaSeleccionada <> Nothing Then
            Select Case lbl_Titulo.Text
                Case "Buscar productos"
                    ActualizarProductos(txt_Filtro.Text, categoriaSeleccionada)
                Case "Buscar clientes"
                    ActualizarClientes(txt_Filtro.Text, categoriaSeleccionada)
                Case "Buscar ventas"
                    If rdb_filtroDos.Checked = True Then
                        ActualizarVentas(time_Fecha.Value.Date.ToString("yyyy-MM-dd"), categoriaSeleccionada)
                    Else
                        ActualizarVentas(txt_Filtro.Text, categoriaSeleccionada)
                    End If

            End Select
        End If
    End Sub
    Private Sub ActualizarProductos(filtro As String, categoria As String)
        Dim lista As New List(Of Producto)
        BaseDeDatos.TraerConFiltro(lista, filtro, categoria)
        CargarDatosEnDataGrid(lista)
    End Sub
    Private Sub ActualizarClientes(filtro As String, categoria As String)
        Dim lista As New List(Of Cliente)
        BaseDeDatos.TraerConFiltro(lista, filtro, categoria)
        CargarDatosEnDataGrid(lista)
    End Sub
    Private Sub ActualizarVentas(filtro As String, categoria As String)
        Dim lista As New List(Of Ventas)
        BaseDeDatos.TraerConFiltro(lista, filtro, categoria)
        CargarDatosEnDataGrid(lista)
    End Sub
    Private Sub txt_Filtro_TextChanged(sender As Object, e As EventArgs) Handles txt_Filtro.TextChanged
        ActualizarFiltro()
    End Sub

    Private Sub rdb_filtroUno_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_filtroUno.CheckedChanged
        ActualizarFiltro()
    End Sub

    Private Sub rdb_filtroDos_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_filtroDos.CheckedChanged
        If rdb_filtroDos.Checked = True AndAlso lbl_Titulo.Text = "Buscar ventas" Then
            txt_Filtro.Visible = False
            time_Fecha.Visible = True

        Else
            txt_Filtro.Visible = True
            time_Fecha.Visible = False
        End If
        ActualizarFiltro()

    End Sub

    Private Sub rdb_filtroTres_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_filtroTres.CheckedChanged
        ActualizarFiltro()
    End Sub

    Private Sub btn_Borrar_Click(sender As Object, e As EventArgs) Handles btn_Borrar.Click
        EditarDato(AddressOf BaseDeDatos.Borrar)
    End Sub

    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        EditarDato(AddressOf BaseDeDatos.Actualizar)

    End Sub

    Private Sub EditarDato(metodoAImplementar As Action(Of Object))
        Dim rowIndex As Integer = dta_Lista.SelectedCells(0).RowIndex
        Dim selectedRow As DataGridViewRow = dta_Lista.Rows(rowIndex)
        Dim id As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)
        Dim primerColumna As String = selectedRow.Cells(1).Value.ToString()
        Dim segundaColumna As String = selectedRow.Cells(2).Value.ToString()
        Dim tercerColumna As String = selectedRow.Cells(3).Value.ToString()
        Dim objetoCreado As Object = Nothing
        pic_linea2.Visible = True
        If dta_Lista.SelectedCells.Count > 0 Then
            If metodoAImplementar.Method.Name = "Actualizar" Then
                Select Case lbl_Titulo.Text
                    Case "Buscar productos"
                        Dim formCargar As New FormABM("Cargar", "producto", "Categoria", "Nombre", "Precio")
                        formCargar.Location = New Point(Me.Location.X + Me.Width - formCargar.Width - 8, Me.Location.Y + Me.Height - formCargar.Height - 8)
                        formCargar.PasarDatos(primerColumna, segundaColumna, tercerColumna)
                        objetoCreado = CargarProducto(formCargar)

                    Case "Buscar clientes"
                        Dim formCargar As New FormABM("Cargar", "cliente", "Cliente", "Correo", "Telefono")
                        formCargar.Location = New Point(Me.Location.X + Me.Width - formCargar.Width - 8, Me.Location.Y + Me.Height - formCargar.Height - 8)
                        formCargar.PasarDatos(primerColumna, segundaColumna, tercerColumna)
                        objetoCreado = CargarCliente(formCargar)
                    Case "Buscar ventas"
                        Dim idCliente As Integer
                        Dim _cliente As String
                        Dim formCargar As New FormNuevaVenta()
                        formCargar.Location = New Point(Me.Location.X + 145, Me.Location.Y + 40)
                        _cliente = FormNuevaVenta.ObtenerID(primerColumna)
                        Integer.TryParse(_cliente, idCliente)
                        formCargar.PasarDatos(id, idCliente, DateTime.Parse(segundaColumna), BaseDeDatos.TraerVentasItems(id))
                        Dim dg As DialogResult = formCargar.ShowDialog()
                        If dg = DialogResult.OK Then
                            objetoCreado = New Ventas(formCargar.IdCliente, formCargar.Fecha, formCargar.Total)
                        End If
                End Select
            ElseIf metodoAImplementar.Method.Name = "Borrar" Then
                Select Case lbl_Titulo.Text
                    Case "Buscar productos"
                        objetoCreado = New Producto(primerColumna, segundaColumna, tercerColumna)
                    Case "Buscar clientes"
                        objetoCreado = New Cliente(primerColumna, segundaColumna, tercerColumna)
                    Case "Buscar ventas"
                        Dim fecha = DateTime.Parse(segundaColumna)
                        Dim idCliente As Integer
                        Dim total As Single
                        Integer.TryParse(primerColumna, idCliente)
                        Single.TryParse(primerColumna, total)
                        objetoCreado = New Ventas(idCliente, fecha, total)
                End Select
            End If
            If objetoCreado IsNot Nothing Then
                Dim respuesta As DialogResult = MessageBox.Show("Estas seguro que quieres realizar la siguiente operación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If respuesta = DialogResult.Yes Then
                    objetoCreado.Id = id
                    metodoAImplementar(objetoCreado)
                    Select Case lbl_Titulo.Text
                        Case "Buscar productos"
                            ActualizarProductos(Nothing, Nothing)
                        Case "Buscar clientes"
                            ActualizarClientes(Nothing, Nothing)
                        Case "Buscar ventas"
                            ActualizarVentas(Nothing, Nothing)
                    End Select
                End If
            End If
            pic_linea2.Visible = False
        Else
            MessageBox.Show("Seleccione una fila para cargar el cliente.")
        End If
    End Sub

    Private Function CargarCliente(formCargar As FormABM) As Cliente
        Dim cliente As String
        Dim telefono As String
        Dim correo As String
        Dim clienteCreado As Cliente = Nothing
        Dim telefonoParseado As Single
        Dim bandera As Integer = 0
        pic_linea2.Visible = True
        Dim dg As DialogResult = formCargar.ShowDialog()

        While bandera = 0
            If (dg = DialogResult.OK) Then
                cliente = formCargar.PrimerDato
                correo = formCargar.SegundoDato
                telefono = formCargar.TercerDato
                If Single.TryParse(formCargar.TercerDato, telefonoParseado) = True Then
                    clienteCreado = New Cliente(cliente, telefonoParseado, correo)
                    bandera = 1
                Else
                    MessageBox.Show("No ingresó un número en el campo de teléfono")
                    dg = formCargar.ShowDialog()
                End If
            Else
                bandera = 1
            End If
        End While

        Return clienteCreado
    End Function

    Private Function CargarProducto(formCargar As FormABM) As Producto
        Dim nombre As String
        Dim categoria As String
        Dim precio As Single
        Dim productoCreado As Producto = Nothing
        Dim bandera As Integer = 0
        pic_linea2.Visible = True
        Dim dg As DialogResult = formCargar.ShowDialog()
        While bandera = 0
            If (dg = DialogResult.OK) Then
                categoria = formCargar.PrimerDato
                nombre = formCargar.SegundoDato
                If Single.TryParse(formCargar.TercerDato, precio) = True Then
                    productoCreado = New Producto(nombre, precio, categoria)
                    bandera = 1
                Else
                    MessageBox.Show("No ingresó un número en el campo de precio")
                    dg = formCargar.ShowDialog()
                End If
            Else
                bandera = 1
            End If
        End While

        Return productoCreado
    End Function

    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time_Fecha.Value = DateTime.Now
    End Sub

    Private Sub time_Fecha_ValueChanged(sender As Object, e As EventArgs) Handles time_Fecha.ValueChanged
        ActualizarFiltro()
    End Sub

    Private Sub mnu_MenuPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnu_MenuPrincipal.ItemClicked
        SetearFiltro(False, "", "", "", "")
    End Sub

    Private Sub subMenuItem_ListadoDeProductos_Click(sender As Object, e As EventArgs) Handles subMenuItem_ListadoDeProductos.Click
        Dim formReporte = New FormReporteMensual()
        formReporte.Show()
    End Sub
End Class
