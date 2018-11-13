
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
    public partial class UnitSelectionArtsForm : System.Web.UI.Page
    {
        String subject;
        String state;
        String payment;
        String accountId; 

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDatabaseConnectionString1"].ConnectionString);

      

        protected void insertData()
        {

            if (EconomicsCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Economics','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (URPCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','URP','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (AnthropologyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Anthropology','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (GeographyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Geography','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (GPCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','GP','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PACheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','PA','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (IRCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','IR','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (EnglishCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','English','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (HistoryCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','History','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PhilosophyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Philosophy','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (DramaCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Drama','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (ArchiologyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Archiology','YES')", con);
                cmd.ExecuteNonQuery();
                selection();

            }

            if (BanglaCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Bangla','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (JournalismCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Journalism','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (FBCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','FB','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (IBACheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "',''Huminities','IBA','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (LawCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Huminities','Law','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

        }

        protected void insertMoney()
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            double cost = Convert.ToDouble(TotalTextBox.Text);
            double total = amount - cost;

            String selectString = "update accountTable set Amount='" + total + "' where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "'";
            SqlCommand cmd = new SqlCommand(selectString, con);
            cmd.ExecuteNonQuery();

        }

        protected void selection()
        {
            String selectString = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Economics'";
            SqlCommand commandObj = new SqlCommand(selectString, con);
            SqlDataReader reader = commandObj.ExecuteReader();

            if (reader.Read())
            {
                subject = reader[0].ToString();
                state = reader[1].ToString();
                if (state.Equals("YES") && subject.Equals("Economics"))
                {
                    EconomicsCheckBox.Enabled = false;
                    EconomicsCheckBox.Checked = false;
                    EconomicsTextBox.Text = "0";
                    EconomicsCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    EconomicsCheckBox.Font.Bold = true;
                }


            }

            reader.Close();

            String selectString1 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='URP'";
            SqlCommand commandObj1 = new SqlCommand(selectString1, con);
            SqlDataReader reader1 = commandObj1.ExecuteReader();

            if (reader1.Read())
            {
                subject = reader1[0].ToString();
                state = reader1[1].ToString();
                if (state.Equals("YES") && subject.Equals("URP"))
                {
                    URPCheckBox.Enabled = false;
                    URPCheckBox.Checked = false;
                    URPTextBox.Text = "0";
                    URPCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    URPCheckBox.Font.Bold = true;
                }


            }

            reader1.Close();

            String selectString2 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Anthropology'";
            SqlCommand commandObj2 = new SqlCommand(selectString2, con);
            SqlDataReader reader2 = commandObj2.ExecuteReader();

            if (reader2.Read())
            {
                subject = reader2[0].ToString();
                state = reader2[1].ToString();
                if (state.Equals("YES") && subject.Equals("Anthropology"))
                {
                    AnthropologyCheckBox.Enabled = false;
                    AnthropologyCheckBox.Checked = false;
                    AnthropologyTextBox.Text = "0";
                    AnthropologyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    AnthropologyCheckBox.Font.Bold = true;
                }

            }

            reader2.Close();

            String selectString3 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Geography'";
            SqlCommand commandObj3 = new SqlCommand(selectString3, con);
            SqlDataReader reader3 = commandObj3.ExecuteReader();

            if (reader3.Read())
            {
                subject = reader3[0].ToString();
                state = reader3[1].ToString();
                if (state.Equals("YES") && subject.Equals("Geography"))
                {
                    GeographyCheckBox.Enabled = false;
                    GeographyCheckBox.Checked = false;
                    GeographyTextBox.Text = "0";
                    GeographyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    GeographyCheckBox.Font.Bold = true;
                }

            }

            reader3.Close();

            String selectString4 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='GP'";
            SqlCommand commandObj4 = new SqlCommand(selectString4, con);
            SqlDataReader reader4 = commandObj4.ExecuteReader();

            if (reader4.Read())
            {
                subject = reader4[0].ToString();
                state = reader4[1].ToString();
                if (state.Equals("YES") && subject.Equals("GP"))
                {
                    GPCheckBox.Enabled = false;
                    GPCheckBox.Checked = false;
                    GPTextBox.Text = "0";
                    GPCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    GPCheckBox.Font.Bold = true;
                }

            }

            reader4.Close();
            /// for PA

            String selectString5 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='PA'";
            SqlCommand commandObj5 = new SqlCommand(selectString5, con);
            SqlDataReader reader5 = commandObj5.ExecuteReader();

            if (reader5.Read())
            {
                subject = reader5[0].ToString();
                state = reader5[1].ToString();
                if (state.Equals("YES") && subject.Equals("PA"))
                {
                    PACheckBox.Enabled = false;
                    PACheckBox.Checked = false;
                    PATextBox.Text = "0";
                    PACheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    PACheckBox.Font.Bold = true;
                }

            }

            reader5.Close();

            /// for IR 

            String selectString6 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='IR'";
            SqlCommand commandObj6 = new SqlCommand(selectString6, con);
            SqlDataReader reader6 = commandObj6.ExecuteReader();

            if (reader6.Read())
            {
                subject = reader6[0].ToString();
                state = reader6[1].ToString();
                if (state.Equals("YES") && subject.Equals("IR"))
                {
                    IRCheckBox.Enabled = false;
                    IRCheckBox.Checked = false;
                    IRTextBox.Text = "0";
                    IRCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    IRCheckBox.Font.Bold = true;
                }

            }

            reader6.Close();

            /// for English 

            String selectString7 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='English'";
            SqlCommand commandObj7 = new SqlCommand(selectString7, con);
            SqlDataReader reader7 = commandObj7.ExecuteReader();

            if (reader7.Read())
            {
                subject = reader7[0].ToString();
                state = reader7[1].ToString();
                if (state.Equals("YES") && subject.Equals("English"))
                {
                    EnglishCheckBox.Enabled = false;
                    EnglishCheckBox.Checked = false;
                    EnglishTextBox.Text = "0";
                    EnglishCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    EnglishCheckBox.Font.Bold = true;
                }

            }

            reader7.Close();


            /// for History 

            String selectString8 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='History'";
            SqlCommand commandObj8 = new SqlCommand(selectString8, con);
            SqlDataReader reader8 = commandObj8.ExecuteReader();

            if (reader8.Read())
            {
                subject = reader8[0].ToString();
                state = reader8[1].ToString();
                if (state.Equals("YES") && subject.Equals("History"))
                {
                    HistoryCheckBox.Enabled = false;
                    HistoryCheckBox.Checked = false;
                    HistoryTextBox.Text = "0";
                    HistoryCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    HistoryCheckBox.Font.Bold = true;
                }

            }

            reader8.Close();



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
   
            double Bangla = Convert.ToDouble(Session["Bangla"]); 
            double English = Convert.ToDouble(Session["English"]); 
            double Economics = Convert.ToDouble(Session["Economics"]);
            double Civis = Convert.ToDouble(Session["Civics"]);
            double Psycology = Convert.ToDouble(Session["Psycology"]); 
            double Math = Convert.ToDouble(Session["Mathmatics"]);
            double Statistics = Convert.ToDouble(Session["Statistics"]);
            double CS = Convert.ToDouble(Session["CS"]); 
            double HSCResult = Convert.ToDouble(Session["GPA"]);
            double SSCEnglish = Convert.ToDouble(Session["SSCEnglish"]);
            double SSCResult = Convert.ToDouble(Session["SSCGPA"]);
            double TotalResult = 0;

            con.Open();

            selection();
            accountCheck();

            // B Unit

            if (SSCResult >= 3.50 && HSCResult >= 3.50)
            {
                TotalResult = SSCResult + HSCResult;

                if (TotalResult < 7.50 || (Bangla < 3.00 && English < 3.00 && Economics < 3.00))
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
                else if (TotalResult < 7.00 || (Bangla < 3.00 && English < 3.00))
                {
                    AnthropologyCheckBox.Enabled = false;
                    AnthropologyCheckBox.BackColor = System.Drawing.Color.Red;
                    AnthropologyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00 || (Bangla < 3.50 && English < 3.50))
                {
                    GPCheckBox.Enabled = false;
                    GPCheckBox.BackColor = System.Drawing.Color.Red;
                    GPCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00 || English < 4.00)
                {
                    PACheckBox.Enabled = false;
                    PACheckBox.BackColor = System.Drawing.Color.Red;
                    PACheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00 || English < 4.00)
                {
                    GeographyCheckBox.Enabled = false;
                    GeographyCheckBox.BackColor = System.Drawing.Color.Red;
                    GeographyCheckBox.Font.Bold = true;
                } 
            }
            else 
            {
                 PanelB.BackColor = System.Drawing.Color.Red;
                 PanelB.Enabled = false;
            }

            // For C Unit
            
            if (SSCResult >= 3.00 && HSCResult >= 3.00)
            {
                if (TotalResult < 7.50 || SSCEnglish < 4.00 || English < 4.00)
                {
                    IRCheckBox.Enabled = false;
                    IRCheckBox.BackColor = System.Drawing.Color.Red;
                    IRCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00 || SSCEnglish < 4.00 || English < 4.00)
                {
                    EnglishCheckBox.Enabled = false;
                    EnglishCheckBox.BackColor = System.Drawing.Color.Red;
                    EnglishCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00 || English < 3.50 || Bangla < 4.00)
                {
                    HistoryCheckBox.Enabled = false;
                    HistoryCheckBox.BackColor = System.Drawing.Color.Red;
                    HistoryCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 6.00)
                {
                    PhilosophyCheckBox.Enabled = false;
                    PhilosophyCheckBox.BackColor = System.Drawing.Color.Red;
                    PhilosophyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 6.00 || (Economics < 3.5 && Civis < 3.5 && Math < 3.5 && Bangla < 3.5 && CS < 3.5 && English < 3.5 && Statistics < 3.5))
                {
                    DramaCheckBox.Enabled = false;
                    DramaCheckBox.BackColor = System.Drawing.Color.Red;
                    DramaCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 6.50)
                {
                    ArchiologyCheckBox.Enabled = false;
                    ArchiologyCheckBox.BackColor = System.Drawing.Color.Red;
                    ArchiologyCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00)
                {
                    BanglaCheckBox.Enabled = false;
                    BanglaCheckBox.BackColor = System.Drawing.Color.Red;
                    BanglaCheckBox.Font.Bold = true;
                }
                else if (TotalResult < 7.00)
                {
                    JournalismCheckBox.Enabled = false;
                    JournalismCheckBox.BackColor = System.Drawing.Color.Red;
                    JournalismCheckBox.Font.Bold = true;
                } 
            }
            else 
            {
                 PanelC.BackColor = System.Drawing.Color.Red;
                 PanelC.Enabled = false;
            }

            //For E Unit

            if (SSCResult >= 3.50 && HSCResult >= 3.50)
            {
                if (TotalResult < 7.00 || Math < 3.00)
                {
                    FBCheckBox.Enabled = false;
                    FBCheckBox.BackColor = System.Drawing.Color.Red;
                    FBCheckBox.Font.Bold = true;
                } 
            } 
            else
            {
               PanelE.BackColor = System.Drawing.Color.Red;
               PanelE.Enabled = false;
            }


             //For F Unit

            if (SSCResult >= 4.00 && HSCResult >= 4.00)
            {
                if (TotalResult < 7.00 || Math < 3.00)
                {
                    IBACheckBox.Enabled = false;
                    IBACheckBox.ForeColor = System.Drawing.Color.Red;
                    IBACheckBox.Font.Bold = true;
                } 
            } 
            else
            {
               PanelF.BackColor = System.Drawing.Color.Red;
               PanelF.Enabled = false;
            } 

             //For G Unit

            if (SSCResult >= 3.50 && HSCResult >= 3.50)
            {
                if (TotalResult < 7.00 || Math < 3.00)
                {
                    LawCheckBox.Enabled = false;
                    LawCheckBox.BackColor = System.Drawing.Color.Red;
                    LawCheckBox.Font.Bold = true;
                } 
            } 
            else
            {
               PanelG.BackColor = System.Drawing.Color.Red;
               PanelG.Enabled = false;
            }
               
               
           
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
            FBCheckBox.CheckedChanged+=new EventHandler(FBCheckBox_CheckedChanged);
            IBACheckBox.CheckedChanged+=new EventHandler(IBACheckBox_CheckedChanged);
            LawCheckBox.CheckedChanged+=new EventHandler(LawCheckBox_CheckedChanged);

            
        }

        protected void resultConvert()
        {
            Double result = Convert.ToDouble(EconomicsTextBox.Text.ToString())
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
                          + Convert.ToDouble(FBTextBox.Text.ToString()) 
                          + Convert.ToDouble(LawTextBox.Text.ToString())
                          + Convert.ToDouble(IBATextBox.Text.ToString()) 
                          ;

            TotalTextBox.Text = Convert.ToString(result);
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
                BanglaTextBox.Text = "150";
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


       protected void SubmitButton_Click(object sender, EventArgs e)
       {
           String payment = "1000";

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

              Response.Write("<script>alert('Sorry,you have not sufficient balance or Your Balance is 0');</script>");
           }
       }

       protected void BackButton_Click(object sender, EventArgs e)
       {
           Response.Redirect("ArtsForm.aspx");
       }     
    }
}