using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recnik
{
    public partial class Dodavanje : System.Web.UI.Page
    {
        DataLoader Loader = new DataLoader();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                txtEngleskaRec.Text = "";
                txtSrpskaRec.Text = "";
                txtOpis.Text = "";
            }
        }

        protected void btnSnimi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEngleskaRec.Text))
            {
                lblError.Text = "Engleska reč mora biti navedena";
                lblError.Visible = true;
                lblError.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(txtSrpskaRec.Text))
            {
                lblError.Text = "Srpska reč mora biti navedena";
                lblError.Visible = true;
                lblError.ForeColor = System.Drawing.Color.Red;
                return;
            }

            lblError.Visible = false;
            lblError.Text = "";

            Rec Rec = new Rec();
            Rec.Srpski = txtSrpskaRec.Text;
            Rec.Engleski = txtEngleskaRec.Text;
            Rec.Opis = txtOpis.Text;

            if (Loader.DodajRec(Rec))
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                lblError.Text = Loader.ErrorMessage;
                lblError.Visible = true;
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}