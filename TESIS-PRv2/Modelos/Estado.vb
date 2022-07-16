Public Class Estado
    Private _idEstado As Integer
    Public Property IdEstado() As Integer
        Get
            Return _idEstado
        End Get
        Set(ByVal value As Integer)
            _idEstado = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _tipoRegistro As String
    Public Property TipoRegistro() As String
        Get
            Return _tipoRegistro
        End Get
        Set(ByVal value As String)
            _tipoRegistro = value
        End Set
    End Property
End Class
