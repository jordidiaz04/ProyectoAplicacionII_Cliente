<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteHuespedesPorPais.aspx.cs" Inherits="AplicacionWeb.Vistas.Huesped.ReporteHuespedesPorPais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col-lg-12 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="card-title">Cantidad de huespedes según país</div>
                        <hr>
                        <form>
                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Fecha Ingreso</label>
                                        <asp:TextBox ID="txtFecIni" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Fecha Salida</label>
                                        <asp:TextBox ID="txtFecFin" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-sm-4 m-auto text-left" style="margin-bottom: 15px !important;">
                                    <asp:Button ID="btnBuscar" class="btn btn-primary shadow-primary px-5" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-12 table-responsive">
                                    <asp:GridView ID="gvHuespedes" runat="server" class="table table-sm table-hover table-bordered" AutoGenerateColumns="False">
                                        <Columns>
                                            <asp:BoundField DataField="Pais" HeaderText="Pais">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Cantidad" HeaderText="Cantidad">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:BoundField>
                                        </Columns>
                                        <FooterStyle BackColor="White" ForeColor="#000066" />
                                        <HeaderStyle CssClass="thead-primary text-center" />
                                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                        <RowStyle ForeColor="#000066" />
                                        <SelectedRowStyle CssClass="table-hover" />
                                    </asp:GridView>
                                    <asp:Label ID="lblMensaje" runat="server" Text="No hay ambientes disponibles." Visible="False"></asp:Label>
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
