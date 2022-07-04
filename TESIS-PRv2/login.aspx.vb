Public Class login
    Inherits System.Web.UI.Page

    Private _businessLogicLayer As BusinessLogicLayer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _businessLogicLayer = New BusinessLogicLayer()
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click

        Dim cliente = New Cliente()
        cliente.Correo = txtCorreo.Text
        Cliente.Clave = txtClave.Text

        '_businessLogicLayer.BuscarCliente(cliente)
    End Sub
End Class