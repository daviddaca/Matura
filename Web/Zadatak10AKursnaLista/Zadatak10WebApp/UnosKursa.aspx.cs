using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Zadatak10WebApp
{
    public partial class UnosKursa : System.Web.UI.Page
    {
        private SVCKursnaLista.KursnaListaSoapClient kls = new SVCKursnaLista.KursnaListaSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblerror_message.Text = "";

            if (!this.IsPostBack)
            {                
                List<string> sveValute = kls.ProcitajSveValute();
                ddlValute.DataSource = sveValute;
                ddlValute.DataBind();
                txtDatum.Text = DateTime.Today.ToString("dd.MM.yyyy");
                txtIznos.Text = "";
            }
        }


        protected void btnSnimi_Click(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Today;

            if (string.IsNullOrEmpty(txtIznos.Text))
            {
                lblerror_message.Text = "Iznos mora biti naveden!";
                return;
            }

            if (string.IsNullOrEmpty(txtDatum.Text))
            {
                lblerror_message.Text = "Datum mora biti naveden!";
                return;
            }

            if (string.IsNullOrEmpty(ddlValute.SelectedValue))
            {
                lblerror_message.Text = "Valuta mora biti naveden!";
                return;
            }

            datum = DateTime.ParseExact(txtDatum.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            string valuta = ddlValute.SelectedValue;

            decimal iznos = 0;
            if (!string.IsNullOrEmpty(txtIznos.Text))
            {
                iznos = Decimal.Parse(txtIznos.Text);
            }

            if (kls.UpisiKursNaDan(datum, valuta, iznos))
            {
                Response.Redirect("~/KursNaDan.aspx");
            }
            else
            {
                lblerror_message.Text = "Greška prilikom upisa podataka!";
            }

        }

        protected void btnOdustani_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/KursNaDan.aspx");
        }
    }
}