using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AplicacionWeb.Vistas.Reservas
{
    public partial class ReservasHuesped : System.Web.UI.Page
    {
        ProxyReserva.ServiceReservaClient objServicioR = new ProxyReserva.ServiceReservaClient();
        private String firstDay = "01/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        private String today = DateTime.Today.ToShortDateString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtFecIni.Text = firstDay;
                txtFecFin.Text = today;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvContenido.DataSource = objServicioR.listarReservasPorHuesped
                    (cboTipoDoc.SelectedValue.ToString(),txtNumDoc.Text,
                    Convert.ToDateTime(txtFecIni.Text), Convert.ToDateTime(txtFecFin.Text));
                grvContenido.DataBind();

                if (grvContenido.Rows.Count > 0) lblMensajePrincipal.Visible = false;
                else lblMensajePrincipal.Visible = true;

            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error...." + ex.Message;
            }
        }
    }
}