using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb.Vistas.Ambiente
{
    public partial class ReporteAmbientePorAforo : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    loadUbigeo("15", "01", "01");
                    txtFecIng.Text = firstDay;
                    txtFecSal.Text = today;
                    txtAfoMin.Text = "1";
                    txtAfoMax.Text = "10";
                    lblMensajeError.Text = "";
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
        }

        protected void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDistrito(cboDepartamento.SelectedValue, cboProvincia.SelectedValue, "01");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecIng = Convert.ToDateTime(txtFecIng.Text.Trim());
                DateTime fecSal = Convert.ToDateTime(txtFecSal.Text.Trim());
                String idUbig = cboDepartamento.SelectedValue + cboProvincia.SelectedValue + cboDistrito.SelectedValue;
                Int16 afoMin = Convert.ToInt16(txtAfoMin.Text.Trim());
                Int16 afoMax = Convert.ToInt16(txtAfoMax.Text.Trim());

                gvAmbientes.DataSource = serviceAmbiente.obtenerAmbienteDisponiblePorAforo(fecIng, fecSal, afoMin, afoMax, idUbig);
                gvAmbientes.DataBind();

                lblMensajeError.Text = "";
                if (gvAmbientes.Rows.Count <= 0) lblMensaje.Visible = true;
                else lblMensaje.Visible = false;
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }
    }
}