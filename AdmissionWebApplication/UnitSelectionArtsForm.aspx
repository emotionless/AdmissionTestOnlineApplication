<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnitSelectionArtsForm.aspx.cs"
    Inherits="AdmissionWebApplication.UnitSelectionArtsForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head id="Head1" runat="server">
    <title></title>
   <link href="Style/Style.css" rel="stylesheet" type="text/css" />
  
    <style>
        .style1
        {
            width: 103%;
            height: 182px;
        }
        
        
        .style3
        {
        }
        
        
        .style4
        {
            width: 133px;
        }
        
        
        .style5
        {
            width: 100%;
            height: 181px;
        }
        .style6
        {
            height: 21px;
        }
        .style7
        {
            height: 22px;
        }
        .style8
        {
            height: 22px;
            width: 134px;
        }
        .style9
        {
            width: 134px;
        }
        .style10
        {
            height: 21px;
            width: 134px;
        }
        .style11
        {
            width: 134px;
            height: 26px;
        }
        .style12
        {
            height: 26px;
        }
        .style15
        {
            width: 100%;
        }
                
        
        .style18
        {
            width: 143px;
        }
        .style19
        {
            width: 165px;
        }
        
        
        #form1
        {
            width: 1299px;
            height: 709px;
        }
        
        
        .style20
        {
            height: 47px;
        }
        
        
        .style155
        {
            height: 132px;
            width: 198px;
        }
        
        
        .style157
        {
            width: 104px;
            height: 27px;
        }
        .style158
        {
            height: 27px;
        }
        .style159
        {
            width: 143px;
            height: 18px;
        }
        .style160
        {
            height: 18px;
        }
        .style16
        {
            width: 138px;
        }
        
        
        </style>
</head>
<body style="height: 635px; width: 1305px;">
    <form id="form1" runat="server">
    <div id="outer">
        <div id="second">
            <asp:Panel ID="PanelB" runat="server">
            <h1>B Unit</h1>
            <br />
            <table class="style1">
                <tr>
                    <td class="style4">
                        <asp:CheckBox ID="EconomicsCheckBox" runat="server" AutoPostBack="True" Text="Economics"
                            OnCheckedChanged="EconomicsCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="EconomicsTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:CheckBox ID="URPCheckBox" runat="server" AutoPostBack="True" Text="URP" OnCheckedChanged="URPCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="URPTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:CheckBox ID="AnthropologyCheckBox" runat="server" AutoPostBack="True" Text="Anthro"
                            OnCheckedChanged="AnthropologyCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="AnthropologyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:CheckBox ID="GeographyCheckBox" runat="server" AutoPostBack="True" Text="Geography"
                            OnCheckedChanged="GeographyCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="GeographyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:CheckBox ID="GPCheckBox" runat="server" AutoPostBack="True" Text="GP" OnCheckedChanged="GPCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="GPTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:CheckBox ID="PACheckBox" runat="server" AutoPostBack="True" Text="PA" OnCheckedChanged="PACheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="PATextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
            </table>
            </asp:Panel>
        </div>
        <div id="third">
          <asp:Panel ID="PanelC" runat="server">
            <h1>
                C Unit</h1>
            <table class="style5">
                <tr>
                    <td class="style8">
                        <asp:CheckBox ID="IRCheckBox" runat="server" AutoPostBack="True" Text="IR" OnCheckedChanged="IRCheckBox_CheckedChanged" />
                    </td>
                    <td class="style7">
                        <asp:TextBox ID="IRTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="EnglishCheckBox" runat="server" AutoPostBack="True" Text="English"
                            OnCheckedChanged="EnglishCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="EnglishTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style10">
                        <asp:CheckBox ID="HistoryCheckBox" runat="server" AutoPostBack="True" Text="History"
                            OnCheckedChanged="HistoryCheckBox_CheckedChanged" />
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="HistoryTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="PhilosophyCheckBox" runat="server" AutoPostBack="True" Text="Philosophy"
                            OnCheckedChanged="PhilosophyCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="PhilosophyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="DramaCheckBox" runat="server" AutoPostBack="True" Text="Drama"
                            OnCheckedChanged="DramaCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="DramaTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="ArchiologyCheckBox" runat="server" AutoPostBack="True" Text="Archiology"
                            OnCheckedChanged="ArchiologyCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="ArchiologyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:CheckBox ID="BanglaCheckBox" runat="server" AutoPostBack="True" Text="Bangla"
                            OnCheckedChanged="BanglaCheckBox_CheckedChanged" />
                    </td>
                    <td class="style12">
                        <asp:TextBox ID="BanglaTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="JournalismCheckBox" runat="server" AutoPostBack="True" Text="Journalism"
                            OnCheckedChanged="JournalismCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="JournalismTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
            </table>
            </asp:Panel>
        </div>
        <div id="third2">
           <asp:Panel ID="PanelG" runat="server">
            <h1>
                G Unit</h1>
            <table class="style15">
                <tr>
                    <td class="style159">
                        <asp:CheckBox ID="LawCheckBox" runat="server" Text="Law" AutoPostBack="True" OnCheckedChanged="LawCheckBox_CheckedChanged" />
                    </td>
                    <td class="style160">
                        <asp:TextBox ID="LawTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
            </table>
            </asp:Panel>
        </div>
          <div id="second1">
          <asp:Panel ID="PanelE" runat="server">
            <h1>
                E Unit</h1>
            <p>
                
                <table class="style15">
                    <tr>
                        <td class="style16">
                            <asp:CheckBox ID="FBCheckBox" runat="server" AutoPostBack="True" Text="FB" 
                                oncheckedchanged="FBCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="FBTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                    
                </table>
            </p>
            </asp:Panel>
        </div>
        <div id="third1">
          <asp:Panel ID="PanelF" runat="server">
            <h1>
                F Unit</h1>
                <table class="style15">
                    <tr>
                        <td class="style19">
                            <asp:CheckBox ID="IBACheckBox" runat="server" Text="IBA" AutoPostBack="True" 
                                oncheckedchanged="IBACheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="IBATextBox" runat="server" Enabled="False" 
                                EnableTheming="True">0</asp:TextBox>
                        </td>
                    </tr>
            </table>
            </asp:Panel>
        </div>
        <div id="outer1">
            <table class="style155">
                <tr>
                    <td class="style20" colspan="2">
                        <h2>
                            &nbsp;&nbsp;&nbsp;&nbsp; Amount</h2>
                    </td>
                </tr>
                <tr>
                    <td class="style157">
                        &nbsp; Total&nbsp;
                    </td>
                    <td class="style158">
                        <asp:TextBox ID="amountTextBox" runat="server" Height="26px" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
               
            </table>
            <table class="style155">
                <tr>
                    <td class="style20" colspan="2">
                        <h2>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cost</h2>
                    </td>
                </tr>
                <tr>
                    <td class="style157">
                        &nbsp; Total&nbsp;
                    </td>
                    <td class="style158">
                        <asp:TextBox ID="TotalTextBox" runat="server" Height="26px" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style3" colspan="2">
                        <asp:Button ID="SubmitButton" runat="server" BackColor="Blue" 
                            ForeColor="White" Height="43px"
                            Style="margin-left: 58px" Text="Submit" Width="90px" 
                            onclick="SubmitButton_Click" />
                    </td>
                </tr>
            </table>
             <asp:Button ID="BackButton" runat="server" Height="37px" 
            onclick="BackButton_Click" style="margin-left: 65px; margin-bottom: 0px" 
            Text="Back" Width="84px" BackColor="#FF9900" ForeColor="White" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
             </table> 
              <table class="style160">
             <tr>
                 <td bgcolor="Yellow" colspan="2">
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label 
                         ID="Label1" runat="server" Font-Bold="True" Font-Names="Vani" 
                         ForeColor="#0000B7" Text="Symbol"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td bgcolor="#333399" class="style161">
                     &nbsp;</td>
                 <td bgcolor="#333399">
                     &nbsp;</td>
             </tr>
             <tr>
                 <td bgcolor="#333399" class="style161">
                     <asp:Label ID="Label2" runat="server" BackColor="Red" ForeColor="Red" 
                         Text="Red"></asp:Label>
                 </td>
                 <td bgcolor="#333399">
                     <asp:Label ID="Label3" runat="server" ForeColor="#FF9900" Text="Not Allowed"></asp:Label>
                 </td>
             </tr>
             <tr>
                 <td bgcolor="#333399" class="style161">
                     <asp:Label ID="Label4" runat="server" BackColor="#00CC00" ForeColor="#33CC33" 
                         Text="Gre"></asp:Label>
                 </td>
                 <td bgcolor="#333399">
                     <asp:Label ID="Label5" runat="server" ForeColor="#FF9933" 
                         Text="Already Submitted"></asp:Label>
                 </td>
             </tr>
         </table>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
