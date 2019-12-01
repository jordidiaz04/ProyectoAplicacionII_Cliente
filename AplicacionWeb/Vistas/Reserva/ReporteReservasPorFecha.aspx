<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteReservasPorFecha.aspx.cs" Inherits="AplicacionWeb.Vistas.Reserva.ReporteReservasPorFecha" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col-lg-12 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="card-title">Ambientes disponibles por rango de fecha</div>
                        <hr>
                        <form>
                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-1">Departamento</label>
                                        <asp:DropDownList ID="cboDepartamento" class="form-control" runat="server" OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                    </div>

                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-2">Provincia</label>
                                        <asp:DropDownList ID="cboProvincia" class="form-control" runat="server" OnSelectedIndexChanged="cboProvincia_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                    </div>

                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Distrito</label>
                                        <asp:DropDownList ID="cboDistrito" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
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
                                <div class="col-sm-4 m-auto text-left" style="margin-bottom: 15px !important;">
                                    <asp:Button ID="btnBuscar" class="btn btn-primary shadow-primary px-5" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-12 table-responsive">
                                    <asp:GridView ID="gvReservas" runat="server" class="table table-sm table-hover table-bordered" AutoGenerateColumns="False">
                                        <Columns>
                                            <asp:BoundField DataField="Huesped.Nombre" HeaderText="Huesped">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="FechaInicio" HeaderText="Fecha Ingreso" DataFormatString="{0:dd/MM/yyyy}">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="FechaSalida" HeaderText="Fecha Salida" DataFormatString="{0:dd/MM/yyyy}">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <ItemStyle HorizontalAlign="Center" />
                                            </asp:BoundField>
                                            <asp:TemplateField HeaderText="Ambiente">
                                                <ItemTemplate>
                                                    <%# (Eval("Identificador").ToString().Contains("PISCINA") || Eval("Identificador").ToString().Contains("CONFERENCIA")) ? 
                                                            char.ToUpper(Eval("Identificador").ToString().ToLower()[0]) + Eval("Identificador").ToString().ToLower().Substring(1) : 
                                                            "Habitacion " + Eval("Identificador") %>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                                            <asp:BoundField DataField="Monto" HeaderText="Monto" DataFormatString="S/. {0:n}">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                <ItemStyle HorizontalAlign="Right" />
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
