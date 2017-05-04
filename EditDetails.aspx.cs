using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void search_Click(object sender, EventArgs e)
    {
        if (userNameTB.Text == "")
        {
            uError.Visible = true;
        }

        else
        {
            DetailsView2.ChangeMode(DetailsViewMode.ReadOnly);
            ActiveBase.SelectParameters["Query"].DefaultValue = userNameTB.Text.ToString();
        }
    }



    protected void home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}