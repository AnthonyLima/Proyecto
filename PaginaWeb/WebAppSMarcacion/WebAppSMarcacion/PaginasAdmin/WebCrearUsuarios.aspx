<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCrearUsuarios.aspx.cs" Inherits="WebAppSMarcacion.PaginasAdmin.WebCrearUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Estilo/EstiloDefaultPag.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     <div id="CabeceraPagina">
            <asp:Image ID="Image1" ImageAlign="Middle" ImageUrl="Imagen/imagesPrincipalTrabajo.jpg" runat="server" />
        </div>
        <div id="OpcionesPagina">
            <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem NavigateUrl="~/PaginasAdmin/WebCrearUsuarios.aspx" Text="Usuarios"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/PaginasAdmin/WebMantGrupos.aspx" Text="Grupos"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/PaginasAdmin/WebPermisos.aspx" Text="Permisos"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/PaginasAdmin/WebInfoMiCuenta.aspx" Text="Informacion"></asp:MenuItem>
                </Items>
            </asp:Menu> 
        </div>
        <div id="ContenidoPagina">
            <div>
                <asp:Label Text="Nombre:  " runat="server" />
                <asp:TextBox ID="txtNombre" Text="" runat="server" />
            </div>
            <div>
                <asp:Button ID="btnCrearUsuario" Text="Crear" runat="server" OnClick="btnCrearUsuario_Click" />
                <asp:Label ID="lbRespond" Text="" runat="server" />
            </div>
        </div>
        <div id="PiePagina">

        </div>
    </form>
</body>
</html>
