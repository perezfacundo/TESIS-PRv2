Public Class Transporte

    Private _idTranpsorte As String
    Public Property IdTransporte() As Integer
        Get
            Return _idTranpsorte
        End Get
        Set(ByVal value As Integer)
            _idTranpsorte = value
        End Set
    End Property

    Private _patente As String
    Public Property Patente() As String
        Get
            Return _patente
        End Get
        Set(ByVal value As String)
            _patente = value
        End Set
    End Property

    Private _marca As String
    Public Property Marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    Private _modelo As String
    Public Property Modelo() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
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

    Private _capacidad As Integer
    Public Property Capacidad() As Integer
        Get
            Return _capacidad
        End Get
        Set(ByVal value As Integer)
            _capacidad = value
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
