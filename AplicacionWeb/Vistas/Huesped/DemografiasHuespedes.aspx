<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DemografiasHuespedes.aspx.cs" Inherits="AplicacionWeb.Vistas.Huesped.DemografiasHuespedes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    &nbsp;</p>
<p>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="DEMOGRAFIAS HUESPEDES"></asp:Label>
</p>
<p>
    &nbsp;</p>
<table class="nav-justified">
    <tr>
        <td colspan="3">
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" Text="Huespedes por pais en rango de tiempo"></asp:Label>
            <br />
        </td>
    </tr>
    <tr>
        <td style="height: 20px">Fecha Inicio</td>
        <td style="height: 20px">Fecha Fin</td>
        <td style="height: 20px">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtFechaIniPais" runat="server" type="date"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtFechaFinPais" runat="server" type="date"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="btnPorPais" runat="server" OnClick="btnPorPais_Click" Text="Buscar" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="gvPorPais" runat="server" Width="100%">
            </asp:GridView>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Huesped por dinero gastado"></asp:Label>
            <br />
            <table class="nav-justified">
                <tr>
                    <td>Fecha Inicio</td>
                    <td>
            <asp:TextBox ID="txtInicioDinero" runat="server" type="date"></asp:TextBox>
                    </td>
                    <td>Tipo Documento</td>
                    <td>
                        <asp:DropDownList ID="cbRTDoc1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Value="0">No Domiciliado</asp:ListItem>
                            <asp:ListItem Value="1">DNI</asp:ListItem>
                            <asp:ListItem Value="4">Carnet Extranjeria</asp:ListItem>
                            <asp:ListItem Value="6">RUC</asp:ListItem>
                            <asp:ListItem Value="7">Pasaporte</asp:ListItem>
                            <asp:ListItem Value="A">P. Nacimiento</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Fecha Fin</td>
                    <td>
            <asp:TextBox ID="txtFinDinero" runat="server" type="date"></asp:TextBox>
                    </td>
                    <td>Numero Documento</td>
                    <td>
                        <asp:TextBox ID="txtNumDocDinero" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
            <asp:Label ID="lblError0" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblTotalGastado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Registrar Huesped"></asp:Label>
            <br />
            <br />
            <table class="nav-justified">
                <tr>
                    <td>Tipo Documento</td>
                    <td>
                        <asp:DropDownList ID="cbRTDoc" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Value="0">No Domiciliado</asp:ListItem>
                            <asp:ListItem Value="1">DNI</asp:ListItem>
                            <asp:ListItem Value="4">Carnet Extranjeria</asp:ListItem>
                            <asp:ListItem Value="6">RUC</asp:ListItem>
                            <asp:ListItem Value="7">Pasaporte</asp:ListItem>
                            <asp:ListItem Value="A">P. Nacimiento</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtREmail" runat="server" MaxLength="100" type="email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 20px">Numero Documento</td>
                    <td style="height: 20px">
                        <asp:TextBox ID="txtRNDoc" runat="server" MaxLength="15"></asp:TextBox>
                    </td>
                    <td style="height: 20px">Telefono</td>
                    <td style="height: 20px">
                        <asp:TextBox ID="txtRTel" runat="server" MaxLength="15" type="tel"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nombre</td>
                    <td>
                        <asp:TextBox ID="txtRNombre" runat="server" MaxLength="200" type="text"></asp:TextBox>
                    </td>
                    <td>Pais</td>
                    <td>
                        <asp:DropDownList ID="cboPais" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
            <asp:Label ID="lblError1" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblRegistrado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
