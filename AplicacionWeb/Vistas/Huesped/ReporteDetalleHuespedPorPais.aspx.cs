using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb.Vistas.Huesped
{
    public partial class ReporteDetalleHuespedPorPais : System.Web.UI.Page
    {
        private ProxyHuesped.ServiceHuespedClient serviceHuesped = new ProxyHuesped.ServiceHuespedClient();
        private ProxyUbigeo.ServiceUbigeoClient serviceUbigeo = new ProxyUbigeo.ServiceUbigeoClient();
        private String firstDay = "01/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        private String today = DateTime.Today.ToShortDateString();

        private void loadPais(String idPais)
        {
            cboPais.DataSource = serviceUbigeo.obtenerPaises();
            cboPais.DataTextField = "Pais";
            cboPais.DataValueField = "IdPais";
            cboPais.DataBind();
            cboPais.SelectedValue = idPais;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    loadPais("PER");
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
            try
            {
                DateTime fecIng = Convert.ToDateTime(txtFecIni.Text.Trim());
                DateTime fecSal = Convert.ToDateTime(txtFecFin.Text.Trim());
                String idPais = cboPais.SelectedValue;

                gvHuespedes.DataSource = serviceHuesped.obtenerHuespedesPorPais(fecIng, fecSal, idPais);
                gvHuespedes.DataBind();

                lblMensajeError.Text = "";
                if (gvHuespedes.Rows.Count <= 0) lblMensaje.Visible = true;
                else lblMensaje.Visible = false;
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }
    }
}