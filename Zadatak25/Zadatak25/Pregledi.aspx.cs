using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pregledi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.Bind();
        }
    }

    private void Bind()
    {
        using (DataSet ds = new DataSet())
        {
            ds.ReadXml(Server.MapPath("fajl.xml"));
            Gridview1.DataSource = ds;
            Gridview1.DataBind();
        }
    }

    protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        Gridview1.PageIndex = e.NewPageIndex;
        this.Bind();
    }
}