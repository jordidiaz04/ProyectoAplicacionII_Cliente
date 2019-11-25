using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWeb.Vistas.Huesped
{
    public partial class ReporteHuespedesPorReserva : System.Web.UI.Page
    {
        private ProxyTipoDocumento.ServiceTipoDocumentoClient serviceTipoDocumento = new ProxyTipoDocumento.ServiceTipoDocumentoClient();
        private ProxyReserva.ServiceReservaClient serviceReserva = new ProxyReserva.ServiceReservaClient();
        private String firstDay = "01/" + DateTime.Today.Month + "/" + DateTime.Today.Year;
        private String today = DateTime.Today.ToShortDateString();

        private void loadTipoDocumento(String id)
        {
            cboTipoDoc.DataSource = serviceTipoDocumento.listarTiposDocumento();
            cboTipoDoc.DataTextField = "Descripcion";
            cboTipoDoc.DataValueField = "Id";
            cboTipoDoc.DataBind();
            cboTipoDoc.SelectedValue = id;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    loadTipoDocumento("1");
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecIng = Convert.ToDateTime(txtFecIng.Text.Trim());
                DateTime fecSal = Convert.ToDateTime(txtFecSal.Text.Trim());
                String idTipoDoc = cboTipoDoc.SelectedValue.ToString();
                String numDoc = txtNumDoc.Text.Trim();
                var lista = serviceReserva.listarReservasPorHuesped(idTipoDoc, numDoc, fecIng, fecSal);
                gvReservas.DataSource = lista;
                gvReservas.DataBind();

                lblMensajeError.Text = "";
                if (gvReservas.Rows.Count <= 0)
                {
                    lblMensaje.Visible = true;
                    panelDatos.Visible = false;
                }
                else
                {
                    lblMensaje.Visible = false;
                    panelDatos.Visible = true;
                    var objHuesped = lista.FirstOrDefault();
                    lblNombre.Text = objHuesped.Huesped.Nombre;
                    lblEmail.Text = objHuesped.Huesped.Email;
                    lblPais.Text = objHuesped.Huesped.Pais;
                }
            }
            catch (Exception ex)
            {
                lblMensajeError.Text = "Error: " + ex.Message;
            }
        }
    }
}