<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AdmissionWebApplication.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
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
        <br/>
        <br/>
        <br/>
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
    </form>
</body>
</html>
