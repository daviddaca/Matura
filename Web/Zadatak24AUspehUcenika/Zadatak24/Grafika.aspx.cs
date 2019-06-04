using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak24
{
    public partial class Grafika : System.Web.UI.Page
    {
        DataLoader DataLoader = new DataLoader();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (DataLoader.LoadData())
            {               
                List<Uspeh> UspehPoRazredima = DataLoader.UspehPoRazredima;
                
                Chart.Series["UspehUcenika"].XValueMember = "Razred";
                Chart.Series["UspehUcenika"].YValueMembers = "ProsecnaOcena";                

                Chart.DataSource = UspehPoRazredima;
                Chart.DataBind();


            }
            else
            {
                err_label.ForeColor = System.Drawing.Color.Red;
                err_label.Text = DataLoader.ErrorMessage;
                err_label.Visible = true;

            }

            

        }
    }
}