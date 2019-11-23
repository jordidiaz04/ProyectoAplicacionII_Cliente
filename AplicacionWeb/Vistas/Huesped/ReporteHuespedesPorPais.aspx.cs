using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb.Vistas.Huesped
{
    public partial class ReporteHuespedesPorPais : System.Web.UI.Page
    {
        ProxyHuesped.ServiceHuespedClient servicioHuesped = new ProxyHuesped.ServiceHuespedClient();
        ProxyUbigeo.ServiceUbigeoClient servicioUbigeo = new ProxyUbigeo.ServiceUbigeoClient();
        private String firstDay = "01/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        private String today = DateTime.Today.ToShortDateString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    txtFecIni.Text = firstDay;
                    txtFecFin.Text = today;
                    lblMensajeError.Text = "";
                }
                catch (Exception ex)
                {
                    lblMensajeError.Text = "Error: " + ex.Message;
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime ini = DateTime.Parse(txtFecIni.Text);
            DateTime fin = DateTime.Parse(txtFecFin.Text);
            gvHuespedes.DataSource = servicioHuesped.contarHuespedesPorPais(ini, fin);
            gvHuespedes.DataBind();
        }
    }
}