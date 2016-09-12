<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormSUsuario.aspx.cs" Inherits="WebAppSMarcacion.WebFormSUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:Label Text="Nombre: " runat="server" />
            
            <asp:TextBox ID="txtNombre" runat="server" />
        </div>
        <div>
            <asp:Label Text="Clave: " runat="server" />

            <asp:TextBox ID="txtClave" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnBuscarUser" Text="buscar" runat="server" OnClick="btnBuscarUser_Click" />
        </div>
        <div>
            <asp:Label ID="lblRespuesta" Text="" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
