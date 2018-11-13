
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
    public partial class UnitSelectionCommerceForm : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Economics','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (URPCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','URP','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (AnthropologyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Anthropology','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (GeographyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Geography','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (GPCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','GP','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PACheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','PA','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (IRCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','IR','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (EnglishCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','English','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (HistoryCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','History','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (PhilosophyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Philosophy','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (DramaCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Drama','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (ArchiologyCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Archiology','YES')", con);
                cmd.ExecuteNonQuery();
                selection();

            }

            if (BanglaCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Bangla','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (JournalismCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Journalism','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

           

            if (FBCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','FB','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (MarketingCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','MK','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (AISCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','AIS','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (MSCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','MS','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (IBACheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','IBA','YES')", con);
                cmd.ExecuteNonQuery();
                selection();
            }

            if (LawCheckBox.Checked)
            {
                SqlCommand cmd = new SqlCommand("insert into studentTable values('" + Session["HSCRoll"] + "','" + Session["SSCRoll"] + "','" + Session["candidateName"] + "','" + Session["Session"] + "','" + Session["Board"] + "','Commerce','Law','YES')", con);
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

            String selectString9 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Philosophy'";
            SqlCommand commandObj9 = new SqlCommand(selectString9, con);
            SqlDataReader reader9 = commandObj9.ExecuteReader();

            if (reader9.Read())
            {
                subject = reader9[0].ToString();
                state = reader9[1].ToString();
                if (state.Equals("YES") && subject.Equals("Philosophy"))
                {
                    PhilosophyCheckBox.Enabled = false;
                    PhilosophyCheckBox.Checked = false;
                    PhilosophyTextBox.Text = "0";


                    PhilosophyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    PhilosophyCheckBox.Font.Bold = true;
                }

            }

            reader9.Close();

            /// for Drama

            String selectString10 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Drama'";
            SqlCommand commandObj10 = new SqlCommand(selectString10, con);
            SqlDataReader reader10 = commandObj10.ExecuteReader();

            if (reader10.Read())
            {
                subject = reader10[0].ToString();
                state = reader10[1].ToString();
                if (state.Equals("YES") && subject.Equals("Drama"))
                {
                    DramaCheckBox.Enabled = false;
                    DramaCheckBox.Checked = false;
                    DramaTextBox.Text = "0";


                    DramaCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    DramaCheckBox.Font.Bold = true;
                }

            }

            reader10.Close();


            /// for Archiology

            String selectString11 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Archiology'";
            SqlCommand commandObj11 = new SqlCommand(selectString11, con);
            SqlDataReader reader11 = commandObj11.ExecuteReader();

            if (reader11.Read())
            {
                subject = reader11[0].ToString();
                state = reader11[1].ToString();
                if (state.Equals("YES") && subject.Equals("Archiology"))
                {
                    ArchiologyCheckBox.Enabled = false;
                    ArchiologyCheckBox.Checked = false;
                    ArchiologyTextBox.Text = "0";


                    ArchiologyCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    ArchiologyCheckBox.Font.Bold = true;
                }

            }

            reader11.Close();

            /// for Bangla

            String selectString12 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Bangla'";
            SqlCommand commandObj12 = new SqlCommand(selectString12, con);
            SqlDataReader reader12 = commandObj12.ExecuteReader();

            if (reader12.Read())
            {
                subject = reader12[0].ToString();
                state = reader12[1].ToString();
                if (state.Equals("YES") && subject.Equals("Bangla"))
                {
                    BanglaCheckBox.Enabled = false;
                    BanglaCheckBox.Checked = false;
                    BanglaTextBox.Text = "0";


                    BanglaCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    BanglaCheckBox.Font.Bold = true;
                }

            }

            reader12.Close();

            /// for Journalism
            String selectString13 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Journalism'";
            SqlCommand commandObj13 = new SqlCommand(selectString13, con);
            SqlDataReader reader13 = commandObj13.ExecuteReader();

            if (reader13.Read())
            {
                subject = reader13[0].ToString();
                state = reader13[1].ToString();
                if (state.Equals("YES") && subject.Equals("Journalism"))
                {
                    JournalismCheckBox.Enabled = false;
                    JournalismCheckBox.Checked = false;
                    JournalismTextBox.Text = "0";


                    JournalismCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    JournalismCheckBox.Font.Bold = true;
                }

            }

            reader13.Close();
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

            // for IBA

            String query = "select Subject, State from studentTable where HSCRoll='"+Session["HSCRoll"]+"' and SSCRoll='"+Session["SSCRoll"]+"' and Board='"+Session["Board"]+"' and Session='"+Session["Session"]+"' and Subject='IBA' ";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader15 = command.ExecuteReader();

            if (reader15.Read())
            {
                subject = reader15[0].ToString();
                state = reader15[1].ToString();
                if (state.Equals("YES") && subject.Equals("IBA"))
                {
                    IBACheckBox.Enabled = false;
                    IBACheckBox.Checked = false;
                    IBATextBox.Text = "0";

                    IBACheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    IBACheckBox.Font.Bold = true;
                }

            }

            reader15.Close();

            /// for Law
            String selectString144 = "select Subject,State from studentTable where HSCRoll='" + Session["HSCRoll"] + "' and SSCRoll='" + Session["SSCRoll"] + "' and Board='" + Session["Board"] + "' and Session='" + Session["Session"] + "' and Subject='Law'";
            SqlCommand commandObj144 = new SqlCommand(selectString144, con);
            SqlDataReader reader144 = commandObj144.ExecuteReader();

            if (reader144.Read())
            {
                subject = reader144[0].ToString();
                state = reader144[1].ToString();
                if (state.Equals("YES") && subject.Equals("Law"))
                {
                    LawCheckBox.Enabled = false;
                    LawCheckBox.Checked = false;
                    LawTextBox.Text = "0";

                    LawCheckBox.BackColor = System.Drawing.Color.LawnGreen;
                    LawCheckBox.Font.Bold = true;
                }

            }

            reader144.Close();

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

            selection();
            accountCheck();

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
            MarketingCheckBox.CheckedChanged+=new EventHandler(MarketingCheckBox_CheckedChanged);
            AISCheckBox.CheckedChanged+=new EventHandler(AISCheckBox_CheckedChanged);
            MSCheckBox.CheckedChanged+=new EventHandler(MSCheckBox_CheckedChanged);
            IBACheckBox.CheckedChanged+=new EventHandler(IBACheckBox_CheckedChanged);
            LawCheckBox.CheckedChanged+=new EventHandler(LawCheckBox_CheckedChanged);


            // Now it is by milon

            double SSCGPA = Convert.ToDouble(Session["SSCGPA"]);
            double HSCGPA = Convert.ToDouble(Session["GPA"]);
            double Accounting = Convert.ToDouble(Session["Accounting"]);
            double Finance = Convert.ToDouble(Session["Finance"]);
            double Management = Convert.ToDouble(Session["Management"]);
            double ComputerScience = Convert.ToDouble(Session["ComputerScience"]);
            double Agriculture = Convert.ToDouble(Session["Agriculture"]);
            double Bangla = Convert.ToDouble(Session["Bangla"]);
            double English = Convert.ToDouble(Session["English"]);
            double Economics=Convert.ToDouble(Session["Economics"]);
            double Math = Convert.ToDouble(Session["Mathematics"]);
            double SSCEnglish = Convert.ToDouble(Session["SSCEnglish"]); 


            // for B Unit

        //    Response.Write("<script>alert("+HSCGPA+");</script>");

            if (SSCGPA >= 3.5 && HSCGPA >= 3.5)
            {
                double totGPA = SSCGPA + HSCGPA;
                if (totGPA < 7.00 || Economics < 3.5)
                {
                    EconomicsCheckBox.BackColor = System.Drawing.Color.Red;
                    EconomicsCheckBox.Enabled = false;
                    EconomicsTextBox.Text = "0.0";
                }

                if (totGPA < 8.5 || English < 3.5 || Math < 3.5)
                {
                    URPCheckBox.BackColor = System.Drawing.Color.Red;
                    URPCheckBox.Enabled = false;
                    URPTextBox.Text = "0.0";
                }

                if (totGPA < 7 || (English < 3 && Bangla < 3))
                {
                    AnthropologyCheckBox.BackColor = System.Drawing.Color.Red;
                    AnthropologyCheckBox.Enabled = false;
                   // AnthropologyTextBox.Text = "0.0";

                    AnthropologyTextBox.Text = totGPA +" "+ English +" "+ Bangla;
                }

                if (totGPA < 7 || (English < 3 && Bangla < 3))
                {
                    GPCheckBox.BackColor = System.Drawing.Color.Red;
                    GPCheckBox.Enabled = false;
                    GPTextBox.Text = "0.0";
                }

                if (totGPA < 7 || English < 4)
                {
                    PACheckBox.BackColor = System.Drawing.Color.Red;
                    PACheckBox.Enabled = false;
                    PATextBox.Text = "0.0";
                }

                if (totGPA < 7 || (English < 3.5 && Bangla < 3.5))
                {
                    GeographyCheckBox.BackColor = System.Drawing.Color.Red;
                    GeographyCheckBox.Enabled = false;
                    GeographyTextBox.Text = "0.0";
                }
            }
            else
            {
                panelB.BackColor = System.Drawing.Color.Red;
                panelB.Enabled = false;
            }

            // for C Unit

            if (SSCGPA >= 3 && HSCGPA >= 3)
            {
                double totGPA = SSCGPA + HSCGPA;
                if (totGPA < 7.5 || English < 4)
                {
                    IRCheckBox.BackColor = System.Drawing.Color.Red;
                    IRCheckBox.Enabled = false;
                    IRTextBox.Text = "0.0";
                }

                if (totGPA < 7.5 || English < 4)
                {
                    EnglishCheckBox.BackColor = System.Drawing.Color.Red;
                    EnglishCheckBox.Enabled = false;
                    EnglishTextBox.Text = "0.0";
                }
                if (totGPA < 7.5 || English < 3.5 || Bangla<4.0)
                {
                    HistoryCheckBox.BackColor = System.Drawing.Color.Red;
                    HistoryCheckBox.Enabled = false;
                    HistoryTextBox.Text = "0.0";
                }

                if (totGPA < 6.5)
                {
                    DramaCheckBox.BackColor = System.Drawing.Color.Red;
                    DramaCheckBox.Enabled = false;
                    DramaCheckBox.Text = "0.0";
                }

                if (totGPA < 7.0)
                {
                    ArchiologyCheckBox.BackColor = System.Drawing.Color.Red;
                    ArchiologyCheckBox.Enabled = false;
                    ArchiologyCheckBox.Text = "0.0";
                }

                if (totGPA < 7.5)
                {
                    BanglaCheckBox.BackColor = System.Drawing.Color.Red;
                    BanglaCheckBox.Enabled = false;
                    BanglaTextBox.Text = "0.0";
                }

                if (totGPA < 7.0)
                {
                    JournalismCheckBox.BackColor = System.Drawing.Color.Red;
                    JournalismCheckBox.Enabled = false;
                    JournalismCheckBox.Text = "0.0";
                }
            }
            else
            {
                panelC.BackColor = System.Drawing.Color.Red;
                panelC.Enabled = false;
            }

            // for E Unit

            if (SSCGPA >= 3.5 && HSCGPA >= 3.5)
            {
                double totGPA = SSCGPA + HSCGPA;
                if (totGPA < 7 || Accounting < 3)
                {
                    FBCheckBox.BackColor = System.Drawing.Color.Red;
                    FBCheckBox.Enabled = false;
                    FBTextBox.Text = "0.0";
                }

                if (totGPA < 8.0 || English < 3.5)
                {
                    MarketingCheckBox.BackColor = System.Drawing.Color.Red;
                    MarketingCheckBox.Enabled = false;
                    MarketingTextBox.Text = "0.0";
                }

                if (totGPA < 8.0 || English < 3.5)
                {
                    AISCheckBox.BackColor = System.Drawing.Color.Red;
                    AISCheckBox.Enabled = false;
                    AISTextBox.Text = "0.0";
                }

                if (totGPA < 8.0 || English < 3.5)
                {
                    MSCheckBox.BackColor = System.Drawing.Color.Red;
                    MSCheckBox.Enabled = false;
                    MSTextBox.Text = "0.0";
                }
            }
            else
            {
                panelE.BackColor = System.Drawing.Color.Red;
                panelE.Enabled = false;
            }

            // for F unit

            if (SSCGPA >= 3.5 && HSCGPA >= 3.5)
            {
                if ((SSCGPA + HSCGPA < 7.5) || English < 3.5)
                {
                    IBACheckBox.BackColor = System.Drawing.Color.Red;
                    IBACheckBox.Enabled = false;
                    IBATextBox.Text = "0.0";
                }

            }
            else
            {
                panelF.BackColor = System.Drawing.Color.Red;
                panelF.Enabled = false;
            }


            // for G unit


            if (SSCGPA >= 4.0 && HSCGPA >= 4.0)
            {
                if ((SSCGPA + HSCGPA < 8.0) || English < 3.5)
                {
                    LawCheckBox.BackColor = System.Drawing.Color.Red;
                    LawCheckBox.Enabled = false;
                    LawTextBox.Text = "0.0";
                }

            }
            else
            {
                panelG.BackColor = System.Drawing.Color.Red;
                panelG.Enabled = false;
            }

            
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
                          + Convert.ToDouble(MarketingTextBox.Text.ToString())
                          + Convert.ToDouble(AISTextBox.Text.ToString())
                          + Convert.ToDouble(MSTextBox.Text.ToString())
                          + Convert.ToDouble(IBATextBox.Text.ToString())
                          + Convert.ToDouble(LawTextBox.Text.ToString())
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

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Double paymentamount = Convert.ToDouble(payment);

            Double total = Convert.ToDouble(TotalTextBox.Text.ToString());

            if (total <= paymentamount && total != 0)
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
            Response.Redirect("CommerceForm.aspx");
        }

        
    }
}