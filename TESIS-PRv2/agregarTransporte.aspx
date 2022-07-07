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
            <br />
            <br />
            Marca:<asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            <br />
            <br />
            Modelo:<asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
            <br />
            <br />
            idEstado:<asp:TextBox ID="txtIdEstado" runat="server"></asp:TextBox>
            <br />
            <br />
            Capacidad:<asp:TextBox ID="txtCapacidad" runat="server"></asp:TextBox>
            <br />
            <br />
            idTipo Registro:<asp:TextBox ID="txtTipoRegistro" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="cmdGuardar" runat="server" Text="Guardar" />
            <asp:Button ID="cmdCancelar" runat="server" Text="Cancelar" />
        </div>
    </form>
</body>
</html>
