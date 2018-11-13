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
    public partial class ScienceForm : System.Web.UI.Page
    {
       
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDatabaseConnectionString1"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

            con.Open();

            HSCRollTextBox.Text = Convert.ToString(Session["HSCRoll"]);
            SSCRollTextBox.Text = Convert.ToString(Session["SSCRoll"]);
            NameTextBox.Text = Convert.ToString(Session["candidateName"]);
            BoardTextBox.Text = Convert.ToString(Session["Board"]);
            SessionTextBox.Text = Convert.ToString(Session["Session"]);
            BanglaTextBox.Text = Convert.ToString(Session["Bangla"]);
            EnglishTextBox.Text = Convert.ToString(Session["English"]);
            PhysicsTextBox.Text = Convert.ToString(Session["Physics"]);
            ChemistryTextBox.Text = Convert.ToString(Session["Chemistry"]);
            MathTextBox.Text = Convert.ToString(Session["Mathmatics"]);
            BiologyTextBox.Text = Convert.ToString(Session["Biology"]);
            CSTextBox.Text = Convert.ToString(Session["CS"]);
            StateTextBox.Text = Convert.ToString(Session["Statist"]);
            AgricultureTextBox.Text = Convert.ToString(Session["Agriculture"]);
            HSCResultTextBox.Text = Convert.ToString(Session["GPA"]);
            SSCEnglishTextBox.Text = Convert.ToString(Session["SSCEnglish"]);
            SSCResultTextBox.Text = Convert.ToString(Session["SSCGPA"]);

        } 

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("InitForm.aspx");
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            Session["HSCRoll"] = HSCRollTextBox.Text;
            Session["SSCRoll"] = SSCRollTextBox.Text;
            Session["candidateName"] = NameTextBox.Text;
            Session["Session"] = SessionTextBox.Text;
            Session["Board"] = BoardTextBox.Text;
            Session["Bangla"] = BanglaTextBox.Text;
            Session["English"] = EnglishTextBox.Text;
            Session["Physics"] = PhysicsTextBox.Text;
            Session["Chemistry"] = ChemistryTextBox.Text;
            Session["Mathmatics"] = MathTextBox.Text;
            Session["Biology"] = BiologyTextBox.Text;
            Session["CS"] = CSTextBox.Text;
            Session["Statist"] = StateTextBox.Text;
            Session["Agriculture"] = AgricultureTextBox.Text;
            Session["GPA"] = HSCResultTextBox.Text;
            Session["SSCEnglish"] = SSCEnglishTextBox.Text;
            Session["SSCGPA"] = SSCResultTextBox.Text;
            
            Response.Redirect("UnitSelectionScienceForm.aspx");
        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}