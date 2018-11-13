using System;
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
    public partial class selectDynamicUnit : System.Web.UI.Page
    {
       // Dictionary<string, Boolean> entities;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDatabaseConnectionString1"].ConnectionString);
       
        protected void Page_Load(object sender, EventArgs e)
        {

            con.Open();
            numberOfUnit.SelectedIndexChanged += new EventHandler(check_changed);
            numberOfUnit.TextChanged += new EventHandler(check_changed);

            // here is the false
            

            //Response.Write("<script>alert('" + UnitLabel0.ToString().Length + "');</script>");


         string first=Convert.ToString(Session["is_first"]);
            if(first.Equals("yes"))
            {
              Label0.Visible = false;
            //if (UnitLabel1.ToString().Length == 31)
                Label1.Visible = false;
            //if (UnitLabel2.ToString().Length == 31)
                Label2.Visible = false;
            //if (UnitLabel3.ToString().Length == 31)
                Label3.Visible = false;
            //if (UnitLabel4.ToString().Length == 0)
                Label4.Visible = false;
            //if (UnitLabel5.ToString().Length == 0)
                Label5.Visible = false;
            //if (UnitLabel6.ToString().Length == 0)
                Label6.Visible = false;
            //if (UnitLabel7.ToString().Length == 0)
                Label7.Visible = false;
            //if (UnitLabel8.ToString().Length == 0)
                Label8.Visible = false;
            //if (UnitLabel9.ToString().Length == 0)
                Label9.Visible = false;
            //if (UnitLabel10.ToString().Length == 0)
                Label10.Visible = false;
            //if (UnitLabel11.ToString().Length == 0)
                Label11.Visible = false;
            //if (UnitLabel12.ToString().Length == 0)
                Label12.Visible = false;
            //if (UnitLabel13.ToString().Length == 0)
                Label13.Visible = false;
            //if (UnitLabel14.ToString().Length == 0)
                Label14.Visible = false;
            //if (UnitLabel15.ToString().Length == 0)
                Label15.Visible = false;
            //if (UnitLabel16.ToString().Length == 0)
                Label16.Visible = false;
            //if (UnitLabel17.ToString().Length == 0)
                Label17.Visible = false;
            //if (UnitLabel18.ToString().Length == 0)
                Label18.Visible = false;
            //if (UnitLabel19.ToString().Length == 0)
                Label19.Visible = false;
            
        }
            
          }
        protected void loadForUnit(object sender, EventArgs e)
        {
          //  Response.Write("<script>alert('Sorry,you have not sufficient balance');</script>");
            
        }

        protected void check_changed(object sender, EventArgs e)
        {
            Session["is_first"] = "no";
            unit.Items.Clear();
            int i=0, tot=Convert.ToInt32(numberOfUnit.SelectedItem.ToString());
            for (i = 0; i < tot; i++)
            {
                char cc = (char)(65 + i);
                unit.Items.Add(cc.ToString());
                string v = "label" + i;
            }

            i = tot;
            if (i >0)
                Label0.Visible = true;
            else
                Label0.Visible = false;


            if (i > 1)
                Label1.Visible = true;
            else
                Label1.Visible = false;


            if (i > 2)
                Label2.Visible = true;
            else
                Label2.Visible = false;


            if (i > 3)
                Label3.Visible = true;
            else
                Label3.Visible = false;


            if (i > 4)
                Label4.Visible = true;
            else
                Label4.Visible = false;


            if (i > 5)
                Label5.Visible = true;
            else
                Label5.Visible = false;


            if (i >6)
                Label6.Visible = true;
            else
                Label6.Visible = false;


            if (i > 7)
                Label7.Visible = true;
            else
                Label7.Visible = false;


            if (i > 8)
                Label8.Visible = true;
            else
                Label8.Visible = false;


            if (i > 9)
                Label9.Visible = true;
            else
                Label9.Visible = false;


            if (i > 10)
                Label10.Visible = true;
            else
                Label10.Visible = false;


            if (i > 11)
                Label11.Visible = true;
            else
                Label11.Visible = false;


            if (i >12)
                Label12.Visible = true;
            else
                Label12.Visible = false;


            if (i > 13)
                Label13.Visible = true;
            else
                Label13.Visible = false;


            if (i >14)
                Label14.Visible = true;
            else
                Label14.Visible = false;


            if (i >15)
                Label15.Visible = true;
            else
                Label15.Visible = false;


            if (i >16)
                Label16.Visible = true;
            else
                Label16.Visible = false;


            if (i > 17)
                Label17.Visible = true;
            else
                Label17.Visible = false;


            if (i > 18)
                Label18.Visible = true;
            else
                Label18.Visible = false;


            if (i > 19)
                Label19.Visible = true;
            else
                Label19.Visible = false;

            /*

            if (i >= 20)
                Label20.Enabled = true;
            if (i >= 21)
                Label0.Enabled = true;
            if (i >= 21)
                Label21.Enabled = true;
            if (i >= 22)
                Label22.Enabled = true;
            if (i >= 23)
                Label0.Enabled = true;

            */



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ss = TextBox1.Text;
            //bool res = entities[ss];
            //if (res == true)
             //   Response.Write("<script>alert('Sorry,this subject has been added...');</script>");
            //else
            {
              //  entities.Add(ss, true);

                string tmp = TextBox1.Text;
                TextBox1.Text += ", ";
                if (unit.SelectedIndex == 0)
                {
                    UnitLabel0.Text += TextBox1.Text;
                    UnitLabel0.Visible = true;
                    Label0.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel0.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();

                }

                if (unit.SelectedIndex == 1)
                {
                    UnitLabel1.Text += TextBox1.Text;

                    UnitLabel1.Visible = true;
                    Label1.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel1.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();

                }

                if (unit.SelectedIndex == 2)
                {
                    UnitLabel2.Text += TextBox1.Text;
                    UnitLabel2.Visible = true;
                    Label2.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel2.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();

                }
                if (unit.SelectedIndex == 3)
                {
                    UnitLabel3.Text += TextBox1.Text;
                    UnitLabel3.Visible = true;
                    Label3.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel3.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();

                }
                if (unit.SelectedIndex == 4)
                {
                    UnitLabel4.Text += TextBox1.Text;
                    UnitLabel4.Visible = true;
                    Label4.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel4.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 5)
                {
                    UnitLabel5.Text += TextBox1.Text;
                    UnitLabel5.Visible = true;
                    Label5.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel5.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }

                if (unit.SelectedIndex == 6)
                {
                    UnitLabel6.Text += TextBox1.Text;
                    UnitLabel6.Visible = true;
                    Label6.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel6.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 7)
                {
                    UnitLabel7.Text += TextBox1.Text;
                    UnitLabel7.Visible = true;
                    Label7.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel7.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }

                if (unit.SelectedIndex == 8)
                {
                    UnitLabel8.Text += TextBox1.Text;
                    UnitLabel8.Visible = true;
                    Label8.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel8.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 9)
                {
                    UnitLabel9.Text += TextBox1.Text;
                    UnitLabel9.Visible = true;
                    Label9.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel9.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 10)
                {
                    UnitLabel10.Text += TextBox1.Text;
                    UnitLabel10.Visible = true;
                    Label10.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel10.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 11)
                {
                    UnitLabel11.Text += TextBox1.Text;
                    UnitLabel11.Visible = true;
                    Label11.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel11.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 12)
                {
                    UnitLabel12.Text += TextBox1.Text;
                    UnitLabel12.Visible = true;
                    UnitLabel12.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel12.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 13)
                {
                    UnitLabel13.Text += TextBox1.Text;
                    UnitLabel13.Visible = true;
                    Label13.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel13.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 14)
                {
                    UnitLabel14.Text += TextBox1.Text;
                    UnitLabel14.Visible = true;
                    Label14.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel14.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 15)
                {
                    UnitLabel15.Text += TextBox1.Text;
                    UnitLabel15.Visible = true;
                    Label15.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel15.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 16)
                {
                    UnitLabel16.Text += TextBox1.Text;
                    UnitLabel16.Visible = true;
                    Label16.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel16.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 17)
                {
                    UnitLabel17.Text += TextBox1.Text;
                    UnitLabel17.Visible = true;
                    Label17.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel17.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 18)
                {
                    UnitLabel18.Text += TextBox1.Text;
                    UnitLabel18.Visible = true;
                    Label18.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel18.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                if (unit.SelectedIndex == 19)
                {
                    UnitLabel19.Text += TextBox1.Text;
                    UnitLabel19.Visible = true;
                    Label19.Visible = true;
                    SqlCommand cmd = new SqlCommand("update unitTable set subject='" + UnitLabel19.Text + "' where unit='" + unit.SelectedItem + "'", con);
                    cmd.ExecuteNonQuery();
                }
                TextBox1.Text = tmp;
            }
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("see.aspx");
        }

    }
}