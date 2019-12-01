using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb.Vistas.Reserva
{
    public partial class ReporteReservasPorFecha : System.Web.UI.Page
    {
        private ProxyReserva.ServiceReservaClient serviceReserva = new ProxyReserva.ServiceReservaClient();
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
            loadDistrito(cboDepartamento.SelectedValue, cboProvincia.SelectedValue, "01");
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

                gvReservas.DataSource = serviceReserva.listarReservasPorFecha(fecIng, fecSal, idUbig);
                gvReservas.DataBind();

                lblMensajeError.Text = "";
                if (gvReservas.Rows.Count <= 0) lblMensaje.Visible = true;
                else lblMensaje.Visible = false;
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }
    }
}