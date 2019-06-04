using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Recnik
{
    public partial class Index : System.Web.UI.Page
    {
        DataLoader Loader = new DataLoader();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                cmb_smer.Items.Add("Srpski -> Engleski");
                cmb_smer.Items.Add("Engleski -> Srpski");
                cmb_smer.SelectedIndex = 0;
            }
        }

        protected void btn_prevedi_Click(object sender, EventArgs e)
        {
            List<Rec> Prevod = new List<Rec>();

            if (cmb_smer.SelectedIndex == 0)
            {
                Prevod = Loader.SrpskiNaEngleski(txt_rec.Text);
                lst_prevod.DataTextField = "Engleski";
            }
            else
            {
                Prevod = Loader.EngleskiNaSrpski(txt_rec.Text);
                lst_prevod.DataTextField = "Srpski";
            }

            lst_prevod.DataSource = Prevod;            
            lst_prevod.DataBind();
        }
    }
}