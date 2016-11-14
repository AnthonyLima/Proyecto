<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebAppSMarcacion._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Estilo/EstiloDefaultPag.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="CabeceraPagina">
            <asp:Image  runat="server" />
        </div>
        <div id="OpcionesPagina">
            <asp:Menu runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem NavigateUrl="~/Paginas/PaginaUsuarios.aspx" Text="empleados"></asp:MenuItem>
                    <asp:MenuItem Text="Recursos Humanos"></asp:MenuItem>
                    <asp:MenuItem Text="Administracion"></asp:MenuItem>
                    <asp:MenuItem Text="Informacion"></asp:MenuItem>
                </Items>
            </asp:Menu> 
        </div>
        <div id="ContenidoPagina">
            <table style="width:908px">
                <tr style="width:auto">
                    <td style="width:25%">
                        <table>
                                <tr>
                                    <td>
                                        <asp:Label Text="Usuario: " runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label Text="Clave: " runat="server" />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnLogin" Text="ingresar" runat="server" OnClick="btnLogin_Click" />
                            </tr>
                        </table>
                    </td>
                    <td style="width:75%">
                        <%--<asp:PlaceHolder ID="PanelContent" runat="server" />--%>
                    </td>
                </tr>
            </table>
        </div>
        <div id="PiePagina">

        </div>
    </form>
</body>
</html>
