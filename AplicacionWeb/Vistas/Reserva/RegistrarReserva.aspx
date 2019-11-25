﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarReserva.aspx.cs" Inherits="AplicacionWeb.Vistas.Reservas.RegistrarReserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#0066FF" Text="TEST DEL SERVICIO  DE RESERVAS (Registrar Reserva)"></asp:Label>
</p>
    <table class="nav-justified" style="width: 91%">
        <tr>
            <td style="width: 205px; height: 40px">Fecha de entrada :</td>
            <td style="width: 237px; height: 40px">
                <asp:TextBox ID="txtFechaEntrada" runat="server" Height="21px" Width="188px"></asp:TextBox>
            </td>
            <td style="height: 40px"></td>
        </tr>
        <tr>
            <td style="width: 205px; height: 40px">Fecha de salida :</td>
            <td style="width: 237px; height: 40px">
                <asp:TextBox ID="txtFechaSalida" runat="server" Height="21px" Width="188px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="White" ControlToValidate="txtNumDoc" ErrorMessage="Obligatorio" ForeColor="Red" Font-Bold="False"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 40px"></td>
        </tr>
        <tr>
            <td style="width: 205px; height: 40px">Ambiente :</td>
            <td style="width: 237px; height: 40px">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
            <td style="height: 40px"></td>
        </tr>
        <tr>
            <td style="width: 205px; height: 40px">Precio :</td>
            <td style="width: 237px; height: 40px">
                <asp:TextBox ID="txtFecFin" runat="server" Height="21px" Width="188px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFecFin" ErrorMessage="Ingrese fecha de fin" ForeColor="Red" Font-Bold="False"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 40px">
                <asp:Button ID="btnConsultar" runat="server" Height="30px" Text="Consultar" Width="145px" Font-Bold="True" ForeColor="#009900" OnClick="btnConsultar_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 205px; height: 40px">Huesped :</td>
            <td style="width: 237px; height: 40px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td style="height: 40px">
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:GridView ID="grvContenido" runat="server" Width="1017px" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                        <asp:BoundField DataField="Distrito" HeaderText="Distrito" />
                        <asp:BoundField DataField="Dni" HeaderText="Dni" />
                        <asp:BoundField DataField="FechaInicio" HeaderText="Fecha Inicio" />
                        <asp:BoundField DataField="FechaSalida" HeaderText="Fecha Salida" />
                        <asp:BoundField DataField="Monto" HeaderText="Monto (S/.)" />
                        <asp:BoundField DataField="Piso" HeaderText="Piso" />
                        <asp:BoundField DataField="TipoPago" HeaderText="Tipo Pago" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 205px">&nbsp;</td>
            <td style="width: 237px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
<p>
    <asp:Label ID="lblMensaje" runat="server" Font-Bold="False" ForeColor="#FF3300"></asp:Label>
</p>
<p>
    <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Size="15pt">&lt;- Volver atras</asp:HyperLink>
</p>
    <p>
    </p>
</asp:Content>