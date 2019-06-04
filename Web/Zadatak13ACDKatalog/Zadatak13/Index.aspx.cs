using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak13
{
    public partial class Index : System.Web.UI.Page
    {
       
        private DataProvider dp = new DataProvider(@"C:\Users\5\Desktop\Zadatak13\Zadatak13\Zadatak13\katalog.txt");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (dp.LoadData())
                {
                    dlZanr.Items.Clear();
                    dlZanr.DataSource = dp.SviZanrovi();
                    dlZanr.DataBind();

                    dlGodina.Items.Clear();                    
                    dlGodina.DataTextField = "Value";
                    dlGodina.DataValueField = "Key";
                    dlGodina.DataSource = dp.SveGodine();
                    dlGodina.DataBind();
                }
                else
                {
                    lbl_error_message.Text = dp.ErrorMessage;
                    lbl_error_message.Visible = true;
                }

            }
        }

        protected void btnTrazi_Click(object sender, EventArgs e)
        {
            if (dp.LoadData())
            {                                                
                List<Album> rezultatiPretrage = dp.Trazi(txtIzvodjac.Text, txtNaziv.Text, dlZanr.SelectedItem.ToString(), Convert.ToInt32(dlGodina.SelectedValue), txtIzdavackaKuca.Text);

                TableHeaderRow headerRow = new TableHeaderRow();

                TableHeaderCell th = new TableHeaderCell();
                th.Controls.Add(new LiteralControl("S"));
                th.CssClass = "colSlika";
                headerRow.Controls.Add(th);

                th = new TableHeaderCell();
                th.Controls.Add(new LiteralControl("Izvodjač"));
                th.CssClass = "colIzvodjac";
                headerRow.Controls.Add(th);

                th = new TableHeaderCell();
                th.Controls.Add(new LiteralControl("Naziv"));
                th.CssClass = "colNaziv";
                headerRow.Controls.Add(th);

                th = new TableHeaderCell();
                th.Controls.Add(new LiteralControl("Godina"));
                th.CssClass = "colGodina";
                headerRow.Controls.Add(th);

                th = new TableHeaderCell();
                th.Controls.Add(new LiteralControl("Žanr"));
                th.CssClass = "colZanr";
                headerRow.Controls.Add(th);

                th = new TableHeaderCell();
                th.Controls.Add(new LiteralControl("Izdavačka kuća"));
                th.CssClass = "colIzdavackaKuca";
                headerRow.Controls.Add(th);

                tblRezultati.Controls.Add(headerRow);

                foreach (Album A in rezultatiPretrage)
                {
                    TableRow row = new TableRow();

                    TableCell td = new TableCell();
                    td.Controls.Add(new Image() { ImageUrl = A.Slika });
                    row.Controls.Add(td);

                    td = new TableCell();
                    td.Controls.Add(new LiteralControl(A.Izvodjac));
                    row.Controls.Add(td);

                    td = new TableCell();
                    td.Controls.Add(new LiteralControl(A.Naziv));
                    row.Controls.Add(td);

                    td = new TableCell();
                    td.Controls.Add(new LiteralControl(A.GodinaIzdanja.ToString()));
                    row.Controls.Add(td);

                    td = new TableCell();
                    td.Controls.Add(new LiteralControl(A.Zanr));
                    row.Controls.Add(td);

                    td = new TableCell();
                    td.Controls.Add(new LiteralControl(A.IzdavackaKuca));
                    row.Controls.Add(td);

                    tblRezultati.Controls.Add(row);

                }
            }
            else
            {
                lbl_error_message.Text = dp.ErrorMessage;
                lbl_error_message.Visible = true;   
            }


        }
    }
}