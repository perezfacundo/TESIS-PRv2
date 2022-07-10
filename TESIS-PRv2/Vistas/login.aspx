<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="TESIS_PRv2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Iniciar sesion</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="cmdIngresar" runat="server" Text="Button" />
            <asp:Button ID="cmdCancelar" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
