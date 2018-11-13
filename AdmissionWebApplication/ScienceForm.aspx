<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScienceForm.aspx.cs" Inherits="AdmissionWebApplication.ScienceForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Style/bootstrap.css" />
    <style type="text/css"> 
        
        body
        {
            background-color: #303030;
            background-image: url(images/page_background.jpg);
            color: #630;
            font-family: helvetica;
        }
        
        .h2
        {
            background-color: #D0D0D0;
        }
        
        .style10
        {
            width: 130px;
        }
        .style11
        {
            width: 176px;
        }
        
        .me
        {
            height: 249px;
            width: 872px;
            background: #eee;
            color: teal;
            margin-top: 120px;
            border-radius: 4px;
            -moz-border-radius: 4px;
            transition: all 1s ease-in-out;
            -webkit-transition: all 1s ease-in-out;
            -moz-transition: all 1s ease-in-out;
            padding: 20px;
            margin-left: auto;
            margin-right: auto;
            margin-bottom: 10px;
        }
        .me:hover
        {
            transition: all 1s ease-in-out;
            -webkit-transition: all 1s ease-in-out;
            -moz-transition: all 1s ease-in-out;
            transform: scale(1.02);
            -ms-transform: scale(1.02); /* IE 9 */
            -webkit-transform: scale(1.02); /* Safari and Chrome */
            -o-transform: scale(1.02); /* Opera */
            -moz-transform: scale(1.02); /* Firefox */
            background: aliceblue;
            -webkit-border-radius: 4px;
            box-shadow: 10px 10px 5px #888888;
            -webkit-box-shadow: 10px 10px 5px #888888; /* Safari */
        }
        
        .me1
        {
            height: 426px;
            width: 871px;
            background: #eee;
            color: teal;
            margin: 10px auto;
            border-radius: 4px;
            -moz-border-radius: 4px;
            transition: all 1s ease-in-out;
            -webkit-transition: all 1s ease-in-out;
            -moz-transition: all 1s ease-in-out;
            padding: 20px;
        }
        .me1:hover
        {
            transition: all 1s ease-in-out;
            -webkit-transition: all 1s ease-in-out;
            -moz-transition: all 1s ease-in-out;
            transform: scale(1.02);
            -ms-transform: scale(1.02); /* IE 9 */
            -webkit-transform: scale(1.02); /* Safari and Chrome */
            -o-transform: scale(1.02); /* Opera */
            -moz-transform: scale(1.02); /* Firefox */
            background: aliceblue;
            -webkit-border-radius: 4px;
            box-shadow: 10px 10px 5px #888888;
            -webkit-box-shadow: 10px 10px 5px #888888; /* Safari */
        }
        .style19
        {
            height: 29px;
        }
        .style24
        {
            height: 29px;
        }
        .style26
        {
            width: 372px;
            height: 26px;
        }
        .style27
        {
            height: 26px;
        }
        .style28
        {
            height: 27px;
        }
        .style29
        {
            height: 27px;
        }
        .style30
        {
        }
        .style32
        {
            height: 27px;
            width: 169px;
        }
        .style34
        {
            width: 393px;
            height: 26px;
        }
        .style35
        {
            width: 393px;
            height: 27px;
        }
        .style36
        {
            height: 26px;
            width: 178px;
        }
        .style37
        {
            height: 27px;
            width: 178px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="849px">
     <div class="me">
        <table class="table table-hover">
          
            <tr bgcolor="#8BCEDA">
                <td class="style30" bgcolor="#8BCEDA" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Lucida Fax" 
                        Font-Size="X-Large" Font-Underline="False" ForeColor="#0000CC" 
                        Text="Academic Information of Candidate"></asp:Label>
                </td>
            </tr>
            <tr bgcolor="#8BCEDA">
                <td bgcolor="#E2DF70" class="style30">
                    Candidate&nbsp;Name
                </td>
                <td bgcolor="#E2DF70" colspan="3">
                    &nbsp;
                    <asp:TextBox ID="NameTextBox" runat="server" Enabled="False" 
                        Style="margin-left: 0px" Width="307px"></asp:TextBox>
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
                <tr>
                    <td class="style30" bgcolor="#E2DF70">
                        SSC Roll
                    </td>
                    <td class="style10" bgcolor="#E2DF70">
                        <asp:TextBox ID="SSCRollTextBox" runat="server" Enabled="False" 
                            style="margin-left: 8px" Width="207px"></asp:TextBox>
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
                    <td bgcolor="#E2DF70">
                        &nbsp;
                        <asp:TextBox ID="SSCResultTextBox" runat="server" Enabled="False"></asp:TextBox>
                    </td>
                    <td bgcolor="#E2DF70">
                        &nbsp;</td>
                    <td bgcolor="#E2DF70">
                        &nbsp;</td>
                </tr>
            </tr>
        </table>
        </div>
        <div class="me1">
        <table class="table table-hover">
            <tr>
                <td colspan="4" class="style19" bgcolor="#FFCCFF">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Lucida Fax" 
                        Font-Size="X-Large" ForeColor="#0000CC" Text="Grade Points of Candidate (HSC)"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style26" bgcolor="#F7D1B9">
                    &nbsp;Bangla
                </td>
                <td class="style36" bgcolor="#F7D1B9">
                    <asp:TextBox ID="BanglaTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
                 <td class="style34" bgcolor="#F7D1B9">
                     English</td>
                <td class="style27" bgcolor="#F7D1B9">
                    <asp:TextBox ID="EnglishTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style26" bgcolor="#F7D1B9">
                    Physics</td>
                <td class="style36" bgcolor="#F7D1B9">
                    <asp:TextBox ID="PhysicsTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="style35" bgcolor="#F7D1B9">
                    Chemistry</td>
                <td class="style29" bgcolor="#F7D1B9">
                    <asp:TextBox ID="ChemistryTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td class="style28" bgcolor="#F7D1B9">
                    Math</td>
                <td class="style37" bgcolor="#F7D1B9">
                    <asp:TextBox ID="MathTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
                 <td class="style35" bgcolor="#F7D1B9">
                     Biology</td>
                <td class="style29" bgcolor="#F7D1B9">
                    <asp:TextBox ID="BiologyTextBox" runat="server" Enabled="False" 
                        OnTextChanged="TextBox8_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style28" bgcolor="#F7D1B9">
                    ComputerScience</td>
                <td class="style37" bgcolor="#F7D1B9">
                    <asp:TextBox ID="CSTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td> 
                <td class="style28" bgcolor="#F7D1B9">
                    Statistics</td>
                <td class="style32" bgcolor="#F7D1B9">
                    <asp:TextBox ID="StateTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td> 
            </tr>
            <tr>
                <td class="style28" bgcolor="#F7D1B9">
                    Agriculture</td>
                <td class="style37" bgcolor="#F7D1B9">
                    <asp:TextBox ID="AgricultureTextBox" runat="server" Enabled="False"></asp:TextBox>
                    
                </td>
                 <td class="style28" bgcolor="#F7D1B9">
                     English (SSC)</td>
                <td class="style32" bgcolor="#F7D1B9">
                    <asp:TextBox ID="SSCEnglishTextBox" runat="server" Enabled="False"></asp:TextBox>
                    
                </td>
            </tr>
            <tr bgcolor="#9D8AA8">
                <td class="style28" bgcolor="#9D8AA8" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Total 
                    GPA&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="HSCResultTextBox" runat="server" Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style24" bgcolor="#B5AF8C" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="backButton" runat="server" OnClick="backButton_Click" class="btn btn-warning"
                        Text="Back" Width="128px" Height="38px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="submitButton" runat="server" class="btn btn-primary" data-loading-text="Loading..."
                        Height="42px" OnClick="submitButton_Click" Text="Submit" Width="124px" />
                </td>
            </tr>
        </table>
        </div>
    </asp:Panel>
    </form>
</body>
</html>
