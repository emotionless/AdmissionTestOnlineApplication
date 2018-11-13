<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArtsForm.aspx.cs" Inherits="AdmissionWebApplication.ArtsForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/InfoStyleSheet.css" rel="stylesheet" type="text/css" />
    <link href="Style/bootstrap.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 100%;
            border: 1px solid #808000;
            background-color: #FFFFFF;
        }
        .style4
        {
            width: 243px;
        }
        .style39
        {
            width: 163px;
        }
        .style40
        {
        }
        .style41
        {
            height: 30px;
        }
        .style42
        {
            height: 34px;
        }
        .style43
        {
            height: 41px;
        }
    </style>
</head>
<body style="width: 1265px; height: 804px;">
    <form id="form1" runat="server">
    <div class="me">
        <table class="table table-hover">
          
            <tr>
                <td class="style42" bgcolor="#8BCEDA" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
                        Font-Underline="False" ForeColor="#0000CC" 
                        Text="Academic Information of Candidate" Font-Names="Lucida Fax"></asp:Label>
                </td>
            </tr>
          
            <tr>
                <td class="style30" bgcolor="#E2DF70">
                    Candidate&nbsp;Name
                </td>
                <td colspan="3" bgcolor="#E2DF70">
                    &nbsp;
                    <asp:TextBox ID="NameTextBox" runat="server" Enabled="False" Style="margin-left: 0px"
                        Width="307px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style30" bgcolor="#E2DF70">
                    HSC Roll
                </td>
                <td class="style10" bgcolor="#E2DF70">
                    <asp:TextBox ID="HSCRollTextBox" runat="server" Enabled="False" 
                        style="margin-left: 9px"></asp:TextBox>
                </td>
                <td class="style11" bgcolor="#E2DF70">
                    Passing Year
                </td>
                <td bgcolor="#E2DF70">
                    <asp:TextBox ID="SessionTextBox" runat="server" Enabled="False" 
                        Style="margin-left: 0px"></asp:TextBox>
                </td>
                </tr>
                <tr>
                    <td class="style30" bgcolor="#E2DF70">
                        SSC Roll
                    </td>
                    <td class="style10" bgcolor="#E2DF70">
                        <asp:TextBox ID="SSCRollTextBox" runat="server" Enabled="False" 
                            style="margin-left: 8px" Width="128px"></asp:TextBox>
                    </td>
                    <td class="style11" bgcolor="#E2DF70">
                        Board
                    </td>
                    <td bgcolor="#E2DF70">
                        <asp:TextBox ID="BoardTextBox" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style30" bgcolor="#E2DF70">
                        SSC Result</td>
                    <td colspan="3" bgcolor="#E2DF70">
                        &nbsp;
                        <asp:TextBox ID="SSCResultTextBox" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                </tr>
        </table>
        </div>
   <div class="me1">
    <table class="table table-hover">
        <tr>
            <td class="style43" colspan="4" bgcolor="#FFCCFF">
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    Text="Grade Points  of Candidate (HSC)" ForeColor="#0000CC" 
                    Font-Names="Lucida Fax"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style40" bgcolor="#F7D1B9">
                Bangla</td>
            <td class="style39" bgcolor="#F7D1B9">
                <asp:TextBox ID="BanglaTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style4" bgcolor="#F7D1B9">
                English</td>
            <td class="style4" bgcolor="#F7D1B9">
                <asp:TextBox ID="EnglishTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style40" bgcolor="#F7D1B9">
                Economics</td>
            <td class="style39" bgcolor="#F7D1B9">
                <asp:TextBox ID="EconomicsTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style4" bgcolor="#F7D1B9">
                Civis</td>
            <td class="style4" bgcolor="#F7D1B9">
                <asp:TextBox ID="CivisTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td class="style40" bgcolor="#F7D1B9">
                Psycology</td>
            <td class="style39" bgcolor="#F7D1B9">
                <asp:TextBox ID="PsycologyTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style4" bgcolor="#F7D1B9">
                Math</td>
            <td class="style4" bgcolor="#F7D1B9">
                <asp:TextBox ID="MathTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td class="style40" bgcolor="#F7D1B9">
                Computer Science</td>
            <td class="style39" bgcolor="#F7D1B9">
                <asp:TextBox ID="CSTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style4" bgcolor="#F7D1B9">
                Statistics</td>
            <td class="style4" bgcolor="#F7D1B9">
                <asp:TextBox ID="StatisticsTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style40" bgcolor="#F7D1B9">
                English (SSC)</td>
            <td class="style39" bgcolor="#F7D1B9">
                <asp:TextBox ID="SSCEnglishTextBox" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td class="style4" bgcolor="#F7D1B9">
                &nbsp;</td>
            <td class="style4" bgcolor="#F7D1B9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style40" bgcolor="#9D8AA8" colspan="4">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Total
                GPA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="GPATextBox" runat="server" Enabled="False" Height="26px" 
                    Width="115px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style41" colspan="4" bgcolor="#B5AF8C">
        <asp:Button ID="backButton" runat="server" Text="Back" class="btn btn-warning" 
            onclick="backButton_Click1" Height="38px" style="margin-left: 257px" Width="96px"/>
                <asp:Button ID="submitButton" runat="server" class="btn btn-primary"
                    Text="Submit" Height="34px" style="margin-left: 199px" Width="92px" 
                    onclick="submitButton_Click" />
            </td>
        </tr>
    </table>

    </div>
    </form>
</body>
</html>
