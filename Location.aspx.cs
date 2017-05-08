using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Location : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["findUserTB"] == "" || Request.Form["addUserTB"] == "")
        {
            Response.Write("Error: Username is empty");
            Response.End();
        }
        else if (Request.Form["locationTB"] == "")
        {
            Response.Write("Error: Location is empty");
            Response.End();
        }
        else if ((Request.QueryString["findUserTB"] != null && Request.QueryString["findUserTB"].Length > 255) || (Request.Form["addUserTB"] != null && Request.Form["addUserTB"].Length > 255))
        {
            Response.Write("Error: Username is longer than 255 characters");
            Response.End();
        }
        else if (Request.Form["locationTB"] != null && Request.Form["locationTB"].Length > 255)
        {
            Response.Write("Error: Location is longer than 255 characters");
            Response.End();
        }
        else if (Request.QueryString["findUserTB"] != null)
        {
            getRecord(Request.QueryString["findUserTB"].ToString());
        }
        else if (Request.Form["addUserTB"] != null && Request.Form["locationTB"] != null)
        {
            editRecord(Request.Form["addUserTB"].ToString(), Request.Form["locationTB"].ToString());
        }
        else
        {
            Response.Write("Error: Unknown Request");
            Response.End();
        }
    }

    protected void getRecord(string name)
    {
        string s = search(name);
        if (s == null)
        {
            Response.Write("Error: Username not found");
        }
        else
        {
            Response.Write(s);
        }
        Response.End();
    }

    protected string search(string name)
    {
        string output;
        SqlConnection con = new SqlConnection(SqlDataSource1.ConnectionString);
        con.Open();
        string s = "SELECT Username, Location, Date FROM StaffDetails WHERE UserName = @u";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@u", name);
        SqlDataReader r = cmd.ExecuteReader();
        if (r.HasRows)
        {
            r.Read();
            output = r["Location"].ToString();
        }
        else
        {
            output = null;
        }
        con.Close();
        return output;
    }

    protected void editRecord(string name, string loc)
    {
        DateTime now = System.DateTime.Now;
        SqlConnection con = new SqlConnection(SqlDataSource1.ConnectionString);
        con.Open();
        string s;
        if (search(name) == null)
        {
            s = "INSERT INTO StaffDetails (Username, Location, Date) VALUES (@u, @l, @d)";
        }
        else
        {
            s = "UPDATE StaffDetails SET Location = @l, Date = @d WHERE UserName = @u";
        }
        string s2 = "INSERT INTO Locations (UserName, Location, Date) VALUES (@u, @l, @d)";
        SqlCommand cmd = new SqlCommand(s, con);
        SqlCommand cmd2 = new SqlCommand(s2, con);
        cmd.Parameters.AddWithValue("@l", loc);
        cmd.Parameters.AddWithValue("@d", now.ToString());
        cmd.Parameters.AddWithValue("@u", name);
        cmd2.Parameters.AddWithValue("@u", name);
        cmd2.Parameters.AddWithValue("@l", loc);
        cmd2.Parameters.AddWithValue("@d", now.ToString());
        cmd.ExecuteNonQuery();
        cmd2.ExecuteNonQuery();
        con.Close();
        Response.End();
    }
}