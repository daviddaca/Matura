using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak25
{
    public partial class LogIn : System.Web.UI.Page
    {      
       protected void Page_Load(object sender, EventArgs e)
        {        
            if (Global.BazaKorisnika.KorisnikJePriavljen(this.Request))
            {
                Response.Redirect("~/Index.aspx");
            }
        }        

        protected void btn_login_Click(object sender, EventArgs e)
        {
            error_message.Visible = false;          

            if (Global.BazaKorisnika.PrijavaKorisnika(Response, txt_username.Text, txt_passowrd.Text))
            {               
                Response.Redirect("~/Index.aspx");
                return;
            }
            
            error_message.Text = "Podaci za prijavu nisu tačni!";
            error_message.ForeColor = System.Drawing.Color.Red;
            error_message.Visible = true;

        }
    }
}