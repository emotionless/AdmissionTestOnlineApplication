<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InitForm.aspx.cs" Inherits="AdmissionWebApplication.InitForm" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="Style/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="JS/bootstrap.js" type="text/javascript"></script>
    <script src="JS/bootstrap.min.js" type="text/javascript"></script>
    <style type="text/css">
        body
        {
            background: url(images/page_background.jpg);
            color: #630;
            font-family: helvetica;
            width: 1320px;
            height: 612px;
        }
         
        .me
        {
            height: 462px;
            width: 905px;
            background: #eee;
            text-align:center;
            color:Teal; 
            margin-top: 164px;
            border-radius: 4px;
            -moz-border-radius: 4px;
            transition: all 1s ease-in-out;
            -webkit-transition: all 1s ease-in-out;
            -moz-transition: all 1s ease-in-out;
            padding: 20px;
            margin-left: 205px;
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
        
         
        .style3
        {
            width: 359px;
        }
        .style4
        {
        }
        .style5
        {
            width: 508px;
        }
        .style6
        {
            width: 529px;
        }
             
        .style7
        {
            height: 50px;
        }
        
  
             
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="me">
      <table>
      <tr>
      <td   bgcolor="Black" class="style7">
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Century" 
              Font-Size="XX-Large" ForeColor="#CC0000" Text="JU Admission Helpline"></asp:Label>
      </td>
            </tr>
            <tr>
                 <td  colspan="2" bgcolor="Black">
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Lucida Fax" 
                         Font-Size="X-Large" ForeColor="#FF6600" Text="Log In"></asp:Label>
                     <br />
                     <br />
                     <br />
                 </td>
            </tr>
      </table>
    
        <table class="table table-condensed">
            
            <tr>
                 <td class="style6" bgcolor="#A2B0C4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Group</td>
                <td bgcolor="#A2B0C4">
                    <asp:DropDownList ID="GroupList" runat="server">
                        <asp:ListItem Selected="True">Science</asp:ListItem>
                        <asp:ListItem>Commerce</asp:ListItem>
                        <asp:ListItem>Huminities</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style6" bgcolor="#A2B0C4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Board</td>
                <td class="style3" bgcolor="#A2B0C4">
                    <asp:DropDownList ID="BoardList" runat="server" 
                        >
                        <asp:ListItem>Dhaka</asp:ListItem>
                        <asp:ListItem>Chittagong</asp:ListItem>
                        <asp:ListItem>Rajshahi</asp:ListItem>
                        <asp:ListItem>Jessore</asp:ListItem>
                        <asp:ListItem>Barisal</asp:ListItem>
                        <asp:ListItem>Shylet</asp:ListItem>
                        <asp:ListItem>Comilla</asp:ListItem>
                        <asp:ListItem>Madrasha</asp:ListItem>
                        <asp:ListItem>Technical</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style6" bgcolor="#A2B0C4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; HSCRoll</td>
                <td class="style5" bgcolor="#A2B0C4">
                    <asp:TextBox ID="HSCRollTextBox" runat="server" class="input-small" placeholder="Type HSC Roll" Height="23px" Width="207px" required></asp:TextBox>
                  
                    <asp:FilteredTextBoxExtender ID="HSCRollTextBox_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" FilterType="Numbers" 
                        TargetControlID="HSCRollTextBox">
                    </asp:FilteredTextBoxExtender>
&nbsp;<asp:RangeValidator ID="HSCRangeValidator" runat="server" ControlToValidate="HSCRollTextBox" 
                        ErrorMessage="HSC Roll within 6 digit" ForeColor="Red" MaximumValue="999999" 
                        MinimumValue="100000" Type="Integer"></asp:RangeValidator>
                  
                </td>
            </tr>
            <tr>
                <td class="style6" bgcolor="#A2B0C4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; SSCRoll</td>
                <td class="style3" bgcolor="#A2B0C4">
                    <asp:TextBox ID="SSCRollTextBox" runat="server" class="input-small" placeholder="Type SSC Roll" Height="26px" Width="206px" required ></asp:TextBox>
                   
                    <asp:FilteredTextBoxExtender ID="SSCRollTextBox_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" FilterType="Numbers" 
                        TargetControlID="SSCRollTextBox">
                    </asp:FilteredTextBoxExtender>
                    &nbsp;<asp:RangeValidator ID="SSC" runat="server" ControlToValidate="SSCRollTextBox" 
                        ErrorMessage="SSC Roll within 6 digit" ForeColor="Red" MaximumValue="999999" 
                        MinimumValue="100000" Type="Integer"></asp:RangeValidator>
                   
                </td>
            </tr>
            <tr>
                <td class="style6" bgcolor="#A2B0C4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Session</td>
                <td bgcolor="#A2B0C4">
                    <asp:DropDownList ID="SessionList" runat="server" Height="29px" Width="106px">
                        <asp:ListItem Selected="True">2013</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style4" colspan="2" bgcolor="#F1E3DA">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 
                      <asp:Button ID="logButton" class="btn btn-success" runat="server" onclick="logButton_Click" 
                        Text="Log in" Height="36px" Width="108px" />
                 
                   
                    </td>
            </tr>
            <tr>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    </form>
</body>
</html>
