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
    public partial class InitForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDatabaseConnectionString1"].ConnectionString); 

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }
     
        protected void logButton_Click(object sender, EventArgs e)
        {
            if(GroupList.SelectedItem.Text=="Science") 
            {
                Session["HSCRoll"] = HSCRollTextBox.Text;
                Session["SSCRoll"] = SSCRollTextBox.Text;
                Session["Board"] = BoardList.SelectedItem.ToString();
                Session["Session"] = SessionList.SelectedItem.ToString();

                String selectString = "select candidateName,Bangla,English,Physics,Chemistry,Math,Biology,ComputerScience,Statist,Agriculture,GPA,SSCEnglish,SSCGPA from scienceTable where HSCRoll='" + HSCRollTextBox.Text + "' and SSCRoll='" + SSCRollTextBox.Text + "' and Board='" + BoardList.SelectedItem.ToString() + "' and Session='" + SessionList.SelectedItem.ToString() + "'";
                SqlCommand commandObj = new SqlCommand(selectString, con);
                SqlDataReader reader = commandObj.ExecuteReader();

                if (reader.Read())
                {
                    Session["candidateName"] = reader[0].ToString();
                    Session["Bangla"] = reader[1].ToString();
                    Session["English"] = reader[2].ToString();
                    Session["Physics"] = reader[3].ToString();
                    Session["Chemistry"] = reader[4].ToString();
                    Session["Mathmatics"] = reader[5].ToString();
                    Session["Biology"] = reader[6].ToString();
                    Session["CS"] = reader[7].ToString();
                    Session["Statist"] = reader[8].ToString();
                    Session["Agriculture"] = reader[9].ToString();
                    Session["GPA"] = reader[10].ToString();
                    Session["SSCEnglish"] = reader[11].ToString();
                    Session["SSCGPA"] = reader[12].ToString(); 

                    Response.Redirect("ScienceForm.aspx");
                }
                else {
                   
                    Response.Write("<script>alert('Sorry ,Entry is not found');</script>");
                    
                }

               
            }
            else if (GroupList.SelectedItem.Text == "Commerce")
            {
                Session["HSCRoll"] = HSCRollTextBox.Text;
                Session["SSCRoll"] = SSCRollTextBox.Text;
                Session["Board"] = BoardList.SelectedItem.ToString();
                Session["Session"] = SessionList.SelectedItem.ToString();

                String selectString = "select candidateName,Bangla,English,Accounting,Finance,Management,ComputerScience,Agriculture,Economics,Math,GPA,SSCEnglish,SSCGPA from commerceTable where HSCRoll='" + HSCRollTextBox.Text + "' and SSCRoll='" + SSCRollTextBox.Text + "' and Board='" + BoardList.SelectedItem.ToString() + "' and Session='" + SessionList.SelectedItem.ToString() + "'";
                SqlCommand commandObj = new SqlCommand(selectString, con);
                SqlDataReader reader = commandObj.ExecuteReader();

                if (reader.Read())
                {
                    Session["candidateName"] = reader[0].ToString();
                    Session["Bangla"] = reader[1].ToString();
                    Session["English"] = reader[2].ToString();
                    Session["Accounting"] = reader[3].ToString();
                    Session["Finance"] = reader[4].ToString();
                    Session["Management"] = reader[5].ToString();
                    Session["CS"] = reader[6].ToString();
                    Session["Agriculture"] = reader[7].ToString();
                    Session["Economics"] = reader[8].ToString();
                    Session["Mathmatics"] = reader[9].ToString();
                    Session["GPA"] = reader[10].ToString();
                    Session["SSCEnglish"] = reader[11].ToString();
                    Session["SSCGPA"] = reader[12].ToString(); 
                   
                    Response.Redirect("CommerceForm.aspx");
                }
                else
                {
                  
                    Response.Write("<script>alert('Sorry ,Entry is not found');</script>");

                }

               
            }
            else if (GroupList.SelectedItem.Text == "Huminities")
            {
                Session["HSCRoll"] = HSCRollTextBox.Text;
                Session["SSCRoll"] = SSCRollTextBox.Text;
                Session["Board"] = BoardList.SelectedItem.ToString();
                Session["Session"] = SessionList.SelectedItem.ToString();

                String selectString = "select candidateName,Bangla,English,Economics,Civics,Psycology,ComputerScience,Math,Statist,GPA,SSCEnglish,SSCGPA from artsTable  where HSCRoll='" + HSCRollTextBox.Text + "' and SSCRoll='" + SSCRollTextBox.Text + "' and Board='" + BoardList.SelectedItem.ToString() + "' and Session='" + SessionList.SelectedItem.ToString() + "'";
                SqlCommand commandObj = new SqlCommand(selectString, con);
                SqlDataReader reader = commandObj.ExecuteReader();

                if (reader.Read())
                {
                    Session["candidateName"] = reader[0].ToString();
                    Session["Bangla"] = reader[1].ToString();
                    Session["English"] = reader[2].ToString();
                    Session["Economics"] = reader[3].ToString();
                    Session["Civics"] = reader[4].ToString();
                    Session["Psycology"] = reader[5].ToString();
                    Session["CS"] = reader[6].ToString();
                    Session["Mathmatics"] = reader[7].ToString();
                    Session["Statistics"] = reader[8].ToString();
                    Session["GPA"] = reader[9].ToString();
                    Session["SSCEnglish"] = reader[10].ToString();
                    Session["SSCGPA"] = reader[11].ToString(); 

                    Response.Redirect("ArtsForm.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Sorry ,Entry is not found');</script>");
                }


               
            }
        }

    }
}