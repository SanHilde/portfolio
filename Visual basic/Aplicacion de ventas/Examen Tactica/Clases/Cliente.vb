Public Class Cliente
    Private _id As Integer
    Private _cliente As String
    Private _correo As String
    Private _telefono As String

    Public Sub New(nombreCliente As String, telefono As String, correo As String)
        _cliente = nombreCliente
        _telefono = telefono
        _correo = correo
    End Sub

    Public Sub New()

    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property


End Class
