using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AplicacionWeb.Vistas.Huesped
{
    public partial class DemografiasHuespedes : System.Web.UI.Page
    {
        ProxyHuesped.ServiceHuespedClient servicioHuespedes = new ProxyHuesped.ServiceHuespedClient();
        ProxyUbigeo.ServiceUbigeoClient servicioUbigeo = new ProxyUbigeo.ServiceUbigeoClient();

        private void loadPais()
        {
            cboPais.DataSource = servicioUbigeo.obtenerPaises();
            cboPais.DataTextField = "Pais";
            cboPais.DataValueField = "IdPais";
            cboPais.DataBind();
            cboPais.SelectedValue = "PER";
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    loadPais();
                }
                catch(Exception ex)
                {
                    lblError.Text = "Error: " + ex.Message;
                }
            }
        }

        protected void btnPorPais_Click(object sender, EventArgs e)
        {
            DateTime ini = DateTime.Parse(txtFechaIniPais.Text);
            DateTime fin = DateTime.Parse(txtFechaFinPais.Text);
            gvPorPais.DataSource = servicioHuespedes.contarHuespedesPorPais(ini, fin);
            gvPorPais.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime iniDinero = DateTime.Parse(txtInicioDinero.Text);
            DateTime finDinero = DateTime.Parse(txtFinDinero.Text);
            String tdoc = txtTipoDocDinero.Text;
            String ndoc = txtNumDocDinero.Text;

            Decimal total = servicioHuespedes.obtenerDineroGastadoPorHuesped(iniDinero, finDinero, tdoc, ndoc);
            lblTotalGastado.Text = "Total dinero gastado entre las fechas: " + total;
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            ProxyHuesped.HuespedBE huesped = new ProxyHuesped.HuespedBE()
            {
                Id = 0,
                IdTipoDoc = cbRTDoc.SelectedValue,
                NumDoc = txtRNDoc.Text,
                Nombre = txtRNombre.Text,
                Email = txtREmail.Text,
                Telefono = txtRTel.Text,
                IdPais = cboPais.SelectedValue
        };
            
            Boolean registrado = servicioHuespedes.registrarHuesped(huesped);
            if (registrado)
            {
                lblRegistrado.Text = "Registro Exitoso";
            }
            else {
                lblRegistrado.Text = "Registro Fallido";
            }
        }
    }
}