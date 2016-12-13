<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRHCrearHoras.aspx.cs" Inherits="WebAppSMarcacion.PaginasRH.WebRHCrearHoras" %>

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
                    <asp:MenuItem Text="Mantenimiento Trabajadores"></asp:MenuItem>
                    <asp:MenuItem Text="Crear Horas de trabajo"></asp:MenuItem>
                    <asp:MenuItem Text="Creacion Horario de trabajo"></asp:MenuItem>
                    <asp:MenuItem Text="Visualizar Marcaciones"></asp:MenuItem>
                    <asp:MenuItem Text="Creacion Permisos"></asp:MenuItem>
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
                            <asp:Label ID="Label1" Text="Hora Entrada: " runat="server" />
                            <asp:Timer ID="Timer1" runat="server"></asp:Timer>
                        </div>
                        <div>
                            <asp:Label ID="Label2" Text="Hora Salida" runat="server" />
                            <asp:Timer ID="Timer2" runat="server"></asp:Timer>
                        </div>
                        <%--<div>
                            <asp:Label Text="Dia" runat="server" />
                            <asp:DropDownList ID="ddlDia" runat="server">
                                <asp:ListItem Text="Domingo" />
                                <asp:ListItem Text="Lunes" />
                                <asp:ListItem Text="Martes" />
                                <asp:ListItem Text="Miercoles" />
                                <asp:ListItem Text="Jueves" />
                                <asp:ListItem Text="Viernes" />
                                <asp:ListItem Text="Sabado" />
                            </asp:DropDownList>
                        </div>--%>
                        <div>
                            <asp:Button ID="Button1" Text="Crear Hora de Trabajo" runat="server" />
                        </div>
                        <div>
                            <asp:GridView ID="dtLista" runat="server"></asp:GridView>
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
