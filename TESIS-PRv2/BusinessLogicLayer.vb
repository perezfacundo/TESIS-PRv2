Imports TESIS_PRv2.Cliente

Public Class BusinessLogicLayer

    Private _dataAccessLayer As DataAccessLayer

    Public Sub BusinessLogicLayer()
        _dataAccessLayer = New DataAccessLayer()
    End Sub

    Public Sub GuardarCliente(Cli As Cliente)

        If Cli.IdCliente = 0 Then
            _dataAccessLayer.InsertarCliente(Cli)
        Else
            '_dataAccessLayer.ActualizarCliente()
        End If
    End Sub
End Class
