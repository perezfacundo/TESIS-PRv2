Public Class SolicitudesTransportes

    Private _idST As Integer
    Public Property IdST() As Integer
        Get
            Return _idST
        End Get
        Set(ByVal value As Integer)
            _idST = value
        End Set
    End Property

    Private _idSolicitud As Integer
    Public Property IdSoliciud() As Integer
        Get
            Return _idSolicitud
        End Get
        Set(ByVal value As Integer)
            _idSolicitud = value
        End Set
    End Property

    Private _idTansporte As Integer
    Public Property IdTransporte() As Integer
        Get
            Return _idTansporte
        End Get
        Set(ByVal value As Integer)
            _idTansporte = value
        End Set
    End Property
End Class
