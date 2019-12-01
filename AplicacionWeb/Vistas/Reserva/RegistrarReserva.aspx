<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarReserva.aspx.cs" Inherits="AplicacionWeb.Vistas.Reserva.RegistrarReserva" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col-lg-12 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="card-title">Datos Generales</div>
                        <hr>
                        <div class="row">
                            <div class="col-12">
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
                                        <div class="form-group">
                                            <label for="input-1">Tipo Pago</label>
                                            <asp:DropDownList ID="cboTipoPago" class="form-control" runat="server" OnSelectedIndexChanged="cboDepartamento_SelectedIndexChanged" AutoPostBack="true">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card">
                    <div class="card-body">
                        <div class="card-title">Reserva de Ambientes</div>
                        <hr>
                        <div class="row">
                            <div class="col-12">
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
                                    </div>
                                </div>
                                <asp:Panel ID="panelDatos" runat="server">
                                    <div class="row mb-2">
                                        <div class="col-12 table-responsive">
                                            <asp:GridView ID="gvAmbientes" runat="server" class="table table-sm table-hover table-bordered" AutoGenerateColumns="False">
                                                <Columns>
                                                    <asp:BoundField DataField="Distrito" HeaderText="Distrito">
                                                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="Direccion" HeaderText="Direccion"></asp:BoundField>
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
                                    <div class="row mb-2 pull-right" style="padding-right: 15px !important;">
                                        <label class="col-7 col-form-label text-right">Total:</label>
                                        <asp:TextBox ID="txtMonto" class="col-5 form-control text-right" runat="server" ></asp:TextBox>
                                    </div>
                                </asp:Panel>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card">
                    <div class="card-body">
                        <div class="card-title">Huespedes por Reserva</div>
                        <hr>
                        <div class="row">
                            <div class="col-12">
                                <div class="row">
                                    <div class="col-sm-3">
                                        <div class="form-group">
                                            <label for="input-3">Tipo Doc.</label>
                                            <asp:DropDownList ID="cboTipoDocumento" class="form-control" runat="server" OnSelectedIndexChanged="cboTipoDocumento_SelectedIndexChanged" AutoPostBack="true">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col-sm-3">
                                        <div class="form-group">
                                            <label for="input-3">Numero Doc.</label>
                                            <asp:TextBox ID="txtDocumento" class="form-control" runat="server" MaxLength="12"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-sm-3">
                                        <div class="form-group">
                                            <label for="input-3">Nombre</label>
                                            <asp:TextBox ID="txtIdHuesped" class="form-control d-none" runat="server"></asp:TextBox>
                                            <asp:TextBox ID="txtNombre" class="form-control" runat="server"></asp:TextBox>
                                            <asp:TextBox ID="txtPais" class="form-control d-none" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-sm-3 m-auto text-left" style="margin-bottom: 15px !important;">
                                        <asp:Button ID="btnBuscar" class="btn btn-primary shadow-primary px-3" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                                        <asp:Button ID="btnAgregarHuesped" class="btn btn-primary shadow-primary px-3" runat="server" Text="Agregar" OnClick="btnAgregarHuesped_Click" />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-12 table-responsive">
                                        <asp:GridView ID="gvHuespedes" runat="server" class="table table-sm table-hover table-bordered" AutoGenerateColumns="False">
                                            <Columns>
                                                <asp:BoundField DataField="Nombre" HeaderText="Nombre">
                                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Pais" HeaderText="Pais"></asp:BoundField>
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
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 text-right">
                        <asp:Button ID="btnGuardar" class="btn btn-success shadow-success px-3" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
