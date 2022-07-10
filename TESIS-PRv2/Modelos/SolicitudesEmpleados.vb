Public Class SolicitudesEmpleados

    Private _idSE As Integer
    Public Property IdSE() As Integer
        Get
            Return _idSE
        End Get
        Set(ByVal value As Integer)
            _idSE = value
        End Set
    End Property

    Private _idSolicitud As Integer
    Public Property IdSolicitud() As Integer
        Get
            Return _idSolicitud
        End Get
        Set(ByVal value As Integer)
            _idSolicitud = value
        End Set
    End Property

    Private _dniEmpleado As Integer
    Public Property DniEmpleado() As Integer
        Get
            Return _dniEmpleado
        End Get
        Set(ByVal value As Integer)
            _dniEmpleado = value
        End Set
    End Property
End Class
