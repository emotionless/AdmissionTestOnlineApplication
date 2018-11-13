using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdmissionWebApplication
{
    public partial class CommerceForm : System.Web.UI.Page
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
            AccountingTextBox.Text = Convert.ToString(Session["Accounting"]);
            FinanceTextBox.Text = Convert.ToString(Session["Finance"]);
            ManagementTextBox.Text = Convert.ToString(Session["Management"]);
            CSTextBox.Text = Convert.ToString(Session["CS"]);
            AgricultureTextBox.Text = Convert.ToString(Session["Agriculture"]);
            EconomicsTextBox.Text = Convert.ToString(Session["Economics"]);
            MathTextBox.Text = Convert.ToString(Session["Mathmatics"]); 
            GPATextBox.Text = Convert.ToString(Session["GPA"]);
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
            Session["Accounting"] = AccountingTextBox.Text;
            Session["Finance"] = FinanceTextBox.Text;
            Session["Management"] = ManagementTextBox.Text;
            Session["CS"] = CSTextBox.Text;
            Session["Agriculture"] = AgricultureTextBox.Text;
            Session["Economics"] = EconomicsTextBox.Text;
            Session["Mathmatics"] = MathTextBox.Text;
            Session["GPA"] = GPATextBox.Text;
            Session["SSCEnglish"] = SSCEnglishTextBox.Text;
            Session["SSCGPA"] = SSCResultTextBox.Text;

            Response.Redirect("UnitSelectionCommerceForm.aspx");
        }
    }
}