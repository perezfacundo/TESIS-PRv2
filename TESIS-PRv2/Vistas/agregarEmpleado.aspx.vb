Public Class agregarEmpleado
    Inherits System.Web.UI.Page

    Dim _businessLogicLayer As New BusinessLogicLayer()
    Dim objEmpleado As New Empleado()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        GuardarEmpleado()
    End Sub

    Private Sub GuardarEmpleado()
        objEmpleado.DniEmpleado = txtDNI.Text
        objEmpleado.Apellidos = txtApellidos.Text
        objEmpleado.Nombres = txtNombres.Text
        objEmpleado.FechaNac = txtFechaNac.Text
        objEmpleado.PorcComision = txtPorcComision.Text
        objEmpleado.DniEmpleado = txtDNI.Text
        objEmpleado.DniEmpleado = txtDNI.Text

        _businessLogicLayer.GuardarEmpleado(objEmpleado)
    End Sub
End Class