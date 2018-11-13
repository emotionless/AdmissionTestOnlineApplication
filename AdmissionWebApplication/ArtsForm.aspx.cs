using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdmissionWebApplication
{
    public partial class ArtsForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HSCRollTextBox.Text = Convert.ToString(Session["HSCRoll"]);
            SSCRollTextBox.Text = Convert.ToString(Session["SSCRoll"]);
            BoardTextBox.Text = Convert.ToString(Session["Board"]);
            SessionTextBox.Text = Convert.ToString(Session["Session"]);
            NameTextBox.Text = Convert.ToString(Session["candidateName"]);
            BanglaTextBox.Text = Convert.ToString(Session["Bangla"]);
            EnglishTextBox.Text = Convert.ToString(Session["English"]);
            EconomicsTextBox.Text = Convert.ToString(Session["Economics"]);
            CivisTextBox.Text = Convert.ToString(Session["Civics"]);
            PsycologyTextBox.Text = Convert.ToString(Session["Psycology"]);
            CSTextBox.Text = Convert.ToString(Session["CS"]);
            MathTextBox.Text = Convert.ToString(Session["Mathmatics"]);
            StatisticsTextBox.Text = Convert.ToString(Session["Statistics"]);
            GPATextBox.Text = Convert.ToString(Session["GPA"]);
            SSCEnglishTextBox.Text = Convert.ToString(Session["SSCEnglish"]);
            SSCResultTextBox.Text = Convert.ToString(Session["SSCGPA"]);

        }

      
        protected void backButton_Click1(object sender, EventArgs e)
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
            Session["Economics"] = EconomicsTextBox.Text;
            Session["Civics"] = CivisTextBox.Text;
            Session["Psycology"] = CSTextBox.Text;
            Session["CS"] = CSTextBox.Text;
            Session["Mathmatics"] = MathTextBox.Text;
            Session["Statistics"] = StatisticsTextBox.Text;
            Session["GPA"] = GPATextBox.Text;
            Session["SSCEnglish"] = SSCEnglishTextBox.Text;
            Session["SSCGPA"] = Convert.ToDouble(Session["SSCGPA"]);

            Response.Redirect("UnitSelectionArtsForm.aspx");
        }
    }
}