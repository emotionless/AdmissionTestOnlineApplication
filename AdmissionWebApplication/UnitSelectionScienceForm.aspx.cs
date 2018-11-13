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
    public partial class UnitSelectionScienceForm : System.Web.UI.Page
    {

        String subject;
        String state;
        String payment;
        String accountId;

        /*double minResult_forall = 4.00;
        double maxResult_forall = 5.00;
        double minResult_WithoutScience = 3.00;
        double maxResult_WithoutScience = 4.00;
        double minResult_WithoutScienceCommerce = 2.00;
        double maxResult_WithoutScienceCommerce = 3.00;
        double minResult_forall_todisqualify = 2.00;*/
       

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDatabaseConnectionString1"].ConnectionString);
       
   
        protected void insertData()
        {
            if (CSECheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','CSE','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
                
            }
            if (MathCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Math','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PhysicsCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Physics','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (StatisticsCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Statistics','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (ESCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','ES','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (GSCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','GS','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (ChemistryCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Chemistry','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (EconomicsCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Economics','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (URPCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','URP','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (AnthropologyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Anthropology','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (GeographyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Geography','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (GPCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','GP','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PACheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','PA','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (IRCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','IR','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (EnglishCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','English','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (HistoryCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','History','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PhilosophyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Philosophy','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (DramaCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Drama','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (ArchiologyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Archiology','YES')", con);
                cmd.ExecuteNonQuery();
                selection();

            }

            if (BanglaCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Bangla','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (JournalismCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Journalism','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (BotanyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Botany','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (ZoologyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Zoology','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PharmacyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Pharmacy','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (BiochemistryCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Biochemistry','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (MicrobiologyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Microbiology','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (GEBCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','GEB','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PBHCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','PBH','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (FBCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','FB','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (MarketingCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','MK','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (AISCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','AIS','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (MSCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','MS','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (IBACheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','IBA','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (LawCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','Law','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (IITCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Science','IIT','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

        }

        protected void insertMoney()
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            double cost = Convert.ToDouble(TotalTextBox.Text);
            double total = amount - cost;

            String selectString = "update accountTable set Amount='"+total+"' where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "'";
            SqlCommand cmd = new SqlCommand(selectString, con);
            cmd.ExecuteNonQuery();

        }

        protected void selection()
        {
            String selectString = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='CSE'";
            SqlCommand commandObj = new SqlCommand(selectString, con);
            SqlDataReader reader = commandObj.ExecuteReader();

            if (reader.Read())
            {
                subject = reader[0].ToString();
                state = reader[1].ToString();
                if (state.Equals("YES") && subject.Equals("CSE"))
                {
                    CSECheckBox.Enabled = false;
                    CSECheckBox.Checked = false;
                    CSETextBox.Text = "0";
                    CSECheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    CSECheckBox.Font.Bold = true;
                } 
               

            }

            reader.Close();

            String selectString1 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Math'";
            SqlCommand commandObj1 = new SqlCommand(selectString1, con);
            SqlDataReader reader1 = commandObj1.ExecuteReader();

            if (reader1.Read())
            {
                subject = reader1[0].ToString();
                state = reader1[1].ToString();
                if (state.Equals("YES") && subject.Equals("Math"))
                {
                    MathCheckBox.Enabled = false;
                    MathCheckBox.Checked = false;
                    MathTextBox.Text = "0";
                    MathCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    MathCheckBox.Font.Bold = true;
                } 
               

            }

            reader1.Close();

            String selectString2 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Physics'";
            SqlCommand commandObj2 = new SqlCommand(selectString2, con);
            SqlDataReader reader2 = commandObj2.ExecuteReader();

            if (reader2.Read())
            {
                subject = reader2[0].ToString();
                state = reader2[1].ToString();
                if (state.Equals("YES") && subject.Equals("Physics"))
                {
                    PhysicsCheckBox.Enabled = false;
                    PhysicsCheckBox.Checked = false;
                    PhysicsTextBox.Text = "0";
                    PhysicsCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    PhysicsCheckBox.Font.Bold = true;
                } 
               
            }

            reader2.Close();

            String selectString3 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Statistics'";
            SqlCommand commandObj3 = new SqlCommand(selectString3, con);
            SqlDataReader reader3 = commandObj3.ExecuteReader();

            if (reader3.Read())
            {
                subject = reader3[0].ToString();
                state = reader3[1].ToString();
                if (state.Equals("YES") && subject.Equals("Statistics"))
                {
                    StatisticsCheckBox.Enabled = false;
                    StatisticsCheckBox.Checked = false;
                    StatisticsTextBox.Text = "0";
                    StatisticsCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    StatisticsCheckBox.Font.Bold = true;
                }

            }

            reader3.Close();

            String selectString4 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='ES'";
            SqlCommand commandObj4 = new SqlCommand(selectString4, con);
            SqlDataReader reader4 = commandObj4.ExecuteReader();

            if (reader4.Read())
            {
                subject = reader4[0].ToString();
                state = reader4[1].ToString();
                if (state.Equals("YES") && subject.Equals("ES"))
                {
                    ESCheckBox.Enabled = false;
                    ESCheckBox.Checked = false;
                    ESTextBox.Text = "0";
                    ESCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    ESCheckBox.Font.Bold = true;
                }

            }

            reader4.Close();
            /// for GS

            String selectString5 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='GS'";
            SqlCommand commandObj5 = new SqlCommand(selectString5, con);
            SqlDataReader reader5 = commandObj5.ExecuteReader();

            if (reader5.Read())
            {
                subject = reader5[0].ToString();
                state = reader5[1].ToString();
                if (state.Equals("YES") && subject.Equals("GS"))
                {
                    GSCheckBox.Enabled = false;
                    GSCheckBox.Checked = false;
                    GSTextBox.Text = "0";
                    GSCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    GSCheckBox.Font.Bold = true;
                }

            }

            reader5.Close();

            /// for chemistry 
            
            String selectString6 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Chemistry'";
            SqlCommand commandObj6 = new SqlCommand(selectString6, con);
            SqlDataReader reader6 = commandObj6.ExecuteReader();

            if (reader6.Read())
            {
                subject = reader6[0].ToString();
                state = reader6[1].ToString();
                if (state.Equals("YES") && subject.Equals("Chemistry"))
                {
                    ChemistryCheckBox.Enabled = false;
                    ChemistryCheckBox.Checked = false;
                    ChemistryTextBox.Text = "0";
                    ChemistryCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    ChemistryCheckBox.Font.Bold = true;
                }

            }

            reader6.Close();

            /// for Economics 
            
            String selectString7 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Economics'";
            SqlCommand commandObj7 = new SqlCommand(selectString7, con);
            SqlDataReader reader7 = commandObj7.ExecuteReader();

            if (reader7.Read())
            {
                subject = reader7[0].ToString();
                state = reader7[1].ToString();
                if (state.Equals("YES") && subject.Equals("Economics"))
                {
                    EconomicsCheckBox.Enabled = false;
                    EconomicsCheckBox.Checked = false;
                    EconomicsTextBox.Text = "0";
                    EconomicsCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    EconomicsCheckBox.Font.Bold = true;
                }

            }

            reader7.Close();


            /// for URP 
            
            String selectString8 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='URP'";
            SqlCommand commandObj8 = new SqlCommand(selectString8, con);
            SqlDataReader reader8 = commandObj8.ExecuteReader();

            if (reader8.Read())
            {
                subject = reader8[0].ToString();
                state = reader8[1].ToString();
                if (state.Equals("YES") && subject.Equals("URP"))
                {
                    URPCheckBox.Enabled = false;
                    URPCheckBox.Checked = false;
                    URPTextBox.Text = "0";
                    URPCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    URPCheckBox.Font.Bold = true;
                }

            }

            reader8.Close();


            /// for Anthropology
            String selectString9 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Anthropology'";
            SqlCommand commandObj9 = new SqlCommand(selectString9, con);
            SqlDataReader reader9 = commandObj9.ExecuteReader();

            if (reader9.Read())
            {
                subject = reader9[0].ToString();
                state = reader9[1].ToString();
                if (state.Equals("YES") && subject.Equals("Anthropology"))
                {
                    AnthropologyCheckBox.Enabled = false;
                    AnthropologyCheckBox.Checked = false;
                    AnthropologyTextBox.Text = "0";
                    AnthropologyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    AnthropologyCheckBox.Font.Bold = true;
                }

            }

            reader9.Close();


            /// for Geography
            String selectString10 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Geography'";
            SqlCommand commandObj10 = new SqlCommand(selectString10, con);
            SqlDataReader reader10 = commandObj10.ExecuteReader();

            if (reader10.Read())
            {
                subject = reader10[0].ToString();
                state = reader10[1].ToString();
                if (state.Equals("YES") && subject.Equals("Geography"))
                {
                    GeographyCheckBox.Enabled = false;
                    GeographyCheckBox.Checked = false;
                    GeographyTextBox.Text = "0";
                    GeographyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    GeographyCheckBox.Font.Bold = true;
                }

            }

            reader10.Close();


            /// for GP
            String selectString11 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='GP'";
            SqlCommand commandObj11 = new SqlCommand(selectString11, con);
            SqlDataReader reader11 = commandObj11.ExecuteReader();

            if (reader11.Read())
            {
                subject = reader11[0].ToString();
                state = reader11[1].ToString();
                if (state.Equals("YES") && subject.Equals("GP"))
                {
                    GPCheckBox.Enabled = false;
                    GPCheckBox.Checked = false;
                    GPTextBox.Text = "0";
                    GPCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    GPCheckBox.Font.Bold = true;
                }

            }

            reader11.Close();

            /// for PA
            String selectString12 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='PA'";
            SqlCommand commandObj12 = new SqlCommand(selectString12, con);
            SqlDataReader reader12 = commandObj12.ExecuteReader();

            if (reader12.Read())
            {
                subject = reader12[0].ToString();
                state = reader12[1].ToString();
                if (state.Equals("YES") && subject.Equals("PA"))
                {
                    PACheckBox.Enabled = false;
                    PACheckBox.Checked = false;
                    PATextBox.Text = "0";
                    PACheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    PACheckBox.Font.Bold = true;
                }

            }

            reader12.Close();

            /// for IR
            String selectString13 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='IR'";
            SqlCommand commandObj13 = new SqlCommand(selectString13, con);
            SqlDataReader reader13 = commandObj13.ExecuteReader();

            if (reader13.Read())
            {
                subject = reader13[0].ToString();
                state = reader13[1].ToString();
                if (state.Equals("YES") && subject.Equals("IR"))
                {
                    IRCheckBox.Enabled = false;
                    IRCheckBox.Checked = false;
                    IRTextBox.Text = "0";
                    IRCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    IRCheckBox.Font.Bold = true;
                }

            }

            reader13.Close();

            /// for English
            String selectString14 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='English'";
            SqlCommand commandObj14 = new SqlCommand(selectString14, con);
            SqlDataReader reader14 = commandObj14.ExecuteReader();

            if (reader14.Read())
            {
                subject = reader14[0].ToString();
                state = reader14[1].ToString();
                if (state.Equals("YES") && subject.Equals("English"))
                {
                    EnglishCheckBox.Enabled = false;
                    EnglishCheckBox.Checked = false;
                    EnglishTextBox.Text = "0";
                    EnglishCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    EnglishCheckBox.Font.Bold = true;
                }

            }

            reader14.Close();

            /// for History
            String selectString15 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='History'";
            SqlCommand commandObj15 = new SqlCommand(selectString15, con);
            SqlDataReader reader15 = commandObj15.ExecuteReader();

            if (reader15.Read())
            {
                subject = reader15[0].ToString();
                state = reader15[1].ToString();
                if (state.Equals("YES") && subject.Equals("History"))
                {
                    HistoryCheckBox.Enabled = false;
                    HistoryCheckBox.Checked = false;
                    HistoryTextBox.Text = "0";
                    HistoryCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    HistoryCheckBox.Font.Bold = true;
                }

            }

            reader15.Close();


            /// for Philosophy
            String selectString16 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Philosophy'";
            SqlCommand commandObj16 = new SqlCommand(selectString16, con);
            SqlDataReader reader16 = commandObj16.ExecuteReader();

            if (reader16.Read())
            {
                subject = reader16[0].ToString();
                state = reader16[1].ToString();
                if (state.Equals("YES") && subject.Equals("Philosophy"))
                {
                    PhilosophyCheckBox.Enabled = false;
                    PhilosophyCheckBox.Checked = false;
                    PhilosophyTextBox.Text = "0";
                    PhilosophyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    PhilosophyCheckBox.Font.Bold = true;
                }

            }

            reader16.Close();

            /// for Drama
            String selectString17 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Drama'";
            SqlCommand commandObj17 = new SqlCommand(selectString17, con);
            SqlDataReader reader17 = commandObj17.ExecuteReader();

            if (reader17.Read())
            {
                subject = reader17[0].ToString();
                state = reader17[1].ToString();
                if (state.Equals("YES") && subject.Equals("Drama"))
                {
                    DramaCheckBox.Enabled = false;
                    DramaCheckBox.Checked = false;
                    DramaTextBox.Text = "0";
                    DramaCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    DramaCheckBox.Font.Bold = true;
                }

            }

            reader17.Close();

            /// for Archiology
            String selectString18 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Archiology'";
            SqlCommand commandObj18 = new SqlCommand(selectString18, con);
            SqlDataReader reader18 = commandObj18.ExecuteReader();

            if (reader18.Read())
            {
                subject = reader18[0].ToString();
                state = reader18[1].ToString();
                if (state.Equals("YES") && subject.Equals("Archiology"))
                {
                    ArchiologyCheckBox.Enabled = false;
                    ArchiologyCheckBox.Checked = false;
                    ArchiologyTextBox.Text = "0";
                    ArchiologyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    ArchiologyCheckBox.Font.Bold = true;
                }

            }

            reader18.Close();

            /// for Bangla
            String selectString19 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Bangla'";
            SqlCommand commandObj19 = new SqlCommand(selectString19, con);
            SqlDataReader reader19 = commandObj19.ExecuteReader();

            if (reader19.Read())
            {
                subject = reader19[0].ToString();
                state = reader19[1].ToString();
                if (state.Equals("YES") && subject.Equals("Bangla"))
                {
                    BanglaCheckBox.Enabled = false;
                    BanglaCheckBox.Checked = false;
                    BanglaTextBox.Text = "0";
                    BanglaCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    BanglaCheckBox.Font.Bold = true;
                }

            }

            reader19.Close();

            /// for Journalism
            String selectString20 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Journalism'";
            SqlCommand commandObj20 = new SqlCommand(selectString20, con);
            SqlDataReader reader20 = commandObj20.ExecuteReader();

            if (reader20.Read())
            {
                subject = reader20[0].ToString();
                state = reader20[1].ToString();
                if (state.Equals("YES") && subject.Equals("Journalism"))
                {
                    JournalismCheckBox.Enabled = false;
                    JournalismCheckBox.Checked = false;
                    JournalismTextBox.Text = "0";
                    JournalismCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    JournalismCheckBox.Font.Bold = true;
                }

            }

            reader20.Close();

            /// for Botany
            String selectString21 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Botany'";
            SqlCommand commandObj21 = new SqlCommand(selectString21, con);
            SqlDataReader reader21 = commandObj21.ExecuteReader();

            if (reader21.Read())
            {
                subject = reader21[0].ToString();
                state = reader21[1].ToString();
                if (state.Equals("YES") && subject.Equals("Botany"))
                {
                    BotanyCheckBox.Enabled = false;
                    BotanyCheckBox.Checked = false;
                    BotanyTextBox.Text = "0";
                    BotanyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    BotanyCheckBox.Font.Bold = true;
                }

            }

            reader21.Close();

            /// for Zoology
            String selectString22 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Zoology'";
            SqlCommand commandObj22 = new SqlCommand(selectString22, con);
            SqlDataReader reader22 = commandObj22.ExecuteReader();

            if (reader22.Read())
            {
                subject = reader22[0].ToString();
                state = reader22[1].ToString();
                if (state.Equals("YES") && subject.Equals("Zoology"))
                {
                    ZoologyCheckBox.Enabled = false;
                    ZoologyCheckBox.Checked = false;
                    ZoologyTextBox.Text = "0";
                    ZoologyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    ZoologyCheckBox.Font.Bold = true;
                }

            }

            reader22.Close();


            /// for Pharmacy
            String selectString23 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Pharmacy'";
            SqlCommand commandObj23 = new SqlCommand(selectString23, con);
            SqlDataReader reader23 = commandObj23.ExecuteReader();

            if (reader23.Read())
            {
                subject = reader23[0].ToString();
                state = reader23[1].ToString();
                if (state.Equals("YES") && subject.Equals("Pharmacy"))
                {
                    PharmacyCheckBox.Enabled = false;
                    PharmacyCheckBox.Checked = false;
                    PharmacyTextBox.Text = "0";
                    PharmacyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    PharmacyCheckBox.Font.Bold = true;
                }

            }

            reader23.Close();

            /// for Biochemistry
            String selectString24 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Biochemistry'";
            SqlCommand commandObj24 = new SqlCommand(selectString24, con);
            SqlDataReader reader24 = commandObj24.ExecuteReader();

            if (reader24.Read())
            {
                subject = reader24[0].ToString();
                state = reader24[1].ToString();
                if (state.Equals("YES") && subject.Equals("Biochemistry"))
                {
                    BiochemistryCheckBox.Enabled = false;
                    BiochemistryCheckBox.Checked = false;
                    BiochemistryTextBox.Text = "0";
                    BiochemistryCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    BiochemistryCheckBox.Font.Bold = true;
                }

            }

            reader24.Close();

            /// for GEB
            String selectString25 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='GEB'";
            SqlCommand commandObj25 = new SqlCommand(selectString25, con);
            SqlDataReader reader25 = commandObj25.ExecuteReader();

            if (reader25.Read())
            {
                subject = reader25[0].ToString();
                state = reader25[1].ToString();
                if (state.Equals("YES") && subject.Equals("GEB"))
                {
                    GEBCheckBox.Enabled = false;
                    GEBCheckBox.Checked = false;
                    GEBTextBox.Text = "0";
                    GEBCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    GEBCheckBox.Font.Bold = true;
                }

            }

            reader25.Close();

            /// for PBH
            String selectString26 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='PBH'";
            SqlCommand commandObj26 = new SqlCommand(selectString26, con);
            SqlDataReader reader26 = commandObj26.ExecuteReader();

            if (reader26.Read())
            {
                subject = reader26[0].ToString();
                state = reader26[1].ToString();
                if (state.Equals("YES") && subject.Equals("PBH"))
                {
                    PBHCheckBox.Enabled = false;
                    PBHCheckBox.Checked = false;
                    PBHTextBox.Text = "0";
                    PBHCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    PBHCheckBox.Font.Bold = true;
                }

            }

            reader26.Close();

            /// for Microbiology
            String selectString27 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Microbiology'";
            SqlCommand commandObj27 = new SqlCommand(selectString27, con);
            SqlDataReader reader27 = commandObj27.ExecuteReader();

            if (reader27.Read())
            {
                subject = reader27[0].ToString();
                state = reader27[1].ToString();
                if (state.Equals("YES") && subject.Equals("Microbiology"))
                {
                    MicrobiologyCheckBox.Enabled = false;
                    MicrobiologyCheckBox.Checked = false;
                    MicrobiologyTextBox.Text = "0";
                    MicrobiologyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    MicrobiologyCheckBox.Font.Bold = true;
                }

            }

            reader27.Close();

            /// for FB
            String selectString28 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='FB'";
            SqlCommand commandObj28 = new SqlCommand(selectString28, con);
            SqlDataReader reader28 = commandObj28.ExecuteReader();

            if (reader28.Read())
            {
                subject = reader28[0].ToString();
                state = reader28[1].ToString();
                if (state.Equals("YES") && subject.Equals("FB"))
                {
                    FBCheckBox.Enabled = false;
                    FBCheckBox.Checked = false;
                    FBTextBox.Text = "0";
                    FBCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    FBCheckBox.Font.Bold = true;
                }

            }

            reader28.Close();

            /// for Marketing
            String selectString29 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='MK'";
            SqlCommand commandObj29 = new SqlCommand(selectString29, con);
            SqlDataReader reader29 = commandObj29.ExecuteReader();

            if (reader29.Read())
            {
                subject = reader29[0].ToString();
                state = reader29[1].ToString();
                if (state.Equals("YES") && subject.Equals("MK"))
                {
                    MarketingCheckBox.Enabled = false;
                    MarketingCheckBox.Checked = false;
                    MarketingTextBox.Text = "0";
                    MarketingCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    MarketingCheckBox.Font.Bold = true;
                }

            }

            reader29.Close();

            /// for AIS
            String selectString30 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='AIS'";
            SqlCommand commandObj30 = new SqlCommand(selectString30, con);
            SqlDataReader reader30 = commandObj30.ExecuteReader();

            if (reader30.Read())
            {
                subject = reader30[0].ToString();
                state = reader30[1].ToString();
                if (state.Equals("YES") && subject.Equals("AIS"))
                {
                    AISCheckBox.Enabled = false;
                    AISCheckBox.Checked = false;
                    AISTextBox.Text = "0";
                    AISCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    AISCheckBox.Font.Bold = true;
                }

            }

            reader30.Close();

            /// for MS
            String selectString31 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='MS'";
            SqlCommand commandObj31 = new SqlCommand(selectString31, con);
            SqlDataReader reader31 = commandObj31.ExecuteReader();

            if (reader31.Read())
            {
                subject = reader31[0].ToString();
                state = reader31[1].ToString();
                if (state.Equals("YES") && subject.Equals("MS"))
                {
                    MSCheckBox.Enabled = false;
                    MSCheckBox.Checked = false;
                    MSTextBox.Text = "0";
                    MSCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    MSCheckBox.Font.Bold = true;
                }

            }

            reader31.Close();

            /// for IBA
            String selectString32 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='IBA'";
            SqlCommand commandObj32 = new SqlCommand(selectString32, con);
            SqlDataReader reader32 = commandObj32.ExecuteReader();

            if (reader32.Read())
            {
                subject = reader32[0].ToString();
                state = reader32[1].ToString();
                if (state.Equals("YES") && subject.Equals("IBA"))
                {
                    IBACheckBox.Enabled = false;
                    IBACheckBox.Checked = false;
                    IBATextBox.Text = "0";
                    IBACheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    IBACheckBox.Font.Bold = true;
                }

            }

            reader32.Close();

            /// for Law
            String selectString33 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Law'";
            SqlCommand commandObj33 = new SqlCommand(selectString33, con);
            SqlDataReader reader33 = commandObj33.ExecuteReader();

            if (reader33.Read())
            {
                subject = reader33[0].ToString();
                state = reader33[1].ToString();
                if (state.Equals("YES") && subject.Equals("Law"))
                {
                    LawCheckBox.Enabled = false;
                    LawCheckBox.Checked = false;
                    LawTextBox.Text = "0";
                    LawCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    LawCheckBox.Font.Bold = true;
                }

            }

            reader33.Close();

            /// for IIT
            String selectString34 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='IIT'";
            SqlCommand commandObj34 = new SqlCommand(selectString34, con);
            SqlDataReader reader34 = commandObj34.ExecuteReader();

            if (reader34.Read())
            {
                subject = reader34[0].ToString();
                state = reader34[1].ToString();
                if (state.Equals("YES") && subject.Equals("IIT"))
                {
                    IITCheckBox.Enabled = false;
                    IITCheckBox.Checked = false;
                    IITTextBox.Text = "0";
                    IITCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    IITCheckBox.Font.Bold = true;
                }

            }

            reader34.Close();
        }

        protected void accountCheck()
        {
            String selectString = "select AccountId,Amount from accountTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "'";
            SqlCommand commandObj = new SqlCommand(selectString, con);
            SqlDataReader accountreader = commandObj.ExecuteReader();

            if (accountreader.Read())
            {
                accountId = accountreader[0].ToString();
                payment = accountreader[1].ToString();
                amountTextBox.Text = payment;

            }

            accountreader.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            con.Open();

           

            double Bangla = Convert.ToDouble(Session["Bangla"]); ;
            double English = Convert.ToDouble(Session["English"]); 
            double Physics = Convert.ToDouble(Session["Physics"]); 
            double Chemistry = Convert.ToDouble(Session["Chemistry"]); 
            double Math = Convert.ToDouble(Session["Mathmatics"]);
            double Biology = Convert.ToDouble(Session["Biology"]);
            double CS = Convert.ToDouble(Session["CS"]);
            double Agriculture = Convert.ToDouble(Session["Agriculture"]);
            double Statistics = Convert.ToDouble(Session["Statist"]); 
            double SSCEnglish = Convert.ToDouble(Session["SSCEnglish"]);
            double SSCResult = Convert.ToDouble(Session["SSCGPA"]);
            double HSCResult = Convert.ToDouble(Session["GPA"]);
            double TotalResult = 0;

           

            selection();
            accountCheck();
           

            // For A Unit
           
            if(SSCResult >= 3.5 && HSCResult >= 3.5)
            {
                TotalResult = SSCResult + HSCResult;

                if(TotalResult< 8.50 || (SSCResult<4.00 || HSCResult<4.00) || Physics<4.00 || Math<4.00 || English<4.00)
                {
                    CSECheckBox.Enabled = false;
                    CSECheckBox.BackColor = System.Drawing.Color.Red;
                    CSECheckBox.Font.Bold = true;

                } 
                else if(TotalResult < 8.00 || HSCResult < 4.00 || Math<4.00)
                {
                    MathCheckBox.Enabled = false;
                    MathCheckBox.BackColor = System.Drawing.Color.Red;
                    MathCheckBox.Font.Bold = true;
                }
                else if(TotalResult<8.00 || Physics<4.00 || Math<4.00)
                {
                    PhysicsCheckBox.Enabled = false;
                    PhysicsCheckBox.BackColor = System.Drawing.Color.Red;
                    PhysicsCheckBox.Font.Bold = true;
                }
                else if(TotalResult<8.00 || Chemistry<3.50 || Physics<3.50 || Math<3.50 || Biology<3.50)
                {
                    ESCheckBox.Enabled = false;
                    ESCheckBox.BackColor = System.Drawing.Color.Red;
                    ESCheckBox.Font.Bold = true;
                } 
                else if(TotalResult<7.50 || Math<3.00)
                {
                    StatisticsCheckBox.Enabled = false;
                    StatisticsCheckBox.BackColor = System.Drawing.Color.Red;
                    StatisticsCheckBox.Font.Bold = true;
                } 
                else if(TotalResult<8.00 || Math<3.50 || Physics<3.50 || Chemistry<3.50)
                {
                    GSCheckBox.Enabled = false;
                    GSCheckBox.BackColor = System.Drawing.Color.Red;
                    GSCheckBox.Font.Bold = true;
                }
                else if(TotalResult<8.00 || Chemistry<3.00 || Math<3.00)
                {
                    ChemistryCheckBox.Enabled = false;
                    ChemistryCheckBox.BackColor = System.Drawing.Color.Red;
                    ChemistryCheckBox.Font.Bold = true;
                } 

            } 
            else
            {
                Panel1.BackColor = System.Drawing.Color.Red;
                Panel1.Enabled = false;
            } 

            // B Unit

            if (SSCResult >= 3.5 && HSCResult >= 3.5)
            {
                TotalResult = SSCResult + HSCResult;

                if(TotalResult<7.50 || Bangla<3.00 || English<3.00 || Math<3.00)
                {
                    EconomicsCheckBox.Enabled = false;
                    EconomicsCheckBox.BackColor = System.Drawing.Color.Red;
                    EconomicsCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.50 || English < 4.00 || Math < 4.00)
                {
                    URPCheckBox.Enabled = false;
                    URPCheckBox.BackColor = System.Drawing.Color.Red;
                    URPCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50 || (Bangla <3.00 && English < 3.00))
                {
                    AnthropologyCheckBox.Enabled = false;
                    AnthropologyCheckBox.BackColor = System.Drawing.Color.Red;
                    AnthropologyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50 || (Bangla < 3.50 && English < 3.50))
                {
                    GPCheckBox.Enabled = false;
                    GPCheckBox.BackColor = System.Drawing.Color.Red;
                    GPCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50 || English < 4.00)
                {
                    PACheckBox.Enabled = false;
                    PACheckBox.BackColor = System.Drawing.Color.Red;
                    PACheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50 || (Bangla < 3.50 && English < 3.50))
                {
                    GeographyCheckBox.Enabled = false;
                    GeographyCheckBox.BackColor = System.Drawing.Color.Red;
                    GeographyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50 || English < 4.00)
                {
                    PACheckBox.Enabled = false;
                    PACheckBox.BackColor = System.Drawing.Color.Red;
                    PACheckBox.Font.Bold = true;
                } 
            }
            else 
            {
                 Panel2.BackColor = System.Drawing.Color.Red;
                 Panel2.Enabled = false;
            }
             
            //For C Unit 

            if (SSCResult >= 3.0 && HSCResult >= 3.0)
            {
                TotalResult = SSCResult + HSCResult;

               if (TotalResult < 8.00 || SSCEnglish < 4.00 || English < 4.00)
                {
                    IRCheckBox.Enabled = false;
                    IRCheckBox.BackColor = System.Drawing.Color.Red;
                    IRCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50 || SSCEnglish < 4.00 || English < 4.00)
                {
                    EnglishCheckBox.Enabled = false;
                    EnglishCheckBox.BackColor = System.Drawing.Color.Red;
                    EnglishCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50 || English < 3.50 || Bangla < 4.00)
                {
                    HistoryCheckBox.Enabled = false;
                    HistoryCheckBox.BackColor = System.Drawing.Color.Red;
                    HistoryCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00)
                {
                    PhilosophyCheckBox.Enabled = false;
                    PhilosophyCheckBox.BackColor = System.Drawing.Color.Red;
                    PhilosophyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 6.50 || (Bangla<3.5 && English<3.5 && Physics < 3.5 && Chemistry < 3.5 && Math < 3.5 && Biology < 3.5 && CS < 3.5 && Agriculture < 3.5 && Statistics < 3.5))
                {
                    DramaCheckBox.Enabled = false;
                    DramaCheckBox.BackColor = System.Drawing.Color.Red;
                    DramaCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00)
                {
                    ArchiologyCheckBox.Enabled = false;
                    ArchiologyCheckBox.BackColor = System.Drawing.Color.Red;
                    ArchiologyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50)
                {
                    BanglaCheckBox.Enabled = false;
                    BanglaCheckBox.BackColor = System.Drawing.Color.Red;
                    BanglaCheckBox.Font.Bold = true;
                } 
                else if (TotalResult < 8.00)
                {
                    JournalismCheckBox.Enabled = false;
                    JournalismCheckBox.BackColor = System.Drawing.Color.Red;
                    JournalismCheckBox.Font.Bold = true;
                }
            }
            else 
            {
                 Panel3.BackColor = System.Drawing.Color.Red;
                 Panel3.Enabled = false;
            }


            //For D Unit 

            if (SSCResult >= 3.5 && HSCResult >= 3.5)
            {
                TotalResult = SSCResult + HSCResult;

                if (TotalResult < 7.50 || (Biology < 4.00 && Agriculture<4.00))
                {
                    BotanyCheckBox.Enabled = false;
                    BotanyCheckBox.BackColor = System.Drawing.Color.Red;
                    BotanyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.50 || (Biology < 3.50 && Agriculture < 3.50))
                {
                    ZoologyCheckBox.Enabled = false;
                    ZoologyCheckBox.BackColor = System.Drawing.Color.Red;
                    ZoologyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.00 )
                {
                    BiochemistryCheckBox.Enabled = false;
                    BiochemistryCheckBox.BackColor = System.Drawing.Color.Red;
                    BiochemistryCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.50 || Chemistry < 4.00 || Biology<3.50 && (Math < 3.50 && Statistics <3.50 && CS<3.50))
                {
                    PharmacyCheckBox.Enabled = false;
                    PharmacyCheckBox.BackColor = System.Drawing.Color.Red;
                    PharmacyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.50 || Chemistry < 3.50 || Biology < 3.50 )
                {
                    MicrobiologyCheckBox.Enabled = false;
                    MicrobiologyCheckBox.BackColor = System.Drawing.Color.Red;
                    MicrobiologyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.00 || Chemistry < 3.00 || Physics < 3.00 || Biology < 3.00)
                {
                    GEBCheckBox.Enabled = false;
                    GEBCheckBox.BackColor = System.Drawing.Color.Red;
                    GEBCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.50 || Chemistry < 3.50 || Biology<3.50 || Math < 1.00)
                {
                    PBHCheckBox.Enabled = false;
                    PBHCheckBox.BackColor = System.Drawing.Color.Red;
                    PBHCheckBox.Font.Bold = true;
                } 
            }
            else 
            {
                 Panel4.BackColor = System.Drawing.Color.Red;
                 Panel4.Enabled = false;
            }

            //For E Unit 

            if (SSCResult >= 3.5 && HSCResult >= 3.5)
            {
                TotalResult = SSCResult + HSCResult;

               if (TotalResult < 7.50 ||  Math < 3.00)
                {
                    FBCheckBox.Enabled = false;
                    FBCheckBox.BackColor = System.Drawing.Color.Red;
                    FBCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.00 || English < 3.50 || Math < 3.50)
                {
                    MarketingCheckBox.Enabled = false;
                    MarketingCheckBox.BackColor = System.Drawing.Color.Red;
                    MarketingCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.00 || English < 4.00 || SSCEnglish < 4.00)
                {
                    AISCheckBox.Enabled = false;
                    AISCheckBox.BackColor = System.Drawing.Color.Red;
                    AISCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 8.00 || Math < 3.00)
                {
                    MSCheckBox.Enabled = false;
                    MSCheckBox.BackColor = System.Drawing.Color.Red;
                    MSCheckBox.Font.Bold = true;
                } 

            }
            else 
            {
                 Panel5.BackColor = System.Drawing.Color.Red;
                 Panel5.Enabled = false;
            }


            //F Unit

            if (SSCResult >= 4.00 && HSCResult >= 4.00)
            {
                TotalResult = SSCResult + HSCResult;

                if (TotalResult < 8.50 || English < 3.50 || Math < 3.50)
                {
                    IBACheckBox.Enabled = false;
                    IBACheckBox.ForeColor = System.Drawing.Color.Red;
                    IBACheckBox.Font.Bold = true;
                }

            }
            else
            {
                Panel6.BackColor = System.Drawing.Color.Red;
                Panel6.Enabled = false;

            }

            // For G Unit

            if (SSCResult >= 3.5 && HSCResult >= 3.5)
            {
                TotalResult = SSCResult + HSCResult;
                
                if (TotalResult < 8.00 || English < 3.50 || Bangla < 3.50)
                {
                    LawCheckBox.Enabled = false;
                    LawCheckBox.BackColor = System.Drawing.Color.Red;
                    LawCheckBox.Font.Bold = true;
                } 

            } 
            else 
            {
                 Panel7.BackColor = System.Drawing.Color.Red;
                 Panel7.Enabled = false;
            } 

            // For H Unit

            if (SSCResult >= 3.5 && HSCResult >= 3.5)
            {
                   TotalResult = SSCResult + HSCResult;

                if (TotalResult < 8.00 || Physics < 4.00 || Math < 4.00)
                {
                    IITCheckBox.Enabled = false;
                    IITCheckBox.BackColor = System.Drawing.Color.Red;
                    IITCheckBox.Font.Bold = true;
                }

            }
            else
            {
                Panel8.BackColor = System.Drawing.Color.Red;
                Panel8.Enabled = false;
            }
                
            

            CSECheckBox.CheckedChanged += new EventHandler(CSECheckBox_CheckedChanged);
            MathCheckBox.CheckedChanged += new EventHandler(MathCheckBox_CheckedChanged);
            PhysicsCheckBox.CheckedChanged +=new EventHandler(PhysicsCheckBox_CheckedChanged);
            StatisticsCheckBox.CheckedChanged +=new EventHandler(StatisticsCheckBox_CheckedChanged);
            ESCheckBox.CheckedChanged+=new EventHandler(ESCheckBox_CheckedChanged);
            GSCheckBox.CheckedChanged+=new EventHandler(GSCheckBox_CheckedChanged);
            ChemistryCheckBox.CheckedChanged+=new EventHandler(ChemistryCheckBox_CheckedChanged);
            EconomicsCheckBox.CheckedChanged+=new EventHandler(EconomicsCheckBox_CheckedChanged);
            URPCheckBox.CheckedChanged+=new EventHandler(URPCheckBox_CheckedChanged);
            AnthropologyCheckBox.CheckedChanged+=new EventHandler(AnthropologyCheckBox_CheckedChanged);
            GeographyCheckBox.CheckedChanged+=new EventHandler(GeographyCheckBox_CheckedChanged);
            GPCheckBox.CheckedChanged+=new EventHandler(GPCheckBox_CheckedChanged);
            PACheckBox.CheckedChanged+=new EventHandler(PACheckBox_CheckedChanged);
            IRCheckBox.CheckedChanged+=new EventHandler(IRCheckBox_CheckedChanged);
            EnglishCheckBox.CheckedChanged+=new EventHandler(EnglishCheckBox_CheckedChanged);
            HistoryCheckBox.CheckedChanged+=new EventHandler(HistoryCheckBox_CheckedChanged);
            PhilosophyCheckBox.CheckedChanged+=new EventHandler(PhilosophyCheckBox_CheckedChanged);
            DramaCheckBox.CheckedChanged+=new EventHandler(DramaCheckBox_CheckedChanged);
            ArchiologyCheckBox.CheckedChanged+=new EventHandler(ArchiologyCheckBox_CheckedChanged);
            BanglaCheckBox.CheckedChanged+=new EventHandler(BanglaCheckBox_CheckedChanged);
            JournalismCheckBox.CheckedChanged+=new EventHandler(JournalismCheckBox_CheckedChanged);
            BotanyCheckBox.CheckedChanged+=new EventHandler(BotanyCheckBox_CheckedChanged);
            ZoologyCheckBox.CheckedChanged+=new EventHandler(ZoologyCheckBox_CheckedChanged);
            PharmacyCheckBox.CheckedChanged+=new EventHandler(PharmacyCheckBox_CheckedChanged);
            BiochemistryCheckBox.CheckedChanged+=new EventHandler(BiochemistryCheckBox_CheckedChanged); 
            MicrobiologyCheckBox.CheckedChanged+=new EventHandler(MicrobiologyCheckBox_CheckedChanged);
            GEBCheckBox.CheckedChanged+=new EventHandler(GEBCheckBox_CheckedChanged);
            PBHCheckBox.CheckedChanged+=new EventHandler(PBHCheckBox_CheckedChanged);
            FBCheckBox.CheckedChanged+=new EventHandler(FBCheckBox_CheckedChanged);
            MarketingCheckBox.CheckedChanged+=new EventHandler(MarketingCheckBox_CheckedChanged);
            AISCheckBox.CheckedChanged+=new EventHandler(AISCheckBox_CheckedChanged);
            MSCheckBox.CheckedChanged+=new EventHandler(MSCheckBox_CheckedChanged);
            IBACheckBox.CheckedChanged+=new EventHandler(IBACheckBox_CheckedChanged);
            LawCheckBox.CheckedChanged+=new EventHandler(LawCheckBox_CheckedChanged);
            IITCheckBox.CheckedChanged += new EventHandler(IITCheckBox_CheckedChanged);
        }

        protected void resultConvert()
        {
            Double result = Convert.ToDouble(CSETextBox.Text.ToString())
                          + Convert.ToDouble(MathTextBox.Text.ToString())
                          + Convert.ToDouble(PhysicsTextBox.Text.ToString())
                          + Convert.ToDouble(StatisticsTextBox.Text.ToString())
                          + Convert.ToDouble(ESTextBox.Text.ToString())
                          + Convert.ToDouble(GSTextBox.Text.ToString())
                          + Convert.ToDouble(ChemistryTextBox.Text.ToString())
                          + Convert.ToDouble(EconomicsTextBox.Text.ToString())
                          + Convert.ToDouble(URPTextBox.Text.ToString())
                          + Convert.ToDouble(AnthropologyTextBox.Text.ToString())
                          + Convert.ToDouble(GeographyTextBox.Text.ToString())
                          + Convert.ToDouble(GPTextBox.Text.ToString())
                          + Convert.ToDouble(PATextBox.Text.ToString())
                          + Convert.ToDouble(IRTextBox.Text.ToString())
                          + Convert.ToDouble(EnglishTextBox.Text.ToString())
                          + Convert.ToDouble(HistoryTextBox.Text.ToString())
                          + Convert.ToDouble(PhilosophyTextBox.Text.ToString())
                          + Convert.ToDouble(DramaTextBox.Text.ToString())
                          + Convert.ToDouble(ArchiologyTextBox.Text.ToString())
                          + Convert.ToDouble(BanglaTextBox.Text.ToString())
                          + Convert.ToDouble(JournalismTextBox.Text.ToString())
                          + Convert.ToDouble(BotanyTextBox.Text.ToString())
                          + Convert.ToDouble(ZoologyTextBox.Text.ToString())
                          + Convert.ToDouble(PharmacyTextBox.Text.ToString())
                          + Convert.ToDouble(BiochemistryTextBox.Text.ToString())
                          + Convert.ToDouble(MicrobiologyTextBox.Text.ToString())
                          + Convert.ToDouble(GEBTextBox.Text.ToString())
                          + Convert.ToDouble(PBHTextBox.Text.ToString())
                          + Convert.ToDouble(FBTextBox.Text.ToString())
                          + Convert.ToDouble(MarketingTextBox.Text.ToString())
                          + Convert.ToDouble(AISTextBox.Text.ToString())
                          + Convert.ToDouble(MSTextBox.Text.ToString())
                          + Convert.ToDouble(IBATextBox.Text.ToString())
                          + Convert.ToDouble(LawTextBox.Text.ToString())
                          + Convert.ToDouble(IITTextBox.Text.ToString())
                          ;

            TotalTextBox.Text = Convert.ToString(result);
        }
 

        protected void CSECheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CSECheckBox.Checked)
            {
                CSETextBox.Text = "150";
                resultConvert();
            }
            else
            {
                CSETextBox.Text = "0";
                resultConvert();
            }
        }

        protected void MathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MathCheckBox.Checked)
            {
                MathTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                MathTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void PhysicsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PhysicsCheckBox.Checked)
            {
                PhysicsTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                PhysicsTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void StatisticsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (StatisticsCheckBox.Checked)
            {
                StatisticsTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                StatisticsTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void ESCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ESCheckBox.Checked)
            {
                ESTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                ESTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void GSCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GSCheckBox.Checked)
            {
                GSTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                GSTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void ChemistryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChemistryCheckBox.Checked)
            {
                ChemistryTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                ChemistryTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void EconomicsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EconomicsCheckBox.Checked)
            {
                EconomicsTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                EconomicsTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void URPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (URPCheckBox.Checked)
            {
                URPTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                URPTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void AnthropologyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AnthropologyCheckBox.Checked)
            {
                AnthropologyTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                AnthropologyTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void GeographyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GeographyCheckBox.Checked)
            {
                GeographyTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                GeographyTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void GPCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GPCheckBox.Checked)
            {
                GPTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                GPTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void PACheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PACheckBox.Checked)
            {
                PATextBox.Text = "150";
                resultConvert();
            }
            else
            {
                PATextBox.Text = "0";
                resultConvert();
            }
        }

        protected void IRCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IRCheckBox.Checked)
            {
                IRTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                IRTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void EnglishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EnglishCheckBox.Checked)
            {
                EnglishTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                EnglishTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void HistoryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HistoryCheckBox.Checked)
            {
                HistoryTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                HistoryTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void PhilosophyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PhilosophyCheckBox.Checked)
            {
                PhilosophyTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                PhilosophyTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void DramaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DramaCheckBox.Checked)
            {
                DramaTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                DramaTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void ArchiologyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ArchiologyCheckBox.Checked)
            {
                ArchiologyTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                ArchiologyTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void BanglaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BanglaCheckBox.Checked)
            {
                BanglaTextBox.Text = "300";
                resultConvert();
            }
            else
            {
                BanglaTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void JournalismCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (JournalismCheckBox.Checked)
            {
                JournalismTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                JournalismTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void BotanyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BotanyCheckBox.Checked)
            {
                BotanyTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                BotanyTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void ZoologyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ZoologyCheckBox.Checked)
            {
                ZoologyTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                ZoologyTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void PharmacyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PharmacyCheckBox.Checked)
            {
                PharmacyTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                PharmacyTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void BiochemistryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BiochemistryCheckBox.Checked)
            {
                BiochemistryTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                BiochemistryTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void GEBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GEBCheckBox.Checked)
            {
                GEBTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                GEBTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void PBHCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PBHCheckBox.Checked)
            {
                PBHTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                PBHTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void MicrobiologyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MicrobiologyCheckBox.Checked)
            {
                MicrobiologyTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                MicrobiologyTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void FBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FBCheckBox.Checked)
            {
                FBTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                FBTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void MarketingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MarketingCheckBox.Checked)
            {
                MarketingTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                MarketingTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void AISCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AISCheckBox.Checked)
            {
                AISTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                AISTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void MSCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MSCheckBox.Checked)
            {
                MSTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                MSTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void IBACheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IBACheckBox.Checked)
            {
                IBATextBox.Text = "150";
                resultConvert();
            }
            else
            {
                IBATextBox.Text = "0";
                resultConvert();
            }
        }

        protected void LawCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LawCheckBox.Checked)
            {
                LawTextBox.Text = "150";
                resultConvert();
            }
            else
            {
                LawTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void IITCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IITCheckBox.Checked)
            {
                IITTextBox.Text = "300";
                resultConvert();
            }
            else
            {
                IITTextBox.Text = "0";
                resultConvert();
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
           
            Double paymentamount = Convert.ToDouble(payment);

            Double total = Convert.ToDouble(TotalTextBox.Text.ToString());

            if (total <= paymentamount && total !=0)
            {
                insertData();
                insertMoney();
                accountCheck();
                Response.Write("<script>alert('Yes ,You can sucessfully submit');</script>");

                TotalTextBox.Text = "0";
            }
            else
            { 
                Response.Write("<script>alert('Sorry,you have not sufficient balance');</script>");
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScienceForm.aspx");
        }
    }
}