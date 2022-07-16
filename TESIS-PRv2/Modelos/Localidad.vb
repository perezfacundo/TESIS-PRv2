Public Class Localidad
    Private _idLocalidad As Integer
    Public Property IdLocalidad() As Integer
        Get
            Return _idLocalidad
        End Get
        Set(ByVal value As Integer)
            _idLocalidad = value
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

    Private _idProvincia As Integer
    Public Property IdProvincia() As Integer
        Get
            Return _idProvincia
        End Get
        Set(ByVal value As Integer)
            _idProvincia = value
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
