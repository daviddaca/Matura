using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Zadatak10WebApp
{
    public partial class KursNaDan : System.Web.UI.Page
    {
        private SVCKursnaLista.KursnaListaSoapClient kls = new SVCKursnaLista.KursnaListaSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblerror_message.Text = string.Empty;

            if (!base.IsPostBack)
            {                
                List<string> sveValute = kls.ProcitajSveValute();
                ddlValute.DataSource = sveValute;
                ddlValute.DataBind();
                txtDatum.Text = DateTime.Today.ToString("dd.MM.yyyy");
                lblKursNaDan.Text = "";
            }

        }

        protected void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datum = DateTime.Today;
                if (!string.IsNullOrEmpty(txtDatum.Text))
                {
                    datum = DateTime.ParseExact(txtDatum.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                }

                string valuta = ddlValute.SelectedValue;

                decimal kursNaDan = kls.ProcitajKursNaDan(datum, valuta);
                lblKursNaDan.Text = kursNaDan.ToString();
            }
            catch(Exception ex)
            {
                lblerror_message.Text = ex.Message;
            }

        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UnosKursa.aspx");
        }
    }
}