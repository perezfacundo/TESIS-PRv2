

Public Class Cliente

    Private _idCliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Private _dniCliente As Integer
    Public Property DniCliente() As String
        Get
            Return _dniCliente
        End Get
        Set(ByVal value As String)
            _dniCliente = value
        End Set
    End Property

    Private _apellidos As String
    Public Property Apellidos() As String
        Get
            Return _apellidos
        End Get
        Set(ByVal value As String)
            _apellidos = value
        End Set
    End Property

    Private _nombres As String
    Public Property Nombres() As String
        Get
            Return _nombres
        End Get
        Set(ByVal value As String)
            _nombres = value
        End Set
    End Property

    Private _fechaNac As String
    Public Property FechaNac() As String
        Get
            Return _fechaNac
        End Get
        Set(ByVal value As String)
            _fechaNac = value
        End Set
    End Property

    Private _telefono As String
    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Private _domicilio As String
    Public Property Domicilio() As String
        Get
            Return _domicilio
        End Get
        Set(ByVal value As String)
            _domicilio = value
        End Set
    End Property

    Private _Estado As String
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property

    Private _clave As String
    Public Property Clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Private _correo As String
    Public Property Correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Private _provincia As String
    Public Property Provincia() As String
        Get
            Return _provincia
        End Get
        Set(ByVal value As String)
            _provincia = value
        End Set
    End Property

    Private _localidad As String
    Public Property Localidad() As String
        Get
            Return _localidad
        End Get
        Set(ByVal value As String)
            _localidad = value
        End Set
    End Property

    Private _idTipoRegistro As Integer
    Public Property IdTipoRegistro() As Integer
        Get
            Return _idTipoRegistro
        End Get
        Set(ByVal value As Integer)
            _idTipoRegistro = value
        End Set
    End Property
End Class
