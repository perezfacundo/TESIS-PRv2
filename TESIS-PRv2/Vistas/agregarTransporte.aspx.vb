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
        objTransporte.IdEstado = 15
        objTransporte.Capacidad = txtCapacidad.Text
        objTransporte.IdTipoRegistro = 7

        _businessLogicLayer.GuardarTransporte(objTransporte)
    End Sub
End Class