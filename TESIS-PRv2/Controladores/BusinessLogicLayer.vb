Imports TESIS_PRv2.Cliente

Public Class BusinessLogicLayer
    Dim _dataAccessLayer As New DataAccessLayer()
    Dim filasAfectadas As Integer = 0

    'METODOS DE INSERCION
    Public Function GuardarCliente(objCliente As Cliente)

        If objCliente.IdCliente = 0 Then
            filasAfectadas = _dataAccessLayer.InsertarCliente(objCliente)
        Else
            '_dataAccessLayer.ActualizarCliente()
        End If

        Return filasAfectadas
    End Function

    Public Function GuardarTransporte(objTransporte As Transporte)

        If objTransporte.IdTransporte = 0 Then
            _dataAccessLayer.InsertarTransporte(objTransporte)
        Else
            '_dataAccessLayer.ActualizarTransporte(objTransporte)
        End If

        Return objTransporte

    End Function

    Public Sub GuardarEmpleado(objEmpleado As Empleado)

        If objEmpleado.IdEmpleado = 0 Then
            _dataAccessLayer.InsertarEmpleado(objEmpleado)
        Else
            '_dataAccessLayer.ActualizarEmpleado(objEmpleado)
        End If
    End Sub

    'METODOS DE BUSQUEDA
    Public Function BuscarClientes() As List(Of Cliente)
        Return _dataAccessLayer.BuscarClientes()
    End Function

    Public Function BuscarEmpleados() As List(Of Empleado)
        Return _dataAccessLayer.BuscarEmpleados()
    End Function

    Public Function BuscarSolicitudes() As List(Of Solicitud)
        Return _dataAccessLayer.BuscarSolicitudes()
    End Function
    Public Function BuscarTransporte() As List(Of Transporte)
        Return _dataAccessLayer.BuscarTransportes()
    End Function
    Public Function BuscarProvincia() As List(Of Provincia)
        Return _dataAccessLayer.BuscarProvincias()
    End Function
    Public Function BuscarEstados() As List(Of Estado)
        Return _dataAccessLayer.BuscarEstados()
    End Function

    Public Function BuscarLocalidades() As List(Of Localidad)
        Return _dataAccessLayer.BuscarLocalidades()
    End Function
End Class
