<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebInfoMiCuenta.aspx.cs" Inherits="WebAppSMarcacion.PaginasAdmin.WebInfoMiCuenta" %>

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
            <table style="width:908px">
                <tr style="width:auto">
                    <td style="width:25%">
                        <table id=" informacion">
                            <tr>
                                <td>
                                    <asp:Label ID="Label1" Text="Nombre: " runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="txtNombre" Text="" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width:75%">
                        <div>
                            <asp:Label ID="lbCodigoUsuarios" Text="Codigo de Usuario: " runat="server"></asp:Label>
                        </div>
                        <div>
                            <asp:Label ID="lbNombre" Text="Nombre: " runat="server"></asp:Label>
                        </div>
                        <div>
                            <asp:Label ID="lbContrasena" text="Contraseña: " runat="server"></asp:Label>
                        </div>
                        <div>
                            <asp:Button ID="btnCambiarContrasena" Text="Cambiar Contraseña" runat="server" />
                        </div>
                    </td>
                </tr>
            </table>
        </div>
        <div id="PiePagina">
        </div>
    </form>
</body>
</html>
