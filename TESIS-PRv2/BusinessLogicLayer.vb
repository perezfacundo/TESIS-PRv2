Imports TESIS_PRv2.Cliente

Public Class BusinessLogicLayer

    Private _dataAccessLayer As DataAccessLayer

    Public Sub BusinessLogicLayer()
        _dataAccessLayer = New DataAccessLayer()
    End Sub

    Public Sub GuardarCliente(objCliente As Cliente)

        If objCliente.IdCliente = 0 Then
            _dataAccessLayer.InsertarCliente(objCliente)
        Else
            '_dataAccessLayer.ActualizarCliente()
        End If
    End Sub

    Public Sub GuardarTransporte(objTransporte As Transporte)

        If objTransporte.IdTransporte = 0 Then
            '_dataAccessLayer.InsertarTransporte(objTransporte)
        Else
            '_dataAccessLayer.ActualizarTransporte(objTransporte)
        End If
    End Sub
End Class
