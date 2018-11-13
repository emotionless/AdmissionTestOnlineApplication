using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.HtmlControls;
using System.Drawing;

namespace AdmissionWebApplication
{
    public partial class see : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MYDatabaseConnectionString1"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand query = new SqlCommand("select unit, subject from unitTable", con);
            SqlDataReader reader = query.ExecuteReader();


            Page.Header.Controls.Add(new LiteralControl("<link rel=\"stylesheet\" type=\"text/css\" href=\"" + ResolveUrl("~/Style/bootstrap.css") + "\" />"));


            HtmlTable table1 = new HtmlTable();

            table1.Border = 1;
            table1.CellPadding = 3;
            table1.CellSpacing = 3;
            table1.BorderColor = "red";

            HtmlTableRow row;
            HtmlTableCell cell;
            HtmlTableCell cell1;

            int k = 0;
            int cnt = 0;

            while (reader.Read())
            {
                string subject = reader[1].ToString();
                //Response.Write("<script>alert('"+subject+"');</script>");
                Panel pan ;
                pan= new Panel();
                pan.Attributes.Add("class","row");
                pan.Attributes.Add("class", "span2 offset1");
                pan.Width = 563;
                pan.Height = 261;

                row = new HtmlTableRow();
             
                CheckBox[] ck = new CheckBox[40];
                TextBox[] tk= new TextBox[40];
                List<string> mylist = new List<string>();

              
                mylist=generate_subject(subject);
                Label lb = new Label();
                string unitName = "<h3>For "+reader[0]+" Unit </h3>";
                lb.Text = unitName;
                pan.Controls.Add(lb);

                int i = 0;
                for (i = 0; i < (mylist.Count); i++)
                {

                    ck[i] = new CheckBox();
                    tk[i] = new TextBox();
                    ck[i].ID = i.ToString();
                    tk[i].ID = i.ToString();
                    tk[i].Text = mylist[i].ToString();
                    cell = new HtmlTableCell();
                    cell1 = new HtmlTableCell();
                    cell.Controls.Add(ck[i]);
                    cell1.Controls.Add(tk[i]);
                   
                    row.Cells.Add(cell);
                    row.Cells.Add(cell1);

                    if((k%4+1)==1)
                    pan.BackColor = Color.DeepPink;
                    if((k%4+1)==2)
                    pan.BackColor =Color.Magenta;
                    if((k%4+1)==3)
                    pan.BackColor = Color.AliceBlue;
                    if((k%4+1)==4)
                    pan.BackColor = Color.MediumOrchid;

                    pan.Controls.Add(row);
                   
                  
                   // pan.Controls.Add(ck[i]);
                    
                   
                }
                
               
                if (i != 0)
                {
                  //  form1.Controls.Add(new Literal() { ID = "row", Text = "<Br/>" });
                    cnt++;
                    for (int x = 1; x <= cnt && x > 2; x++)
                    {
                        form1.Controls.Add(new Literal() { Text = "<br/><br/>" });
                        form1.Controls.Add(new Literal() { Text = "<br/><br/>" });
                    }
                    
                    form1.Controls.Add(pan);
                    for (int x = 1; x <= cnt && x > 2; x++)
                    {
                        form1.Controls.Add(new Literal() { Text = "<br/><br/>" });
                        form1.Controls.Add(new Literal() { Text = "<br/><br/>" });
                    }
                    
                }
                // Response.Write("<script>alert('" + subject + "');</script>");
                //break;

                k++;
            }
        }

        List<string> generate_subject(string str)
        {
            List<string> vector=new List<string>();
            
            int len = str.Length;
            string pre = "";
            for (int i = 0; i < len; i++)
            {
                if (str[i] == ',')
                {
                    vector.Add(pre);
                    pre = "";
                }
                else
                    pre += str[i];
            }
            return vector;
        }

    }
}