using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LocationPopulation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void search_Click(object sender, EventArgs e)
    {
        SqlDataSource2.SelectParameters["l"].DefaultValue = ListBox1.SelectedValue.ToString();
    }

    protected void homeB_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}