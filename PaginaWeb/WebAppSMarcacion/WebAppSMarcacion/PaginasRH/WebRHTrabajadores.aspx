<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRHTrabajadores.aspx.cs" Inherits="WebAppSMarcacion.PaginasRH.WebRHTrabajadores" %>

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
                            <asp:Label ID="Label1" Text="Nombre: " runat="server" />
                            <asp:TextBox ID="TextBox1" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="Label2" Text="Apellido Paterno: " runat="server" />
                            <asp:TextBox ID="txtApellidoPaterno" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="Label3" Text="Apellido Materno: " runat="server" />
                            <asp:TextBox ID="txtApellidoMaterno" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="Label4" Text="DNI: " runat="server" />
                            <asp:TextBox ID="txtDNI" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="Label5" Text="Telefono: " runat="server" />
                            <asp:TextBox ID="txtTelefono" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="Label6" Text="Email: " runat="server" />
                            <asp:TextBox ID="txtEmail" runat="server" />
                        </div>
                        <div>
                            <asp:Label ID="Label7" Text="Categoria: " runat="server" />
                            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                        </div>
                        <div>
                            <asp:Label ID="Label8" Text="Cargo: " runat="server" />
                            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                        </div>
                        <div>
                            <asp:Label ID="Label9" Text="Area: " runat="server" />
                            <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
                        </div>
                        <div>
                            <asp:Button ID="Button1" Text="Crear Trabajador" runat="server" />
                        </div>
                        <div>
                            <asp:GridView ID="dtLista" AutoGenerateColumns="false" runat="server">
                                <Columns>
                                    <asp:BoundField DataField="CodigoTrabajador" HeaderText="Codigo" />
                                    <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" />
                                    <asp:BoundField DataField="NombreCategoria" HeaderText="Categoria" />
                                    <asp:BoundField DataField="NombreArea" HeaderText="Area" />
                                    <asp:BoundField DataField="NombreCargo" HeaderText="Cargo" />
                                </Columns>
                            </asp:GridView>
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
