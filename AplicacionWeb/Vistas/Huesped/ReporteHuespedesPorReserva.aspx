<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteHuespedesPorReserva.aspx.cs" Inherits="AplicacionWeb.Vistas.Huesped.ReporteHuespedesPorReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col-lg-12 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="card-title">Reservas hechas por un huesped</div>
                        <hr>
                        <form>
                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Fecha Ingreso</label>
                                        <asp:TextBox ID="txtFecIng" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Fecha Salida</label>
                                        <asp:TextBox ID="txtFecSal" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Tipo de Documento</label>
                                        <asp:DropDownList ID="cboTipoDoc" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Número de Documento</label>
                                        <asp:TextBox ID="txtNumDoc" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-sm-4 m-auto text-left" style="margin-bottom: 15px !important;">
                                    <asp:Button ID="btnBuscar" class="btn btn-primary shadow-primary px-5" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                                </div>
                            </div>
                            <hr />
                            <div class="card-title" style="margin-bottom: 0px !important;">Datos del huesped</div>
                            <asp:Panel ID="panelDatos" runat="server">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="row">
                                            <asp:Label ID="Label1" class="col-sm-3 col-form-label" runat="server" Text="Nombre:"></asp:Label>
                                            <asp:Label ID="lblNombre" class="col-sm-9 col-form-label" runat="server" Text=""></asp:Label>
                                        </div>
                                        <div class="row">
                                            <asp:Label ID="Label2" class="col-sm-3 col-form-label" runat="server" Text="Email:"></asp:Label>
                                            <asp:Label ID="lblEmail" class="col-sm-9 col-form-label" runat="server" Text=""></asp:Label>
                                        </div>
                                        <div class="row">
                                            <asp:Label ID="Label3" class="col-sm-3 col-form-label" runat="server" Text="Pais:"></asp:Label>
                                            <asp:Label ID="lblPais" class="col-sm-9 col-form-label" runat="server" Text=""></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                            <div class="row">
                                <div class="col-12 table-responsive">
                                    <asp:GridView ID="gvReservas" runat="server" class="table table-sm table-hover table-bordered" AutoGenerateColumns="False">
                                        <Columns>
                                            <asp:BoundField DataField="Distrito" HeaderText="Distrito" />
                                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                                            <asp:BoundField DataField="FechaInicio" HeaderText="Fec. Ingreso">
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="FechaSalida" HeaderText="Fec. Salida">
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="TipoPago" HeaderText="Forma Pago" />
                                            <asp:BoundField DataField="Monto" HeaderText="Monto" DataFormatString="S/. {0:n}">
                                                <ItemStyle HorizontalAlign="Right" />
                                            </asp:BoundField>
                                        </Columns>
                                        <FooterStyle BackColor="White" ForeColor="#000066" />
                                        <HeaderStyle CssClass="thead-primary text-center" />
                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                        <RowStyle ForeColor="#000066" />
                                        <SelectedRowStyle CssClass="table-hover" />
                                    </asp:GridView>
                                    <asp:Label ID="lblMensaje" runat="server" Text="Este huesped no ha realizado reservas" Visible="False"></asp:Label>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-12">
                                    <asp:Label ID="lblMensajeError" runat="server" CssClass="text-danger"></asp:Label>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
