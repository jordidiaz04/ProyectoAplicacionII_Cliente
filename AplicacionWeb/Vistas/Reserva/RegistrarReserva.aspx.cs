using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb.Vistas.Reserva
{
    public partial class RegistrarReserva : System.Web.UI.Page
    {
        private ProxyTipoPago.ServiceTipoPagoClient serviceTipoPago = new ProxyTipoPago.ServiceTipoPagoClient();
        private ProxyTipoDocumento.ServiceTipoDocumentoClient serviceTipoDocumento = new ProxyTipoDocumento.ServiceTipoDocumentoClient();
        private ProxyHuesped.ServiceHuespedClient serviceHuesped = new ProxyHuesped.ServiceHuespedClient();
        private ProxyAmbiente.ServiceAmbienteClient serviceAmbiente = new ProxyAmbiente.ServiceAmbienteClient();
        private ProxyUbigeo.ServiceUbigeoClient serviceUbigeo = new ProxyUbigeo.ServiceUbigeoClient();
        private ProxyReserva.ServiceReservaClient serviceReserva = new ProxyReserva.ServiceReservaClient();
        private String firstDay = "1/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        private String today = DateTime.Today.ToShortDateString();

        private void loadTipoPago()
        {
            cboTipoPago.DataSource = serviceTipoPago.obtenerTiposPago();
            cboTipoPago.DataValueField = "Id";
            cboTipoPago.DataTextField = "Descripcion";
            cboTipoPago.DataBind();
        }

        private void loadTipoDocumento(String idTipoDoc)
        {
            cboTipoDocumento.DataSource = serviceTipoDocumento.listarTiposDocumento();
            cboTipoDocumento.DataValueField = "Id";
            cboTipoDocumento.DataTextField = "Descripcion";
            cboTipoDocumento.DataBind();

            cboTipoDocumento.SelectedValue = idTipoDoc;
        }

        private void setMaxLengthDocumento()
        {
            String id = cboTipoDocumento.SelectedValue.ToString();
            switch (id)
            {
                case "1":
                    txtDocumento.MaxLength = 8;
                    break;
                case "6":
                    txtDocumento.MaxLength = 11;
                    break;
                default:
                    txtDocumento.MaxLength = 15;
                    break;
            }

            txtNombre.Text = "";
        }

        private void loadUbigeo(String idDepa, String idProv, String idDist)
        {
            loadDepartamento(idDepa);
            loadProvincia(idDepa, idProv);
            loadDistrito(idDepa, idProv, idDist);
        }

        private void loadDepartamento(String idDepa)
        {
            cboDepartamento.DataSource = serviceUbigeo.obtenerDepartamentos();
            cboDepartamento.DataTextField = "Departamento";
            cboDepartamento.DataValueField = "IdDepartamento";
            cboDepartamento.DataBind();
            cboDepartamento.SelectedValue = idDepa;
        }

        private void loadProvincia(String idDepa, String idProv)
        {
            cboProvincia.DataSource = serviceUbigeo.obtenerProvincias(idDepa);
            cboProvincia.DataTextField = "Provincia";
            cboProvincia.DataValueField = "IdProvincia";
            cboProvincia.DataBind();
            cboProvincia.SelectedValue = idProv;
        }

        private void loadDistrito(String idDepa, String idProv, String idDist)
        {
            cboDistrito.DataSource = serviceUbigeo.obtenerDistritos(idDepa, idProv);
            cboDistrito.DataTextField = "Distrito";
            cboDistrito.DataValueField = "IdDistrito";
            cboDistrito.DataBind();
            cboDistrito.SelectedValue = idDist;
        }

        private void loadTipoAmbiente()
        {
            List<String> listTipoAmbiente = new List<String>();
            listTipoAmbiente.Add("Todos");
            listTipoAmbiente.Add("Habitación");
            listTipoAmbiente.Add("Otros");

            cboTipoAmbiente.DataSource = listTipoAmbiente;
            cboTipoAmbiente.DataBind();
        }

        private void loadAmbiente(Int32 idTipo)
        {
            DateTime fecIng = Convert.ToDateTime(txtFecIng.Text.Trim());
            DateTime fecSal = Convert.ToDateTime(txtFecSal.Text.Trim());
            String idUbig = cboDepartamento.SelectedValue + cboProvincia.SelectedValue + cboDistrito.SelectedValue;

            List<ProxyAmbiente.AmbienteBE> lstAmbiente = serviceAmbiente.obtenerAmbienteDisponiblePorFecha(fecIng, fecSal, idUbig);
            Session["lstAmbiente"] = lstAmbiente;
            List<ProxyAmbiente.AmbienteBE> lstTemporal = new List<ProxyAmbiente.AmbienteBE>();

            switch (idTipo)
            {
                case 1:
                    lstTemporal = (from item in lstAmbiente
                                   select item).ToList();
                    break;
                case 2:
                    lstTemporal = (from item in lstAmbiente
                                   where !(item.Identificador.Contains("PISCINA") || item.Identificador.Contains("SALA"))
                                   select item).ToList();
                    break;
                case 3:
                    lstTemporal = (from item in lstAmbiente
                                   where item.Identificador.Contains("PISCINA") || item.Identificador.Contains("SALA")
                                   select item).ToList();
                    break;
            }

            cboAmbiente.DataSource = lstTemporal;
            cboAmbiente.DataTextField = "Descripcion";
            cboAmbiente.DataValueField = "IdAmbiente";
            cboAmbiente.DataBind();

            if (cboAmbiente.Items.Count > 0) { cboAmbiente.SelectedIndex = 0; btnGuardar.Enabled = true; }
            else { btnGuardar.Enabled = false; btnGuardar.CssClass = "btn btn-success shadow-success px-5"; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    txtFecIng.Text = firstDay;
                    txtFecSal.Text = today;
                    lblMensajeError.Text = "";
                    loadTipoPago();
                    loadUbigeo("15", "01", "01");
                    loadTipoAmbiente();
                    loadAmbiente(1);
                    loadTipoDocumento("1");
                    setMaxLengthDocumento();
                    panelDatos.Visible = false;
                }
                catch (Exception ex)
                {
                    lblMensajeError.Text = "Error: " + ex.Message;
                }
            }
        }

        protected void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                setMaxLengthDocumento();
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                String idTipoDoc = cboTipoDocumento.SelectedValue.ToString();
                String numDoc = txtDocumento.Text.Trim();
                
                if (numDoc != "")
                {
                    ProxyHuesped.HuespedBE huespedBE = serviceHuesped.obtenerHuesped(idTipoDoc, numDoc);
                    txtIdHuesped.Text = huespedBE.Id.ToString();
                    txtNombre.Text = huespedBE.Nombre;
                    txtPais.Text = huespedBE.Pais;
                }
                lblMensajeError.Text = "";
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void btnAgregarHuesped_Click(object sender, EventArgs e)
        {
            try
            {
                List<ProxyHuesped.HuespedBE> lstHuespedBE = (List<ProxyHuesped.HuespedBE>)Session["lstHuespedBE"];
                if (lstHuespedBE == null) lstHuespedBE = new List<ProxyHuesped.HuespedBE>();

                ProxyHuesped.HuespedBE huespedBE = new ProxyHuesped.HuespedBE()
                {
                    Id = Convert.ToInt32(txtIdHuesped.Text.Trim()),
                    Nombre = txtNombre.Text.Trim(),
                    Pais = txtPais.Text.Trim()
                };
                int index = lstHuespedBE.FindIndex(f => f.Id == huespedBE.Id);
                if (index < 0) lstHuespedBE.Add(huespedBE);
                Session["lstHuespedBE"] = lstHuespedBE;

                gvHuespedes.DataSource = lstHuespedBE;
                gvHuespedes.DataBind();

                txtDocumento.Text = "";
                txtNombre.Text = "";
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProvincia(cboDepartamento.SelectedValue, "01");
            loadDistrito(cboDepartamento.SelectedValue, cboProvincia.SelectedValue, "01");
        }

        protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDistrito(cboDepartamento.SelectedValue, cboProvincia.SelectedValue, "01");
        }

        protected void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 idTipo = cboTipoAmbiente.SelectedIndex + 1;
                loadAmbiente(idTipo);
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void cboTipoAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 idTipo = cboTipoAmbiente.SelectedIndex + 1;
                loadAmbiente(idTipo);
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsPostBack)
                {
                    List<ProxyAmbiente.AmbienteBE> lstAmbienteRegistrados = (List<ProxyAmbiente.AmbienteBE>)Session["lstAmbienteRegistrados"];
                    var lstAmbiente = (List<ProxyAmbiente.AmbienteBE>)Session["lstAmbiente"];

                    ProxyAmbiente.AmbienteBE ambienteBE = new ProxyAmbiente.AmbienteBE();
                    ambienteBE.IdAmbiente = Convert.ToInt32(cboAmbiente.SelectedValue.ToString());
                    ambienteBE.Distrito = cboDistrito.SelectedItem.Text;
                    ambienteBE.Direccion = (from item in lstAmbiente
                                            where item.IdAmbiente == ambienteBE.IdAmbiente
                                            select item.Direccion).FirstOrDefault();
                    ambienteBE.Identificador = cboAmbiente.SelectedItem.Text;
                    ambienteBE.Precio = (from item in lstAmbiente
                                         where item.IdAmbiente == ambienteBE.IdAmbiente
                                         select item.Precio).FirstOrDefault();
                    TimeSpan ts = Convert.ToDateTime(txtFecSal.Text.Trim()) - Convert.ToDateTime(txtFecIng.Text.Trim());
                    Int32 days = (Int32)Math.Abs(Math.Round(ts.TotalDays)) + 1;
                    ambienteBE.Monto = ambienteBE.Precio * days;

                    if (lstAmbienteRegistrados == null) { lstAmbienteRegistrados = new List<ProxyAmbiente.AmbienteBE>(); }
                    int index = lstAmbienteRegistrados.FindIndex(f => f.IdAmbiente == ambienteBE.IdAmbiente);
                    if (index < 0) lstAmbienteRegistrados.Add(ambienteBE);

                    Session["lstAmbienteRegistrados"] = lstAmbienteRegistrados;
                    Session["Monto"] = (Session["Monto"] == null ? 0 : Convert.ToDecimal(Session["Monto"])) + ambienteBE.Monto;
                    gvAmbientes.DataSource = lstAmbienteRegistrados;
                    gvAmbientes.DataBind();
                    txtMonto.Text = Convert.ToDecimal(Session["Monto"]).ToString("#.00");
                    lblMensajeError.Text = "";

                    panelDatos.Visible = true;
                }
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ProxyHuesped.HuespedBE> lstHuespedBE = (List<ProxyHuesped.HuespedBE>)Session["lstHuespedBE"];
                List<ProxyAmbiente.AmbienteBE> lstAmbienteBE = (List<ProxyAmbiente.AmbienteBE>)Session["lstAmbienteRegistrados"];
                DateTime fechaInicio = Convert.ToDateTime(txtFecIng.Text.Trim());
                DateTime fechaSalida = Convert.ToDateTime(txtFecSal.Text.Trim());
                Int32 idTipoPago = Convert.ToInt32(cboTipoPago.SelectedValue.Trim());
                Decimal monto = txtMonto.Text.Trim() == "" ? 0 : Convert.ToDecimal(txtMonto.Text.Trim());

                List<ProxyReserva.HuespedBE> lstHuesped = new List<ProxyReserva.HuespedBE>();
                List<ProxyReserva.AmbienteBE> lstAmbiente = new List<ProxyReserva.AmbienteBE>();
                foreach (var item in lstHuespedBE)
                {
                    ProxyReserva.HuespedBE huesped = new ProxyReserva.HuespedBE()
                    {
                        Id = item.Id,
                    };
                    lstHuesped.Add(huesped);
                }
                foreach (var item in lstAmbienteBE)
                {
                    ProxyReserva.AmbienteBE ambiente = new ProxyReserva.AmbienteBE()
                    {
                        IdAmbiente = item.IdAmbiente
                    };
                    lstAmbiente.Add(ambiente);
                }

                if (lstHuespedBE != null && lstAmbienteBE != null && txtFecIng.Text.Trim() != "" && txtFecSal.Text.Trim() != "" && monto > 0)
                {
                    if (serviceReserva.registrarReserva(lstHuesped, lstAmbiente, fechaInicio, fechaSalida, idTipoPago, monto))
                    {
                        txtMonto.Text = "";
                        Session["lstHuespedBE"] = null;
                        Session["lstAmbienteRegistrados"] = null;
                        gvHuespedes.DataSource = null;
                        gvHuespedes.DataBind();
                        gvAmbientes.DataSource = null;
                        gvAmbientes.DataBind();
                        lblMensajeError.Text = "Usuario registrado";
                    }
                    else
                    {
                        lblMensajeError.Text = "No se pudo completar el registro!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }
    }
}