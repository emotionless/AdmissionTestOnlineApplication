using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
namespace AdmissionWebApplication
{
    public partial class TablePictures : System.Web.UI.Page
    {

      

        protected void Page_Load(object sender, System.EventArgs e)
        {
            {
                HtmlTable table1 = new HtmlTable();

                table1.Border = 1;
                table1.CellPadding = 3;
                table1.CellSpacing = 3; 
                table1.BorderColor = "red";

                HtmlTableRow row;
                HtmlTableCell cell;
                for (int i = 1; i <= 5; i++)
                {
                    row = new HtmlTableRow();
                    row.BgColor = (i % 2 == 0 ? "lightyellow" : "lightcyan");

                    for (int j = 1; j <= 4; j++)
                    {
                        cell = new HtmlTableCell();
                        cell.InnerHtml = "Row: " + i.ToString() + "<br>Cell: " + j.ToString();
                        row.Cells.Add(cell);
                    } 

                    table1.Rows.Add(row);
                }
                this.Controls.Add(table1);
            }
        }

       
    }
}