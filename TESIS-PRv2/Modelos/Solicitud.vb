Public Class Solicitud
    Private _idSolicitud As Integer
    Public Property IdSolicitud() As Integer
        Get
            Return _idSolicitud
        End Get
        Set(ByVal value As Integer)
            _idSolicitud = value
        End Set
    End Property

    Private _idCliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return _idCliente
        End Get
        Set(ByVal value As Integer)
            _idCliente = value
        End Set
    End Property

    Private _coordDesde As String
    Public Property CoordDesde() As String
        Get
            Return _coordDesde
        End Get
        Set(ByVal value As String)
            _coordDesde = value
        End Set
    End Property

    Private _coordHasta As String
    Public Property CoordHasta() As String
        Get
            Return _coordHasta
        End Get
        Set(ByVal value As String)
            _coordHasta = value
        End Set
    End Property

    Private _fechaSolicitud As String
    Public Property FechaSolicitud() As String
        Get
            Return _fechaSolicitud
        End Get
        Set(ByVal value As String)
            _fechaSolicitud = value
        End Set
    End Property

    Private _fechaTrabajo As String
    Public Property FechaTrabajo() As String
        Get
            Return _fechaTrabajo
        End Get
        Set(ByVal value As String)
            _fechaTrabajo = value
        End Set
    End Property

    Private _pagoFaltante As Integer
    Public Property PagoFaltante() As Integer
        Get
            Return _pagoFaltante
        End Get
        Set(ByVal value As Integer)
            _pagoFaltante = value
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

    Private _idTipoRegistro As Integer
    Public Property IdTipoRegistro() As Integer
        Get
            Return _idTipoRegistro
        End Get
        Set(ByVal value As Integer)
            _idTipoRegistro = value
        End Set
    End Property

    Private _idProvincia As Integer
    Public Property IdProvincia() As Integer
        Get
            Return _idProvincia
        End Get
        Set(ByVal value As Integer)
            _idProvincia = value
        End Set
    End Property

    Private _idLocalidad As Integer
    Public Property IdLocalidad() As Integer
        Get
            Return _idLocalidad
        End Get
        Set(ByVal value As Integer)
            _idLocalidad = value
        End Set
    End Property
End Class
