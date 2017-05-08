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
        searchDB();
    }

    protected void updateB_Click(object sender, EventArgs e)
    {
        DateTime now = System.DateTime.Now;
        SqlConnection con = new SqlConnection(SqlDataSource1.ConnectionString);
        con.Open();
        string s = "UPDATE StaffDetails SET Location = @l, Date = @d WHERE UserName = @u";
        string s2 = "INSERT INTO Locations (UserName, Location, Date) VALUES (@u, @l, @d)";
        SqlCommand cmd = new SqlCommand(s, con);
        SqlCommand cmd2 = new SqlCommand(s2, con);
        cmd.Parameters.AddWithValue("@l", locTB.Text.ToString());
        cmd.Parameters.AddWithValue("@d", now.ToString());
        cmd.Parameters.AddWithValue("@u", userTB.Text.ToString());
        cmd2.Parameters.AddWithValue("@u", userTB.Text.ToString());
        cmd2.Parameters.AddWithValue("@l", locTB.Text.ToString());
        cmd2.Parameters.AddWithValue("@d", now.ToString());
        cmd.ExecuteNonQuery();
        cmd2.ExecuteNonQuery();
        con.Close();
        searchDB();
    }

    protected void searchDB()
    {
        if (searchTB.Text.Length == 0)
        {
            errorL.Text = "Error: Please enter a username";
        }
        else if (searchTB.Text.Length > 50)
        {
            errorL.Text = "Error: Character length must be under 255";
        }
        else
        {
            SqlConnection con = new SqlConnection(SqlDataSource1.ConnectionString);
            con.Open();
            string s = "SELECT Username, Location, Date FROM StaffDetails WHERE UserName = " + searchTB.Text.ToString();
            SqlCommand cmd = new SqlCommand(s, con);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                r.Read();
                userTB.Text = r["UserName"].ToString();
                locTB.Text = r["Location"].ToString();
                dateTB.Text = r["Date"].ToString();
            }
            else
            {
                errorL.Text = "Error: Username Not Found";
            }
            con.Close();
        }
    }

    protected void homeB_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}