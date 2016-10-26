<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaUsuarios.aspx.cs" Inherits="WebAppSMarcacion.Paginas.PaginaUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Estilo/EstiloDefaultPag.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="CabeceraPagina">
            
        </div>
        <div id="OpcionesPagina">
            <asp:Menu runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem Text="dato1"></asp:MenuItem>
                    <asp:MenuItem Text="dato2"></asp:MenuItem>
                    <asp:MenuItem Text="dato3"></asp:MenuItem>
                    <asp:MenuItem Text="dato4"></asp:MenuItem>
                </Items>
            </asp:Menu>    
        </div>
        <div id="ContenidoPagina">
            <%--<iframe src="PaginaContenido/WebLogin.aspx"></iframe>--%>
            <%--<asp:PlaceHolder ID="PagContent" runat="server" />--%>
            <asp:Panel ID="PanelContent" runat="server"></asp:Panel>
        </div>
        <div id="PiePagina">

        </div>
    </div>
    </form>
</body>
</html>
