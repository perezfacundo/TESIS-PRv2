Public Class CERegistros
    Inherits System.Web.UI.Page

    Private _businessLogicLayer As New BusinessLogicLayer()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarRegistros()
    End Sub


    Private Sub ListarRegistros()
        Select Case ddlTiposRegistro.SelectedIndex
            Case 0 'clientes
                Dim clientes As List(Of Cliente) = _businessLogicLayer.BuscarClientes()
            Case 1 'Empleados
                Dim empleados As List(Of Empleado) = _businessLogicLayer.BuscarEmpleados()
            Case 2 'Solicitudes
                Dim solicitudes As List(Of Solicitud) = _businessLogicLayer.BuscarSolicitudes()
            Case 3 'Transportes
                Dim transportes As List(Of Transporte) = _businessLogicLayer.BuscarTransportes()
            Case 4 'Provincias
                Dim provincias As List(Of Provincia) = _businessLogicLayer.BuscarProvincias()
            Case 5 'Estados
                Dim estados As List(Of Estado) = _businessLogicLayer.BuscarEstados()
            Case 6 'Localidades
                Dim localidades As List(Of Localidad) = _businessLogicLayer.BuscarLocalidades()
        End Select

        'CREAR METODOS Y CLASE QUE ESTAN EN ROJO (VIERNES)

        'mediante innerHTML mostrar la lista por tabla
    End Sub

    Private Sub ddlTiposRegistro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTiposRegistro.SelectedIndexChanged
        Debug.WriteLine(ddlTiposRegistro.SelectedItem.ToString & " " & ddlTiposRegistro.SelectedIndex)
    End Sub
End Class