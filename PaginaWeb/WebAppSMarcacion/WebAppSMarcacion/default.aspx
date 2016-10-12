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
            
        </div>
        <div id="OpcionesPagina">

        </div>
        <div id="ContenidoPagina">
            <%--<iframe src="PaginaContenido/WebLogin.aspx"></iframe>--%>
            <asp:PlaceHolder ID="PagContent" runat="server" />
        </div>
        <div id="PiePagina">

        </div>
    </form>
</body>
</html>
