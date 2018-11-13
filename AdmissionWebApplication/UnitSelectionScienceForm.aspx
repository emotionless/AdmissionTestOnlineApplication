<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnitSelectionScienceForm.aspx.cs"
    Inherits="AdmissionWebApplication.UnitSelectionScienceForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
    <link href="Style/ScienceStyle.css" rel="stylesheet" type="text/css" />
    
    <style>
      
        
        .style1
        {
            width: 99%;
            height: 152px;
        }
        
        
        .style2
        {
            width: 120px;
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
        .style13
        {
            width: 104%;
        }
        .style14
        {
            width: 169px;
        }
        .style15
        {
            width: 100%;
            height: 23px;
        }
        .style16
        {
            width: 138px;
        }
        
        
        .style17
        {
            width: 142px;
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
        {            height: 47px;
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
            height: 18px;
        }
        
        
        .style160
        {
            width: 100%;
        }
        .style161
        {
            width: 49px;
        }
        
        
    </style> 
   
</head>
<body style="height: 647px; width: 1305px;">
    <form id="form1" runat="server">
    <div id="outer">
        <div id="first">
         <asp:Panel ID="Panel1" runat="server">
            <h1>A Unit</h1>
            <table class="style1">
                <tr>
                    <td class="style2">
                        <asp:CheckBox ID="CSECheckBox" runat="server" AutoPostBack="True" Text="CSE" 
                            oncheckedchanged="CSECheckBox_CheckedChanged" BorderColor="Silver" />
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="CSETextBox" runat="server" AutoPostBack="True" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:CheckBox ID="MathCheckBox" runat="server" AutoPostBack="True" 
                            Text="Math" oncheckedchanged="MathCheckBox_CheckedChanged" />
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="MathTextBox" runat="server" AutoPostBack="True" 
                            Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:CheckBox ID="PhysicsCheckBox" runat="server" AutoPostBack="True" 
                            Text="Physics" oncheckedchanged="PhysicsCheckBox_CheckedChanged" />
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="PhysicsTextBox" runat="server" AutoPostBack="True" 
                            Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:CheckBox ID="StatisticsCheckBox" runat="server" AutoPostBack="True" 
                            Text="Statistics" oncheckedchanged="StatisticsCheckBox_CheckedChanged" />
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="StatisticsTextBox" runat="server" AutoPostBack="True" 
                            Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:CheckBox ID="ESCheckBox" runat="server" AutoPostBack="True" Text="ES" 
                            oncheckedchanged="ESCheckBox_CheckedChanged" />
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="ESTextBox" runat="server" AutoPostBack="True" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:CheckBox ID="GSCheckBox" runat="server" AutoPostBack="True" Text="GS" 
                            oncheckedchanged="GSCheckBox_CheckedChanged" />
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="GSTextBox" runat="server" AutoPostBack="True" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        <asp:CheckBox ID="ChemistryCheckBox" runat="server" AutoPostBack="True" 
                            Text="Chemistry" oncheckedchanged="ChemistryCheckBox_CheckedChanged" />
                    </td>
                    <td class="style3">
                        <asp:TextBox ID="ChemistryTextBox" runat="server" AutoPostBack="True" 
                            Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
            </table>
           </asp:Panel>
        </div>
        <div id="second">
           <asp:Panel ID="Panel2" runat="server" Height="251px" Width="286px">
            <h1>B Unit</h1>
          
               <table class="style1">
                    <tr>
                        <td class="style4">
                            <asp:CheckBox ID="EconomicsCheckBox" runat="server" AutoPostBack="True" 
                                Text="Economics" oncheckedchanged="EconomicsCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="EconomicsTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:CheckBox ID="URPCheckBox" runat="server" AutoPostBack="True" Text="URP" 
                                oncheckedchanged="URPCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="URPTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:CheckBox ID="AnthropologyCheckBox" runat="server" AutoPostBack="True" 
                                Text="Anthro" oncheckedchanged="AnthropologyCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="AnthropologyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:CheckBox ID="GeographyCheckBox" runat="server" AutoPostBack="True" 
                                Text="Geography" oncheckedchanged="GeographyCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="GeographyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:CheckBox ID="GPCheckBox" runat="server" AutoPostBack="True" Text="GP" 
                                oncheckedchanged="GPCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="GPTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            <asp:CheckBox ID="PACheckBox" runat="server" AutoPostBack="True" Text="PA" 
                                oncheckedchanged="PACheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="PATextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <div id="third">
        <asp:Panel ID="Panel3" runat="server">
            <h1> C Unit</h1>
            <table class="style5">
                <tr>
                    <td class="style8">
                        <asp:CheckBox ID="IRCheckBox" runat="server" AutoPostBack="True" Text="IR" 
                            oncheckedchanged="IRCheckBox_CheckedChanged" />
                    </td>
                    <td class="style7">
                        <asp:TextBox ID="IRTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="EnglishCheckBox" runat="server" AutoPostBack="True" 
                            Text="English" oncheckedchanged="EnglishCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="EnglishTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style10">
                        <asp:CheckBox ID="HistoryCheckBox" runat="server" AutoPostBack="True" 
                            Text="History" oncheckedchanged="HistoryCheckBox_CheckedChanged" />
                    </td>
                    <td class="style6">
                        <asp:TextBox ID="HistoryTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="PhilosophyCheckBox" runat="server" AutoPostBack="True" 
                            Text="Philosophy" oncheckedchanged="PhilosophyCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="PhilosophyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="DramaCheckBox" runat="server" AutoPostBack="True" 
                            Text="Drama" oncheckedchanged="DramaCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="DramaTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="ArchiologyCheckBox" runat="server" AutoPostBack="True" 
                            Text="Archiology" oncheckedchanged="ArchiologyCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="ArchiologyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style11">
                        <asp:CheckBox ID="BanglaCheckBox" runat="server" AutoPostBack="True" 
                            Text="Bangla" oncheckedchanged="BanglaCheckBox_CheckedChanged" />
                    </td>
                    <td class="style12">
                        <asp:TextBox ID="BanglaTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style9">
                        <asp:CheckBox ID="JournalismCheckBox" runat="server" AutoPostBack="True" 
                            Text="Journalism" oncheckedchanged="JournalismCheckBox_CheckedChanged" />
                    </td>
                    <td>
                        <asp:TextBox ID="JournalismTextBox" runat="server" Enabled="False">0</asp:TextBox>
                    </td>
                </tr>
            </table>
            </asp:Panel>
        </div>
         <div id="first1">
           <asp:Panel ID="Panel4" runat="server">
            <h1>
                D Unit</h1>
             <table class="style13">
                 <tr>
                     <td class="style14">
                         <asp:CheckBox ID="BotanyCheckBox" runat="server" Text="Botany" 
                             AutoPostBack="True" oncheckedchanged="BotanyCheckBox_CheckedChanged" />
                     </td>
                     <td>
                         <asp:TextBox ID="BotanyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td class="style14">
                         <asp:CheckBox ID="ZoologyCheckBox" runat="server" Text="Zoology" 
                             AutoPostBack="True" oncheckedchanged="ZoologyCheckBox_CheckedChanged" />
                     </td>
                     <td>
                         <asp:TextBox ID="ZoologyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td class="style14">
                         <asp:CheckBox ID="PharmacyCheckBox" runat="server" Text="Pharmacy" 
                             AutoPostBack="True" oncheckedchanged="PharmacyCheckBox_CheckedChanged" />
                     </td>
                     <td>
                         <asp:TextBox ID="PharmacyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td class="style14">
                         <asp:CheckBox ID="BiochemistryCheckBox" runat="server" Text="Biochemistry" 
                             AutoPostBack="True" oncheckedchanged="BiochemistryCheckBox_CheckedChanged" />
                     </td>
                     <td>
                         <asp:TextBox ID="BiochemistryTextBox" runat="server" Enabled="False">0</asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td class="style14">
                         <asp:CheckBox ID="GEBCheckBox" runat="server" Text="GEB" AutoPostBack="True" 
                             oncheckedchanged="GEBCheckBox_CheckedChanged" />
                     </td>
                     <td>
                         <asp:TextBox ID="GEBTextBox" runat="server" Enabled="False">0</asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td class="style14">
                         <asp:CheckBox ID="PBHCheckBox" runat="server" Text="PBH" AutoPostBack="True" 
                             oncheckedchanged="PBHCheckBox_CheckedChanged" />
                     </td>
                     <td>
                         <asp:TextBox ID="PBHTextBox" runat="server" Enabled="False">0</asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td class="style14">
                         <asp:CheckBox ID="MicrobiologyCheckBox" runat="server" Text="Microbiology" 
                             AutoPostBack="True" oncheckedchanged="MicrobiologyCheckBox_CheckedChanged" />
                     </td>
                     <td>
                         <asp:TextBox ID="MicrobiologyTextBox" runat="server" Enabled="False">0</asp:TextBox>
                     </td>
                 </tr>
             </table>
             </asp:Panel>
        </div>
          <div id="second1">
          <asp:Panel ID="Panel5" runat="server">
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
                    <tr>
                        <td class="style16">
                            <asp:CheckBox ID="MarketingCheckBox" runat="server" AutoPostBack="True" 
                                Text="Marketing" oncheckedchanged="MarketingCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="MarketingTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            <asp:CheckBox ID="AISCheckBox" runat="server" AutoPostBack="True" Text="AIS" 
                                oncheckedchanged="AISCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="AISTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style16">
                            <asp:CheckBox ID="MSCheckBox" runat="server" AutoPostBack="True" Text="MS" 
                                oncheckedchanged="MSCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="MSTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
                </table>
            </p>
            </asp:Panel>
        </div>
        <div id="third1">
          <asp:Panel ID="Panel6" runat="server">
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
        <div id="third2">
          <asp:Panel ID="Panel7" runat="server">
            <h1>
                G Unit</h1>
                <table class="style15">
                    <tr>
                        <td class="style18">
                            <asp:CheckBox ID="LawCheckBox" runat="server" Text="Law" AutoPostBack="True" 
                                oncheckedchanged="LawCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="LawTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
            </table> 
            </asp:Panel>
        </div>
        <div id="third3">
            <asp:Panel ID="Panel8" runat="server">
            <h1>H Unit</h1>
                <table class="style15">
                    <tr>
                        <td class="style17">
                            <asp:CheckBox ID="IITCheckBox" runat="server" Text="IIT" AutoPostBack="True" 
                                oncheckedchanged="IITCheckBox_CheckedChanged" />
                        </td>
                        <td>
                            <asp:TextBox ID="IITTextBox" runat="server" Enabled="False">0</asp:TextBox>
                        </td>
                    </tr>
            </table>
            </asp:Panel>
        </div>  
    </div>
    <div id="outer1">
        
         <table class="style155">
            <tr>
                <td class="style159" colspan="2" >
                                       <h2>&nbsp;&nbsp;&nbsp;&nbsp; Amount</h2></td>
            </tr>
            <tr>
                <td class="style157" >
                    &nbsp; Total&nbsp; <td class="style158" 
                    >
                    <asp:TextBox ID="amountTextBox" runat="server" Height="26px" Enabled="False" 
                        style="margin-left: 2px">0</asp:TextBox>
                </td>
            </tr>
          
            
        </table>
        <table class="style155">
            <tr>
                <td class="style20" colspan="2" >
                                       <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cost</h2></td>
            </tr>
            <tr>
                <td class="style157" >
                    &nbsp; Total&nbsp; <td class="style158">
                    <asp:TextBox ID="TotalTextBox" runat="server" Height="26px" Enabled="False" 
                        style="margin-left: 2px">0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2" >
                    <asp:Button ID="SubmitButton" runat="server" BackColor="Blue" ForeColor="White" 
                        Height="43px" style="margin-left: 58px" Text="Submit" Width="90px" 
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
            <br />
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
