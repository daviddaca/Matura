using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak12
{
    public partial class Index : System.Web.UI.Page
    {
        DataProvider dp = new DataProvider();

        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void btnSnimi_Click(object sender, EventArgs e)
        {          
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                lblerror_message.Text = "Ime mora biti navedeno!";
                lblerror_message.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                lblerror_message.Text = "Email mora biti naveden!";
                lblerror_message.Visible = true;
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                lblerror_message.Text = "Email nije zadat u korektnom obliku!";
                lblerror_message.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(txtKomentar.Text))
            {
                lblerror_message.Text = "Komentar mora biti naveden!";
                lblerror_message.Visible = true;
                return;
            }

            Utisak NoviUtisak = new Utisak();
            NoviUtisak.Ime = txtIme.Text;
            NoviUtisak.Email = txtEmail.Text;
            NoviUtisak.Komentar = txtKomentar.Text;

            if (dp.Snimi(NoviUtisak))
            {
                txtIme.Text = "";
                txtEmail.Text = "";
                txtKomentar.Text = "";
            }
            else
            {
                lblerror_message.Text = dp.ErrorMessage;
                lblerror_message.Visible = true;
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}