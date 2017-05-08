using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PastLocations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void search_Click(object sender, EventArgs e)
    {
        SqlDataSource1.SelectParameters["u"].DefaultValue = searchTB.Text.ToString();
    }

    protected void homeB_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}