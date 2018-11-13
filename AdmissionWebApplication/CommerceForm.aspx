<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommerceForm.aspx.cs" Inherits="AdmissionWebApplication.CommerceForm" %>

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
        .style2
        {
        }
        .style37
        {
            height: 13px;
        }
        .style39
        {
            height: 7px;
        }
        .style41
        {
            height: 13px;
            
        }
        .style42
        {
            height: 7px;
            width: 181px;
        }
        .style43
        {
            width: 181px;
        }
        .style44
        {
            height: 13px;
            width: 200px;
        }
        .style45
        {
            height: 7px;
           
        }
        .style46
        {
            width: 220px;
        }
        .style47
        {
            height: 13px;
            width: 220px;
        }
        .style48
        {
            height: 7px;
            width: 220px;
        }
        .style49
        {
            height: 15px;
        }
        .style50
        {
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="me">
        <table class="table table-hover">
          
            <tr>
                <td class="style50" bgcolor="#8BCEDA" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" 
                        runat="server" Font-Bold="True" Font-Names="Lucida Fax" Font-Size="X-Large" 
                        ForeColor="#0000CC" Text="Academic Information of Candidate"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
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
                            style="margin-left: 8px" Width="205px"></asp:TextBox>
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
                        SSCResult</td>
                    <td colspan="3" bgcolor="#E2DF70">
                        &nbsp;
                        <asp:TextBox ID="SSCResultTextBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </tr>
        </table>
        </div>

    <div class="me1">
        <table class="table table-hover">
            <tr>
                <td colspan="4" bgcolor="#FFCCFF" class="style50">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                        ID="Label1" runat="server" Font-Bold="True" Font-Names="Lucida Fax" 
                        Font-Size="X-Large" ForeColor="#0000CC" Text="Grade Points of Candidate (HSC)"></asp:Label>
                </td>
            </tr>
           
            <tr>
                <td class="style2" bgcolor="#F7D1B9">
                    Bangla</td>
                <td bgcolor="#F7D1B9" class="style46">
                    <asp:TextBox ID="BanglaTextBox" runat="server" Enabled="False" 
                        style="margin-left: 0px"></asp:TextBox>
                </td>
                <td class="style43" bgcolor="#F7D1B9">
                    English</td>
                <td bgcolor="#F7D1B9">
                    <asp:TextBox ID="EnglishTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" bgcolor="#F7D1B9">
                    Accounting</td>
                <td bgcolor="#F7D1B9" class="style46">
                    <asp:TextBox ID="AccountingTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="style43" bgcolor="#F7D1B9">
                    Finance</td>
                <td bgcolor="#F7D1B9">
                    <asp:TextBox ID="FinanceTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style44" bgcolor="#F7D1B9">
                    Management</td>
                <td class="style47" bgcolor="#F7D1B9">
                    <asp:TextBox ID="ManagementTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="style41" bgcolor="#F7D1B9">
                    Computer Science</td>
                <td class="style37" bgcolor="#F7D1B9">
                    <asp:TextBox ID="CSTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style45" bgcolor="#F7D1B9">
                    Agriculture</td>
                <td class="style48" bgcolor="#F7D1B9">
                    <asp:TextBox ID="AgricultureTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="style42" bgcolor="#F7D1B9">
                    Economics</td>
                <td class="style39" bgcolor="#F7D1B9">
                    <asp:TextBox ID="EconomicsTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2" bgcolor="#F7D1B9">
                    Math</td>
                <td bgcolor="#F7D1B9" class="style46">
                    <asp:TextBox ID="MathTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="style43" bgcolor="#F7D1B9">
                    SSC (English)</td>
                <td bgcolor="#F7D1B9">
                    <asp:TextBox ID="SSCEnglishTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style49" bgcolor="#9D8AA8" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    TotalGPA<asp:TextBox ID="GPATextBox" runat="server" Enabled="False" 
                        style="margin-left: 89px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style19" bgcolor="#B5AF8C" colspan="4">
                    <asp:Button ID="backButton" runat="server" onclick="backButton_Click" 
                        class="btn btn-warning" Text="Back" Height="35px" style="margin-left: 202px" Width="94px" />
                    <asp:Button ID="submitButton" runat="server" onclick="submitButton_Click" 
                        class="btn btn-primary" data-loading-text="Loading..." Text="Submit" Height="35px" 
                        style="margin-left: 306px" Width="107px" />
                </td>
            </tr>
            <tr>
                <td class="style2" bgcolor="#B5AF8C">
                    &nbsp;</td>
                <td bgcolor="#B5AF8C" class="style46">
                    &nbsp;</td>
                <td class="style43" bgcolor="#B5AF8C">
                    &nbsp;</td>
                <td bgcolor="#B5AF8C">
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
