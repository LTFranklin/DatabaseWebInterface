using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void changeLocB_Click(object sender, EventArgs e)
    {
        Response.Redirect("ChangeLocation.aspx");
    }

    protected void editDetB_Click(object sender, EventArgs e)
    {
        Response.Redirect("Details.aspx");
    }

    protected void pastLocB_Click(object sender, EventArgs e)
    {
        Response.Redirect("PastLocations.aspx");
    }

    protected void locPop_Click(object sender, EventArgs e)
    {
        Response.Redirect("LocationPopulation.aspx");
    }
}