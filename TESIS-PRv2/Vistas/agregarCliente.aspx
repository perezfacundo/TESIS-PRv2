<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="agregarCliente.aspx.vb" Inherits="TESIS_PRv2.agregarCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            DNI<asp:TextBox ID="txtDniCliente" runat="server"></asp:TextBox>
            <br />
            <br />
            Apellidos<asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombres<asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
            <br />
            <br />
            Fecha de nacimiento<asp:TextBox ID="txtFechaNac" runat="server"></asp:TextBox>
            <br />
            <br />
            Telefono<asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            <br />
            Domicilio<asp:TextBox ID="txtDomicilio" runat="server"></asp:TextBox>
            <br />
            <br />
            Clave<asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
            <br />
            <br />
            Correo<asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
            <br />

            Provincia<asp:DropDownList ID="ddlProvincia" runat="server"  DataTextField="Provincia" DataValueField="idProvincia" AutoPostBack="True" DataSourceID="SqlDataSource1"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TESIS-PRv2ConnectionString %>" SelectCommand="SELECT [idProvincia], [Provincia] FROM [Provincias]"></asp:SqlDataSource>
            <br />
            <br />

            Localidad<asp:DropDownList ID="ddlLocalidad" runat="server" DataTextField="Localidad" DataValueField="idLocalidad" AutoPostBack="True" DataSourceID="SqlDataSource2"></asp:DropDownList>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TESIS-PRv2ConnectionString %>" SelectCommand="SELECT idLocalidad, Localidad FROM Localidades WHERE idProvincia = @idProvincia">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlProvincia" Name="idProvincia" PropertyName="SelectedValue" />
                </SelectParameters>
            </asp:SqlDataSource>

            <br />
            <br />
            <asp:Button ID="cmdGuardar" runat="server" Text="Guardar" />
            <asp:Button ID="cmdCancelar" runat="server" Text="Cancelar" />
        </div>
    </form>
</body>
</html>
