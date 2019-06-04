using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak9WebApp
{
    public partial class Index : System.Web.UI.Page
    {
        ServiceKonvertorTeksta.KonvertorTekstaSoapClient ServiceClient = new ServiceKonvertorTeksta.KonvertorTekstaSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void btnLatUCir_Click(object sender, EventArgs e)
        {
            txtCirilica.Text = ServiceClient.LatinicaUCirilicu(txtLatinica.Text);
        }

        protected void btnCirULat_Click(object sender, EventArgs e)
        {
            txtLatinica.Text = ServiceClient.CirilicaULatinicu(txtCirilica.Text);
        }
    }
}