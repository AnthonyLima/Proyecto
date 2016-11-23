<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRHCrearHorario.aspx.cs" Inherits="WebAppSMarcacion.PaginasRH.WebRHCrearHorario" %>

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
                            <asp:Label Text="Trabajador" runat="server" />
                            <div>
                                <asp:TextBox Text="Ingrese nombre" runat="server" />
                                <asp:Button Text="Buscar Trabajador" runat="server" />
                            </div>
                            <div>
                                <asp:Label Text="Nombre: " runat="server" />
                            </div>
                            <div>
                                <asp:Label Text="Area: " runat="server" />
                            </div>
                        </div>
                        <div>
                            <asp:Label Text="Horario de trabajo" runat="server" />
                            <div>
                                <asp:Label Text="Hora de trabajo: " runat="server" />
                                <asp:DropDownList runat="server">
                                    <asp:ListItem Text="text1" />
                                    <asp:ListItem Text="text2" />
                                </asp:DropDownList>
                            </div>
                           <div>
                               <asp:Label Text="Dias" runat="server" />
                               <div>
                                   <div>
                                        <asp:Label Text="Domingo" runat="server" />
                                       <asp:CheckBox runat="server" />
                                   </div>
                                   <asp:Label Text="Lunes" runat="server" />
                                   <asp:Label Text="Martes" runat="server" />
                                   <asp:Label Text="Miercoles" runat="server" />
                               </div>
                               <div>

                               </div>
                           </div>
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
