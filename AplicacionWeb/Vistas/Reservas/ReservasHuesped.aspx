<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservasHuesped.aspx.cs" Inherits="AplicacionWeb.Vistas.Reservas.ReservasHuesped" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <style type="text/css">
        .overlay  
        {
          position: fixed;
          z-index: 98;
          top: 0px;
          left: 0px;
          right: 0px;
          bottom: 0px;
            background-color: #aaa; 
            filter: alpha(opacity=80); 
            opacity: 0.8; 
        }
          td{

            font-family:Arial;
            font-weight:bold;
        }


        .overlayContent
        {
          z-index: 99;
          margin: 250px auto;
          width: 80px;
          height: 80px;
        }
        .overlayContent h2
        {
            font-size: 18px;
            font-weight: bold;
            color: #000;
        }
        .overlayContent img
        {
          width: 20px;
          height: 20px;
        }

        </style>


    <p>
    <br />
</p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#0066FF" Text="TEST DEL SERVICIO  DE RESERVAS (Reservas - Huesped)"></asp:Label>
</p>
    <table class="nav-justified" style="width: 91%">
        <tr>
            <td style="width: 205px; height: 40px">Seleccione Tipo Documento :</td>
            <td style="width: 237px; height: 40px">
                <asp:DropDownList ID="cboTipoDoc" runat="server">
                    <asp:ListItem Value="0">No Domiciliado</asp:ListItem>
                            <asp:ListItem Value="1">DNI</asp:ListItem>
                            <asp:ListItem Value="4">Carnet Extranjeria</asp:ListItem>
                            <asp:ListItem Value="6">RUC</asp:ListItem>
                            <asp:ListItem Value="7">Pasaporte</asp:ListItem>
                            <asp:ListItem Value="A">P. Nacimiento</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="height: 40px"></td>
        </tr>
        <tr>
            <td style="width: 205px; height: 40px">Ingrese el N° de Doc. :</td>
            <td style="width: 237px; height: 40px">
                <asp:TextBox ID="txtNumDoc" runat="server" Height="21px" Width="188px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="White" ControlToValidate="txtNumDoc" ErrorMessage="Obligatorio" ForeColor="Red" Font-Bold="False"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 40px"></td>
        </tr>
        <tr>
            <td style="width: 205px; height: 40px">Ingrese fecha de inicio :</td>
            <td style="width: 237px; height: 40px">
                <asp:TextBox ID="txtFecIni" runat="server" Height="21px" Width="188px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFecIni" ErrorMessage="Ingrese fecha de inicio" ForeColor="Red" Font-Bold="False"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 40px"></td>
        </tr>
        <tr>
            <td style="width: 205px; height: 40px">Ingrese fecha de fin:</td>
            <td style="width: 237px; height: 40px">
                <asp:TextBox ID="txtFecFin" runat="server" Height="21px" Width="188px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFecFin" ErrorMessage="Ingrese fecha de fin" ForeColor="Red" Font-Bold="False"></asp:RequiredFieldValidator>
            </td>
            <td style="height: 40px">
                <asp:Button ID="btnConsultar" runat="server" Height="30px" Text="Consultar" Width="145px" Font-Bold="True" ForeColor="#009900" OnClick="btnConsultar_Click" />
            </td>
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
                <asp:Label ID="lblMensajePrincipal" runat="server" Text="No existen datos para la búsqueda" Visible="False"></asp:Label>
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
</asp:Content>
