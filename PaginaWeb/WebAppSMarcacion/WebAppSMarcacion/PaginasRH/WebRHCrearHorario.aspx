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
                            <asp:Label ID="Label2" Text="Trabajador" runat="server" />
                            <div>
                                <asp:TextBox ID="TextBox1" Text="Ingrese nombre" runat="server" />
                                <asp:Button ID="Button1" Text="Buscar Trabajador" runat="server" />
                            </div>
                            <div>
                                <asp:Label ID="Label3" Text="Nombre: " runat="server" />
                            </div>
                            <div>
                                <asp:Label ID="Label4" Text="Area: " runat="server" />
                            </div>
                        </div>
                        <div>
                            <asp:Label ID="Label5" Text="Horario de trabajo" runat="server" />
                            <div>
                                <asp:Label ID="Label6" Text="Hora de trabajo: " runat="server" />
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem Text="text1" />
                                    <asp:ListItem Text="text2" />
                                </asp:DropDownList>
                            </div>
                           <div>
                               <asp:Label ID="Label7" Text="Dias" runat="server" />
                               <div>
                                   <div>
                                        <asp:Label ID="Label8" Text="Domingo" runat="server" />
                                       <asp:CheckBox ID="cbDomingo" runat="server" />
                                   </div>
                                   <div>
                                       <asp:Label ID="Label9" Text="Lunes" runat="server" />
                                       <asp:CheckBox ID="cbLunes" runat="server" />
                                   </div>
                                   <div>
                                       <asp:Label ID="Label10" Text="Martes" runat="server" />
                                       <asp:CheckBox ID="cbMartes" runat="server" />
                                   </div>
                                   <div>
                                       <asp:Label ID="Label11" Text="Miercoles" runat="server" />
                                       <asp:CheckBox ID="cbMiercoles" runat="server" />
                                   </div>
                                   <div>
                                       <asp:Label ID="Label12" Text="jueves" runat="server" />
                                       <asp:CheckBox ID="cbJueves" runat="server" />
                                   </div>
                                   <div>
                                       <asp:Label ID="Label13" Text="viernes" runat="server" />
                                       <asp:CheckBox ID="cbViernes" runat="server" />
                                   </div>
                                   <div>
                                       <asp:Label ID="Label14" Text="sabado" runat="server" />
                                       <asp:CheckBox ID="cbSabado" runat="server" />
                                   </div>
                               </div>
                               <div>
                                   <asp:Button ID="btnCrear" Text="Crear Horario" runat="server" />
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
