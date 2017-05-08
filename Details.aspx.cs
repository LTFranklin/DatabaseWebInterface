using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Details : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void search_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(SqlDataSource1.ConnectionString);
        con.Open();
        string s = "SELECT Username, FirstName, Surname FROM StaffDetails WHERE UserName = " + searchTB.Text.ToString();
        SqlCommand cmd = new SqlCommand(s, con);
        SqlDataReader r = cmd.ExecuteReader();
        if (r.HasRows)
        {
            r.Read();
            userTB.Text = r["UserName"].ToString();
            firstTB.Text = r["FirstName"].ToString();
            surTB.Text = r["Surname"].ToString();
        }
        else
        {
            errorL.Text = "Error: Username Not Found";
        }
    }

    protected void updateB_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(SqlDataSource1.ConnectionString);
        con.Open();
        string s = "UPDATE StaffDetails SET FirstName = @f, Surname = @s WHERE UserName = @u";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@f", firstTB.Text.ToString());
        cmd.Parameters.AddWithValue("@s", surTB.Text.ToString());
        cmd.Parameters.AddWithValue("@u", userTB.Text.ToString());
        cmd.ExecuteNonQuery();
        con.Close();
    }

    protected void addB_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(SqlDataSource1.ConnectionString);
        con.Open();
        string s = "INSERT INTO StaffDetails (UserName, FirstName, Surname) Values (@u, @f, @s)";
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.Parameters.AddWithValue("@u", userTB.Text.ToString());
        cmd.Parameters.AddWithValue("@f", firstTB.Text.ToString());
        cmd.Parameters.AddWithValue("@s", surTB.Text.ToString());
        try
        {
            cmd.ExecuteNonQuery();
        }
        catch(Exception exc)
        {
            errorL.Text = "Username already exists";
        }
        con.Close();
    }

    protected void homeB_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}