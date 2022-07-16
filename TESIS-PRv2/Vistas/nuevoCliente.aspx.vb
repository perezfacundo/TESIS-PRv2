Public Class agregarCliente
    Inherits System.Web.UI.Page

    Private _businessLogicLayer As New BusinessLogicLayer()
    Dim objCliente As New Cliente()
    Dim filasAfectadas As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click

        Try
            objCliente.DniCliente = txtDniCliente.Text
            objCliente.Apellidos = txtApellidos.Text
            objCliente.Nombres = txtNombres.Text
            objCliente.FechaNac = txtFechaNac.Text
            objCliente.Telefono = txtTelefono.Text
            objCliente.Domicilio = txtDomicilio.Text
            objCliente.IdEstado = ddlEstado.SelectedValue
            objCliente.Clave = txtClave1.Text
            objCliente.Correo = txtCorreo.Text
            objCliente.IdProvincia = ddlProvincia.Text
            objCliente.IdLocalidad = ddlLocalidad.Text
            objCliente.IdTipoRegistro = 1
        Catch ex As Exception
            lblResultado.Text = ""
        End Try

        filasAfectadas = _businessLogicLayer.GuardarCliente(objCliente)

        If filasAfectadas = 1 Then
            lblResultado.ForeColor = Drawing.Color.Green
            lblResultado.Text = "El cliente se agregó correctamente !"
        End If
        If filasAfectadas <> 1 Then
            lblResultado.ForeColor = Drawing.Color.Red
            lblResultado.Text = "Ocurrió un error al insertar el registro"
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        txtDniCliente.Text = String.Empty
        txtApellidos.Text = String.Empty
        txtNombres.Text = String.Empty
        txtFechaNac.Text = String.Empty
        txtTelefono.Text = String.Empty
        txtDomicilio.Text = String.Empty
        ddlEstado.SelectedIndex = 0
        txtClave1.Text = String.Empty
        txtClave2.Text = String.Empty
        txtCorreo.Text = String.Empty
        ddlProvincia.SelectedIndex = 0
        ddlLocalidad.SelectedIndex = 0
        lblResultado.Text = String.Empty
        lblResultado.ForeColor = Drawing.Color.Black
    End Sub

End Class