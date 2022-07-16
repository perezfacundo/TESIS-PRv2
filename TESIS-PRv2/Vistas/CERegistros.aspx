<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CERegistros.aspx.vb" Inherits="TESIS_PRv2.CERegistros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ¿ Qué desea consultar ?
            <asp:DropDownList ID="ddlTiposRegistro" runat="server" DataSourceID="SqlDataSource1" DataTextField="descripcion" DataValueField="idTipoRegistro">
            </asp:DropDownList>
            <asp:Button ID="cmdConsultar" runat="server" Text="Consultar" Width="85px" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TESIS-PRv2ConnectionString %>" SelectCommand="SELECT [idTipoRegistro], [descripcion] FROM [TiposDeRegistro]"></asp:SqlDataSource>
        </div>

        <div id="html" runat="server"></div>

    </form>
</body>
</html>
