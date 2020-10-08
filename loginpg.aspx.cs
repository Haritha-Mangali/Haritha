using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace billtrackerass
{
    public partial class loginpg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "You are the user.. Please Register..";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string q = "select *from loginpg where username='" + TextBox1.Text + "'and password=" + TextBox2.Text + "'";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=haritha;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Response.Redirect("generate.aspx");
            }
            else
            {
                Label1.Text = "You are not the user <br> Please register!!";
            }
        }
    }
}