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
        objEmpleado.IdEstado = ddlEstado.SelectedValue
        objEmpleado.Clave = txtClave.Text
        objEmpleado.Correo = txtCorreo.Text
        objEmpleado.IdTipoRegistro = 2

        _businessLogicLayer.GuardarEmpleado(objEmpleado)
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtDNI.Text = String.Empty
        txtApellidos.Text = String.Empty
        txtNombres.Text = String.Empty
        txtFechaNac.Text = String.Empty
        txtPorcComision.Text = String.Empty
        ddlEstado.SelectedIndex = 0
        txtClave.Text = String.Empty
        txtCorreo.Text = String.Empty

    End Sub
End Class