Public Class Provincia

    Private _idProvincia As Integer
    Public Property IdProvincia() As Integer
        Get
            Return _idProvincia
        End Get
        Set(ByVal value As Integer)
            _idProvincia = value
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
