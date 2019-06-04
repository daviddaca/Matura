using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vezba5
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int SelectedIndex = -1;
            if (cmbLinije.Items.Count > 0)
                SelectedIndex = cmbLinije.SelectedIndex;

            List<Linija> Linije = new List<Linija>();
            string[] fajlovi = System.IO.Directory.GetFiles(@"D:\VebProgramiranje\Zadatak7\Linije");

            foreach (string fajl in fajlovi)
            {
                Linija L = new Linija(fajl);
                Linije.Add(L);
            }

            cmbLinije.DataTextField = "Naziv";
            cmbLinije.DataValueField = "NazivFajla";
            cmbLinije.DataSource = Linije;
            cmbLinije.DataBind();

            cmbLinije.SelectedIndex = SelectedIndex;

            NapuniSmerove();


        }
        protected void cmbLinije_SelectedIndexChanged(object sender, EventArgs e)
        {

            NapuniSmerove();

        }

        private void NapuniSmerove()
        {

            int SelectedIndex = -1;
            SelectedIndex = cmbSmerovi.SelectedIndex;
            Linija L = new Linija(cmbLinije.SelectedValue);
            L.ProcitajPodatke();

            cmbSmerovi.DataTextField = "NazivSmera";
            cmbSmerovi.DataValueField = "NazivSmera";
            cmbSmerovi.DataSource = L.Smerovi;
            cmbSmerovi.DataBind();

            cmbSmerovi.SelectedIndex = SelectedIndex;
        }

        protected void btnPrikazi_Click(object sender, EventArgs e)
        {
            Linija L = new Linija(cmbLinije.SelectedValue);
            L.ProcitajPodatke();

            TableHeaderRow hr = new TableHeaderRow();
            TableHeaderCell th;

            th = new TableHeaderCell();

            th.Controls.Add(new LiteralControl("Rbr"));
            hr.Cells.Add(th);

            th = new TableHeaderCell();
            th.Controls.Add(new LiteralControl("Polazak"));
            hr.Cells.Add(th);

            tblPolasci.Rows.Add(hr);

            TableRow tr;
            TableCell td;
            int i = 1;

            foreach (Polazak P in L.PronadjiPolaske(cmbSmerovi.SelectedValue))
            {
                tr = new TableRow();

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}.", i++)));
                tr.Cells.Add(td);

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}", P.Vreme)));
                tr.Cells.Add(td);

                tblPolasci.Rows.Add(tr);
            }


        }
    }
}