<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteAmbientePorFecha.aspx.cs" Inherits="AplicacionWeb.Vistas.Ambiente.ReporteAmbientePorFecha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table class="nav-justified" style="margin-top: 20px">
        <tr>
            <td style="width: 232px">Seleccione un Departamento:</td>
            <td class="modal-sm" style="width: 232px">Seleccione una Provincia:</td>
            <td style="width: 232px">Seleccione un Distrito:</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 232px">
                <asp:DropDownList ID="cboDepartamento" runat="server" Width="200px" OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="modal-sm" style="width: 232px">
                <asp:DropDownList ID="cboProvincia" runat="server" Width="200px" OnSelectedIndexChanged="cboProvincia_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td style="width: 232px">
                <asp:DropDownList ID="cboDistrito" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 232px">&nbsp;</td>
            <td class="modal-sm" style="width: 232px">&nbsp;</td>
            <td style="width: 232px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 232px">Fecha de Ingreso:</td>
            <td class="modal-sm" style="width: 232px">Fecha de Salida:</td>
            <td style="width: 232px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 232px">
                <asp:TextBox ID="txtFecIng" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td class="modal-sm" style="width: 232px">
                <asp:TextBox ID="txtFecSal" runat="server" Width="200px"></asp:TextBox>
            </td>
            <td style="width: 232px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 232px">&nbsp;</td>
            <td class="modal-sm" style="width: 232px">&nbsp;</td>
            <td style="width: 232px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="gvAmbientes" runat="server" Width="664px" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                    <Columns>
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion">
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Piso" HeaderText="Piso">
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Identificador" HeaderText="Numero">
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Aforo" HeaderText="Capacidad">
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Precio" HeaderText="Precio">
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Right" />
                        </asp:BoundField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:Label ID="lblMensaje" runat="server" Text="No hay ambientes disponibles." Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <br />
                <asp:Label ID="lblMensajeError" runat="server" CssClass="text-danger"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
