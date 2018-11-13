using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace AdmissionWebApplication
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDatabaseConnectionString1"].ConnectionString); 
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("select password from admin where password='"+passTextBox.Text.ToString()+"'", con);
            SqlDataReader reader = query.ExecuteReader();

            if (reader.Read())
            {
                string pass = reader[0].ToString();
                if (pass == passTextBox.Text.ToString())
                {
                    Session["is_first"] = "yes";
                    Response.Redirect("selectDynamicUnit.aspx");
                }
            }
            else
            {
                Response.Write("<script> alert('Password did not match. Try again...'); </script>");
            }

        }
    }
}