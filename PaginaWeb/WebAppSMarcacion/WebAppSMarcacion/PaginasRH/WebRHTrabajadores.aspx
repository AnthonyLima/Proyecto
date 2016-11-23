﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRHTrabajadores.aspx.cs" Inherits="WebAppSMarcacion.PaginasRH.WebRHTrabajadores" %>

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
                    <asp:MenuItem Text="Marcaciones"></asp:MenuItem>
                    <asp:MenuItem Text="Permisos"></asp:MenuItem>
                    <asp:MenuItem Text="horarios de trabajo"></asp:MenuItem>
                    <asp:MenuItem Text="Informacion"></asp:MenuItem>
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
                                    <asp:Label Text="Nombre: " runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="txtNombre" Text="" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="width:75%">
                        <div>
                            <asp:Label Text="Nombre: " runat="server" />
                        </div>
                        <div>
                            <asp:Label Text="Apellido Paterno: " runat="server" />
                        </div>
                        <div>
                            <asp:Label Text="Apellido Materno: " runat="server" />
                        </div>
                        <div>
                            <asp:Label Text="DNI: " runat="server" />
                        </div>
                        <div>
                            <asp:Label Text="Telefono: " runat="server" />
                        </div>
                        <div>
                            <asp:Label Text="Email: " runat="server" />
                        </div>
                        <div>
                            <asp:Label Text="Categoria: " runat="server" />
                        </div>
                        <div>
                            <asp:Label Text="Cargo: " runat="server" />
                        </div>
                        <div>
                            <asp:Label Text="Area: " runat="server" />
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
