using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoServicios;


namespace AplicacionWeb.Vistas.Huesped
{
    public partial class DemografiasHuespedes : System.Web.UI.Page
    {
        ServicioHuespedes servicioHuespedes = new ServicioHuespedes();
        
        protected void Page_Load(object sender, EventArgs e)
        {
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
            Int32 id = 0;
            String idTipoDoc = cbRTDoc.SelectedValue;
            String numDoc = txtRNDoc.Text;
            String nombre = txtRNombre.Text;
            String email = txtREmail.Text;
            String telefono = txtRTel.Text;
            String idPais = txtRPais.Text;

            Boolean registrado = servicioHuespedes.registrarHuesped();
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