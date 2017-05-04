using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class ChangeLocation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void search_Click(object sender, EventArgs e)
    {
        if(userNameTB.Text=="")
        {
            uError.Visible = true;
        }

        else
        {
            DetailsView2.ChangeMode(DetailsViewMode.ReadOnly);
            ActiveBase.SelectParameters["Query"].DefaultValue = userNameTB.Text.ToString();
        }
    }





    protected void DetailsView2_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        string now = System.DateTime.Now.ToString();
        ActiveBase.UpdateParameters["Date"].DefaultValue = now;
    }

    protected void DetailsView2_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        string now = System.DateTime.Now.ToString();
        ActiveBase.UpdateParameters["Date"].DefaultValue = now;
    }


    protected void DetailsView2_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        if(e.Exception != null)
        {
            entryError.Visible = true;
            e.ExceptionHandled = true;
        }
    }

    protected void add_Click(object sender, EventArgs e)
    {
        DetailsView2.ChangeMode(DetailsViewMode.Insert);
        entryError.Visible = false;
    }

    protected void home_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

}