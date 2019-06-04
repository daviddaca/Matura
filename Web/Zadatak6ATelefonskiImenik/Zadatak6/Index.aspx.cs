using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vezba4
{
    public partial class Index : System.Web.UI.Page
    {
        Imenik Imenik = new Imenik();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                cmbMesta.DataSource = Imenik.Mesta;                
                cmbMesta.DataBind();
            }
        }

        protected void btnTrazi_Click(object sender, EventArgs e)
        {
            tblKontakti.Rows.Clear();

            List<Kontakt> RezultatPretrage;

            ParametriZaTrazenje PZT = new ParametriZaTrazenje();
            PZT.Ime = txtIme.Text;
            PZT.Prezime = txtPrezime.Text;
            PZT.Adresa = txtAdresa.Text;
            PZT.Telefon = txtTelefon.Text;
            PZT.Mesto = cmbMesta.SelectedItem.ToString();            

            RezultatPretrage = Imenik.Pronadji(PZT);

            TableHeaderRow hr = new TableHeaderRow();
            TableHeaderCell th;

            th = new TableHeaderCell();
            th.CssClass = "colRBR";
            th.Controls.Add(new LiteralControl("Rbr"));
            hr.Cells.Add(th);
            th = new TableHeaderCell();
            th.CssClass = "colIme";
            th.Controls.Add(new LiteralControl("Ime"));
            hr.Cells.Add(th);
            th = new TableHeaderCell();
            th.CssClass = "colPrezime";
            th.Controls.Add(new LiteralControl("Prezime"));
            hr.Cells.Add(th);
            th = new TableHeaderCell();
            th.CssClass = "colAdresa";
            th.Controls.Add(new LiteralControl("Adresa"));
            hr.Cells.Add(th);
            th = new TableHeaderCell();
            th.CssClass = "colTelefon";
            th.Controls.Add(new LiteralControl("Telefon"));
            hr.Cells.Add(th);
            th = new TableHeaderCell();
            th.CssClass = "colEmail";
            th.Controls.Add(new LiteralControl("E-mail"));
            hr.Cells.Add(th);
            th = new TableHeaderCell();
            th.CssClass = "colMesto";
            th.Controls.Add(new LiteralControl("Mesto"));
            hr.Cells.Add(th);

            tblKontakti.Rows.Add(hr);

            TableRow tr;
            TableCell td;

            foreach (Kontakt Kontakt in RezultatPretrage)
            {

                tr = new TableRow();

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}.", Kontakt.ID)));
                tr.Cells.Add(td);

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}", Kontakt.Ime)));
                tr.Cells.Add(td);

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}", Kontakt.Prezime)));
                tr.Cells.Add(td);

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}", Kontakt.Adresa)));
                tr.Cells.Add(td);

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}", Kontakt.Telefon)));
                tr.Cells.Add(td);

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}", Kontakt.EMail)));
                tr.Cells.Add(td);

                td = new TableCell();
                td.Controls.Add(new LiteralControl(string.Format("{0}", Kontakt.Mesto)));
                tr.Cells.Add(td);


                tblKontakti.Rows.Add(tr);

            }


        }
    }
}