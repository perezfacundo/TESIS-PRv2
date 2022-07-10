Public Class Empleado

    Private _dniEmpleado As Integer
    Public Property DniEmpleado() As Integer
        Get
            Return _dniEmpleado
        End Get
        Set(ByVal value As Integer)
            _dniEmpleado = value
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

    Private _porcComision As Integer
    Public Property PorcComision() As Integer
        Get
            Return _porcComision
        End Get
        Set(ByVal value As Integer)
            _porcComision = value
        End Set
    End Property

    Private _idEstado As Integer
    Public Property IdEstado() As Integer
        Get
            Return _idEstado
        End Get
        Set(ByVal value As Integer)
            _idEstado = value
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
