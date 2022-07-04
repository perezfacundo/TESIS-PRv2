﻿Public Class agregarCliente
    Inherits System.Web.UI.Page

    Dim _businessLogicLayer As BusinessLogicLayer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _businessLogicLayer = New BusinessLogicLayer
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim Cli As Cliente = New Cliente()

        Cli.DniCliente = txtDniCliente.Text
        Cli.Apellidos = txtApellidos.Text
        Cli.Nombres = txtNombres.Text
        Cli.FechaNac = txtFechaNac.Text
        Cli.Telefono = txtTelefono.Text
        Cli.Domicilio = txtDomicilio.Text
        Cli.IdEstado = 0
        Cli.Clave = txtClave.Text
        Cli.Correo = txtCorreo.Text
        Cli.IdProvincia = txtProvincia.Text
        Cli.IdLocalidad = txtLocalidad.Text

        _businessLogicLayer.GuardarCliente(Cli)
    End Sub
End Class