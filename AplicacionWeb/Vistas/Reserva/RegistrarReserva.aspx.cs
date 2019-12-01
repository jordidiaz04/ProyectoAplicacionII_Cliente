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
        private ProxyAmbiente.ServiceAmbienteClient serviceAmbiente = new ProxyAmbiente.ServiceAmbienteClient();
        private ProxyUbigeo.ServiceUbigeoClient serviceUbigeo = new ProxyUbigeo.ServiceUbigeoClient();
        private String firstDay = "01/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        private String today = DateTime.Today.ToShortDateString();

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

            ProxyAmbiente.AmbienteBE[] lstAmbiente = serviceAmbiente.obtenerAmbienteDisponiblePorFecha(fecIng, fecSal, idUbig);
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

            if (cboAmbiente.Items.Count > 0) { cboAmbiente.SelectedIndex = 0; btnRegistrar.Enabled = true; }
            else { btnRegistrar.Enabled = false; btnRegistrar.CssClass = "btn btn-primary shadow-primary px-5"; }
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
                    loadUbigeo("15", "01", "01");
                    loadTipoAmbiente();
                    loadAmbiente(1);
                }
                catch (Exception ex)
                {
                    lblMensajeError.Text = "Error: " + ex.Message;
                }
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
                List<ProxyAmbiente.AmbienteBE> lstAmbienteRegistrados = new List<ProxyAmbiente.AmbienteBE>();
                var lstAmbiente = (ProxyAmbiente.AmbienteBE[])Session["lstAmbiente"];

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
                Int32 days = (Int32)Math.Abs(Math.Round(ts.TotalDays));
                ambienteBE.Monto = ambienteBE.Precio * days;

                lstAmbienteRegistrados.Add(ambienteBE);
                gvAmbientes.DataSource = lstAmbienteRegistrados;
                gvAmbientes.DataBind();
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ProxyReserva.ReservaBE reservaBE = new ProxyReserva.ReservaBE();

        }
    }
}