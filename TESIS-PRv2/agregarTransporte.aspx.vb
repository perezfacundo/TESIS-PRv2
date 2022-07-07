Public Class agregarTransporte
    Inherits System.Web.UI.Page

    Dim _businessLogicLayer As New BusinessLogicLayer()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        Dim objTransporte As Transporte = New Transporte()
        objTransporte.Patente = txtPatente.Text
        objTransporte.Marca = txtMarca.Text
        objTransporte.Modelo = txtModelo.Text
        objTransporte.IdEstado = 15
        objTransporte.Capacidad = txtCapacidad.Text
        objTransporte.IdTipoRegistro = 7

        _businessLogicLayer.GuardarTransporte(objTransporte)

    End Sub
End Class