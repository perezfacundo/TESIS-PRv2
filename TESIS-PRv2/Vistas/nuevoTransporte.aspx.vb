Public Class agregarTransporte
    Inherits System.Web.UI.Page

    Private _businessLogicLayer As New BusinessLogicLayer()
    Dim objTransporte As New Transporte()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        GuardarTransporte()
    End Sub

    Private Sub GuardarTransporte()

        objTransporte.Patente = txtPatente.Text
        objTransporte.Marca = txtMarca.Text
        objTransporte.Modelo = txtModelo.Text
        objTransporte.IdEstado = ddlEstado.SelectedValue
        objTransporte.Capacidad = txtCapacidad.Text
        objTransporte.IdTipoRegistro = 7

        Try
            _businessLogicLayer.GuardarTransporte(objTransporte)
            Debug.WriteLine("El registro se inserto correctamente")
        Catch ex As Exception
            Debug.WriteLine("Ocurrio un problema al insertar el registro")
        End Try

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtPatente.Text = String.Empty
        txtMarca.Text = String.Empty
        txtModelo.Text = String.Empty
        ddlEstado.SelectedIndex = 0
        txtCapacidad.Text = String.Empty
    End Sub
End Class