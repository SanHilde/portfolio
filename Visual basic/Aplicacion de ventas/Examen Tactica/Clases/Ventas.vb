Public Class Ventas
    Private _id As Integer
    Private _idCliente As Integer
    Private _fecha As Date
    Private _total As Single

    Public Sub New()

    End Sub
    Public Sub New(idCliente As Integer, fecha As Date, total As Single)
        Me.IdCliente = idCliente
        Me.Fecha = fecha
        Me.Total = total
    End Sub

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

End Class
