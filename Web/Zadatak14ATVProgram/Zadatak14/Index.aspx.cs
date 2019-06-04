using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadatak14
{
    public partial class Index : System.Web.UI.Page
    {
        DataProvider provider = new DataProvider(@"C:\Users\Nikola\Desktop\Zadatak14\Emisije");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                foreach(string emisija in provider.TipoviEmisija())
                {
                    ddlTipEmisije.Items.Add(emisija);
                }

                foreach (string datum in provider.DateList())
                {
                    ddlDatum.Items.Add(datum);
                }
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Emisija> Emisije = provider.LoadData(ddlDatum.SelectedValue, ddlTipEmisije.SelectedValue);

            foreach (Emisija E in Emisije)
            {
                TableRow tr = new TableRow();

                TableCell td = new TableCell();
                td.Controls.Add(new Label() { Text = E.Vreme });
                tr.Controls.Add(td);

                td = new TableCell();                
                td.Controls.Add(new Label() { Text = E.Naziv });
                tr.Controls.Add(td);

                td = new TableCell();                ;
                td.Controls.Add(new Image() { ImageUrl = E.SlikaTipa });
                tr.Controls.Add(td);

                tblEmisije.Rows.Add(tr);
            }
        }
    }
}