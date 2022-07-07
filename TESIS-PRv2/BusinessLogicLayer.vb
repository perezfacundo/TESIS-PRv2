Imports TESIS_PRv2.Cliente

Public Class BusinessLogicLayer
    Dim _dataAccessLayer As New DataAccessLayer()
    Public Sub BusinessLogicLayer()

    End Sub

    Public Sub GuardarCliente(objCliente As Cliente)

        If objCliente.IdCliente = 0 Then
            _dataAccessLayer.InsertarCliente(objCliente)
        Else
            '_dataAccessLayer.ActualizarCliente()
        End If
    End Sub

    Public Function GuardarTransporte(objTransporte As Transporte)

        If objTransporte.IdTransporte = 0 Then
            _dataAccessLayer.InsertarTransporte(objTransporte)
        Else
            '_dataAccessLayer.ActualizarTransporte(objTransporte)
        End If

        Return objTransporte

    End Function
End Class
