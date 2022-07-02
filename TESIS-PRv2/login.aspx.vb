Public Class login
    Inherits System.Web.UI.Page

    Private _businessLogicLayer As BusinessLogicLayer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim _businessLogicLayer = New BusinessLogicLayer()
    End Sub


End Class