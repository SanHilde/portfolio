Public Class VentasItems
    Private _id As Integer
    Private _idVenta As Integer
    Private _idProducto As Integer
    Private _cantidad As Single
    Private _precioUnitario As Single
    Private _precioTotal As Single

    Public Sub New()

    End Sub
    Public Sub New(idVenta As Integer, idProducto As Integer, precioUnitario As Single, cantidad As Single, precioTotal As Single)
        _idVenta = idVenta
        _idProducto = idProducto
        _precioUnitario = precioUnitario
        _cantidad = cantidad
        _precioTotal = precioTotal
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property IdVenta As Integer
        Get
            Return _idVenta
        End Get
        Set(value As Integer)
            _idVenta = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property
    Public Property Cantidad As Single
        Get
            Return _cantidad
        End Get
        Set(value As Single)
            _cantidad = value
        End Set
    End Property
    Public Property PrecioUnitario As Single
        Get
            Return _precioUnitario
        End Get
        Set(value As Single)
            _precioUnitario = value
        End Set
    End Property

    Public Property PrecioTotal As Single
        Get
            Return _precioTotal
        End Get
        Set(value As Single)
            _precioTotal = value
        End Set
    End Property
End Class
