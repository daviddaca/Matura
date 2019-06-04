using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Vezba7
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!base.IsPostBack)
            {
                RadnaMemorija.Items.Add(new ListItem("", ""));
                RadnaMemorija.Items.Add(new ListItem("512MB", "512"));
                RadnaMemorija.Items.Add(new ListItem("1GB", "1"));
                RadnaMemorija.Items.Add(new ListItem("1.5GB", "1.5"));
                RadnaMemorija.Items.Add(new ListItem("2GB", "2"));
                RadnaMemorija.Items.Add(new ListItem("3GB", "3"));

                Kamera.Items.Add(new ListItem("", ""));
                Kamera.Items.Add(new ListItem("1Mpix", "1"));
                Kamera.Items.Add(new ListItem("2Mpix", "2"));
                Kamera.Items.Add(new ListItem("3Mpix", "3"));
                Kamera.Items.Add(new ListItem("4Mpix", "4"));
                Kamera.Items.Add(new ListItem("5Mpix", "5"));
                Kamera.Items.Add(new ListItem("8Mpix", "8"));
                Kamera.Items.Add(new ListItem("13Mpix", "13"));

                DualSIM.Items.Add(new ListItem("", ""));
                DualSIM.Items.Add(new ListItem("DA", "DA"));
                DualSIM.Items.Add(new ListItem("NE", "NE"));

                Proizvodjac.Items.Add(new ListItem("", ""));
                Proizvodjac.Items.Add(new ListItem("Alcatel", "Alcatel"));
                Proizvodjac.Items.Add(new ListItem("HTC", "HTC"));
                Proizvodjac.Items.Add(new ListItem("Huawei", "Huawei"));
                Proizvodjac.Items.Add(new ListItem("Lenovo", "Lenovo"));
                Proizvodjac.Items.Add(new ListItem("LG", "LG"));
                Proizvodjac.Items.Add(new ListItem("Nokia", "Nokia"));
                Proizvodjac.Items.Add(new ListItem("Sony", "Sony"));

                Ekran.Items.Add(new ListItem("", ""));
                Ekran.Items.Add(new ListItem("1.8'' - 2.9''", "op1"));
                Ekran.Items.Add(new ListItem("3.0'' - 4.9''", "op2"));
                Ekran.Items.Add(new ListItem("5.0'' - 5.4''", "op3"));
                Ekran.Items.Add(new ListItem("5.5'' - 6''", "op4"));
                Ekran.Items.Add(new ListItem(">6''", "op5"));

                Procesor.Items.Add(new ListItem("", ""));
                Procesor.Items.Add(new ListItem("Single Core", "Single Core"));
                Procesor.Items.Add(new ListItem("Dual Core", "Dual Core"));
                Procesor.Items.Add(new ListItem("Quad Core", "Quad Core"));
                Procesor.Items.Add(new ListItem("Octa Core", "Octa Core"));
            }
        }

        protected void btnTrazi_Click(object sender, EventArgs e)
        {
            tblProizvodi.Rows.Clear();

            List<Telefon> RezultatPretrage;

            ParametriZaTrazenje PZT = new ParametriZaTrazenje();
            PZT.RAM = RadnaMemorija.SelectedValue;
            PZT.Kamera = Kamera.SelectedValue;
            PZT.DualSIM = DualSIM.SelectedValue;
            PZT.Proizvodjac = Proizvodjac.SelectedValue;
            switch(Ekran.SelectedValue)
            {
                case "op1":
                    PZT.EkranOd = 1.8;
                    PZT.EkranDo = 2.9;
                    break;
                case "op2":
                    PZT.EkranOd = 3.0;
                    PZT.EkranDo = 4.9;
                    break;
                case "op3":
                    PZT.EkranOd = 5.0;
                    PZT.EkranDo = 5.4;
                    break;
                case "op4":
                    PZT.EkranOd = 5.5;
                    PZT.EkranDo = 6.0;
                    break;
                case "op5":
                    PZT.EkranOd = 6;
                    PZT.EkranDo = 0;
                    break;
            }
            PZT.Procesor = Procesor.SelectedValue;

            WebShop WebShop = new WebShop();

            RezultatPretrage = WebShop.Pronadji(PZT);

            TableHeaderRow hr = new TableHeaderRow();
            TableHeaderCell th;

            th = new TableHeaderCell();
            th.CssClass = "colSlika";
            th.Controls.Add(new LiteralControl(""));
            hr.Cells.Add(th);
            th = new TableHeaderCell();
            th.CssClass = "colOpis";
            th.Controls.Add(new LiteralControl("Karakteristike"));
            hr.Cells.Add(th);
            th = new TableHeaderCell();
            th.CssClass = "colCena";
            th.Controls.Add(new LiteralControl("Cena"));
            hr.Cells.Add(th);

            tblProizvodi.Rows.Add(hr);

            TableRow tr;
            TableCell td;

            foreach (Telefon T in RezultatPretrage)
            {

                tr = new TableRow();

                td = new TableCell();
                td.Controls.Add(new Image() { ImageUrl = T.Slika });
                tr.Cells.Add(td);

                td = new TableCell();
                td.Controls.Add(new Label() { Text = string.Format("{0}", T.Naziv), CssClass = "NazivPrizvoda" });
                td.Controls.Add(new Label() { Text = "<br/>" });
                td.Controls.Add(new Label() { Text = "<br/>" });
                td.Controls.Add(new Label() { Text = string.Format("Proizvođač: {0}", T.Prizvodjac), CssClass = "Karakteristike" });
                td.Controls.Add(new Label() { Text = "<br/>" });
                td.Controls.Add(new Label() { Text = string.Format("RAM: {0} ", T.Ram), CssClass = "Karakteristike" });
                td.Controls.Add(new Label() { Text = "<br/>" });
                td.Controls.Add(new Label() { Text = string.Format("Procesor: {0} ", T.Procesor), CssClass = "Karakteristike" });
                td.Controls.Add(new Label() { Text = "<br/>" });
                td.Controls.Add(new Label() { Text = string.Format("Ekran: {0} ", T.Ekran), CssClass = "Karakteristike" });
                td.Controls.Add(new Label() { Text = "<br/>" });
                td.Controls.Add(new Label() { Text = string.Format("Kamera: {0} ", T.Kamera), CssClass = "Karakteristike" });
                td.Controls.Add(new Label() { Text = "<br/>" });
                td.Controls.Add(new Label() { Text = string.Format("Dual SIM: {0} ", T.DualSIM), CssClass = "Karakteristike" });
                tr.Cells.Add(td);

                td = new TableCell();
                HtmlGenericControl Cena = new HtmlGenericControl("div");
                Cena.ID = "Cena";
                Cena.InnerHtml = string.Format("{0} RSD", T.Cena);
                td.Controls.Add(Cena);
                tr.Cells.Add(td);

                tblProizvodi.Rows.Add(tr);

            }


        }
    }
}