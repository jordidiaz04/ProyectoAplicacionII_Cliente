<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarReserva.aspx.cs" Inherits="AplicacionWeb.Vistas.Reserva.RegistrarReserva" %>
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
                            </div>
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
                                        <asp:DropDownList ID="cboDistrito" class="form-control" runat="server" OnSelectedIndexChanged="cboDistrito_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Tipo Ambiente</label>
                                        <asp:DropDownList ID="cboTipoAmbiente" class="form-control" runat="server" OnSelectedIndexChanged="cboTipoAmbiente_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label for="input-3">Ambiente</label>
                                        <asp:DropDownList ID="cboAmbiente" class="form-control" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-sm-4 m-auto text-left" style="margin-bottom: 15px !important;">
                                    <asp:Button ID="btnAgregar" class="btn btn-primary shadow-primary px-3" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                                    <asp:Button ID="btnRegistrar" class="btn btn-primary shadow-primary px-3" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-12 table-responsive">
                                    <asp:GridView ID="gvAmbientes" runat="server" class="table table-sm table-hover table-bordered" AutoGenerateColumns="False">
                                        <Columns>
                                            <asp:BoundField DataField="Distrito" HeaderText="Distrito">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Direccion" HeaderText="Direccion">
                                            </asp:BoundField>
                                            <asp:BoundField DataField="Identificador" HeaderText="Ambiente">
                                                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:BoundField>
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
