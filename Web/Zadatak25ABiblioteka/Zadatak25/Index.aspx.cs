using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak25
{
    public partial class Index : System.Web.UI.Page
    {
        DataProvider dp = new DataProvider(@"D:\VebProgramiranje\Zadatak25\Zadatak25\biblioteka.xml");        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Global.BazaKorisnika.KorisnikJePriavljen(this.Request))
            {
                Response.Redirect("~/LogIn.aspx");
            }
            else
            {
                lblOperater.Text = Global.BazaKorisnika.PrijavljeniKorisnik(this.Request).Username;
                this.PrikaziKnjige();
            }
        }

        private void PrikaziKnjige()
        {
            if (dp.LoadData())
            {
                dp.Sortiraj();

                foreach (Knjiga K in dp.Knjige)
                {
                    TableRow tr = new TableRow();

                    TableCell td = new TableCell();
                    td.Controls.Add(new Label() { Text = K.ISBN });
                    tr.Controls.Add(td);

                    td = new TableCell();
                    td.Controls.Add(new Label() { Text = K.Naslov });
                    tr.Controls.Add(td);

                    td = new TableCell();
                    td.Controls.Add(new Label() { Text = K.Stanje.ToString() });
                    tr.Controls.Add(td);

                    td = new TableCell();
                    td.Controls.Add(new Label() { Text = K.Citano.ToString() });
                    tr.Controls.Add(td);

                    tbl_knjige.Rows.Add(tr);
                }
            }
            else
            {
                error_message.Text = dp.ErrorMessage;
                error_message.ForeColor = System.Drawing.Color.Red;
                error_message.Visible = true;
            }
        }

        protected void lnkOdjava_Click(object sender, EventArgs e)
        {
            Global.BazaKorisnika.OdjavaKorisnika(this.Response);
            Response.Redirect("~/LogIn.aspx");
        }
    }
}