using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak11
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblerror_message.Text = string.Empty;
            pnlResult.Visible = false;
        }

        protected void btnIzracunaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImeOsobe1.Text))
            {
                lblerror_message.Text = "Ime prve osobe mora biti navedeno!";
                return;
            }
            if (string.IsNullOrEmpty(txtImeOsobe2.Text))
            {
                lblerror_message.Text = "Ime druge osobe mora biti navedeno!";
                return;
            }
            if (string.IsNullOrEmpty(txtDatumRodjenja1.Text))
            {
                lblerror_message.Text = "Datum rođenja prve osobe mora biti naveden!";
                return;
            }
            if (string.IsNullOrEmpty(txtDatumRodjenja2.Text))
            {
                lblerror_message.Text = "Datum rođenja druge osobe mora biti naveden!";
                return;
            }

            try
            {
                string Date1 = txtDatumRodjenja1.Text.Replace(".", "");
                string Date2 = txtDatumRodjenja2.Text.Replace(".", "");

                int Zbir1 = 0;
                int Zbir2 = 0;
                decimal ProcSlaganja = 0;

                foreach (char c in Date1)
                    Zbir1 += Convert.ToInt32(c.ToString());

                foreach (char c in Date2)
                    Zbir2 += Convert.ToInt32(c.ToString());

                Zbir1 = Zbir1 / 10 + Zbir1 % 10;
                Zbir2 = Zbir2 / 10 + Zbir2 % 10;

                if (Zbir1 > Zbir2)
                    ProcSlaganja = (decimal)Zbir2 / (decimal)Zbir1 * 100;
                else
                    ProcSlaganja = (decimal)Zbir1 / (decimal)Zbir2 * 100;

                lblImeOsobe1.Text = txtImeOsobe1.Text;
                lblImeOsobe2.Text = txtImeOsobe2.Text;
                lblProcenatSlaganja.Text = string.Format("{0:00.00} %", ProcSlaganja);

                pnlResult.Visible = true;
            }
            catch
            {
                lblerror_message.Text = "Došlo je do greške prilikom izračunavanja! Proverite unete vrednosti i pokušajte ponovo.";
            }
        }
    }
}