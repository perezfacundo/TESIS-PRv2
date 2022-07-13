<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="agregarTransporte.aspx.vb" Inherits="TESIS_PRv2.agregarTransporte" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Patente:<asp:TextBox ID="txtPatente" runat="server"></asp:TextBox>
            <asp:Label ID="lblPatente" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Marca:<asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            <asp:Label ID="lblMarca" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Modelo:<asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            <asp:Label ID="lblModelo" runat="server" Text=""></asp:Label>
            <br />
            <br />
            Estado<asp:DropDownList ID="ddlEstado" runat="server" DataSourceID="SqlDataSource1" DataTextField="descripcion" DataValueField="idEstado"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TESIS-PRv2ConnectionString %>" SelectCommand="SELECT * FROM Estados WHERE idTipoRegistro = 4"></asp:SqlDataSource>
            <br />
            <br />
            Capacidad:<asp:TextBox ID="txtCapacidad" runat="server"></asp:TextBox>
            <asp:Label ID="lblCapacidad" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="cmdGuardar" runat="server" Text="Guardar" />
            <asp:Button ID="cmdCancelar" runat="server" Text="Cancelar" />
        </div>
    </form>
</body>
</html>
