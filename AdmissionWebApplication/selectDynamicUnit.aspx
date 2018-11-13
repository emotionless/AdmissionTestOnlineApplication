<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="selectDynamicUnit.aspx.cs" Inherits="AdmissionWebApplication.selectDynamicUnit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 182px;
        }
        .style2
        {
            width: 143px;
        }
        .style3
        {
            width: 149px;
        }
        .style4
        {
            width: 120px;
        }
        .style5
        {
            width: 120px;
            height: 23px;
        }
        .style6
        {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 494px">
    
        <table style="width:100%; height: 104px;">
            <tr>
                <td class="style1">
                    Numbers of Unit:</td>
                <td class="style3">
                    <asp:DropDownList ID="numberOfUnit" AutoPostBack="True" runat="server" Height="18px" Width="73px" 
                        onselectedindexchanged="loadForUnit">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style2">
                    Add new Subject:</td>
                <td>
                Unit:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;       
                    <asp:DropDownList ID="unit" runat="server">
                    </asp:DropDownList>
                    <br />
                    Subject:  <asp:TextBox ID="TextBox1" runat="server" Width="139px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Set" 
                        Width="69px" style="height: 26px" />
                    <br />
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                        Text="See All" />
                </td>
            </tr>
            
        </table>

        <table style="width: 100%; height: 676px;">
            <tr>
                <td class="style5">
                    <asp:Label ID="Label0" runat="server" Text="A:"></asp:Label>
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;
                    <asp:Label ID="UnitLabel0" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server" Text="B:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel1" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label2" runat="server" Text="C:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel2" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label3" runat="server" Text="D:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel3" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label4" runat="server" Text="E:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel4" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label5" runat="server" Text="F:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel5" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label6" runat="server" Text="G:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel6" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label7" runat="server" Text="H:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel7" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label8" runat="server" Text="I:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel8" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label9" runat="server" Text="J:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel9" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label10" runat="server" Text="K:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel10" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label11" runat="server" Text="L:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel11" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label12" runat="server" Text="M:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel12" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label13" runat="server" Text="N:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel13" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label14" runat="server" Text="O:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel14" runat="server"></asp:Label>
                </td>
                
<tr>
                <td class="style4">
                    <asp:Label ID="Label15" runat="server" Text="P:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel15" runat="server"></asp:Label>
                </td>
                
<tr>
                <td class="style4">
                    <asp:Label ID="Label16" runat="server" Text="Q:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel16" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label17" runat="server" Text="R:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel17" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label18" runat="server" Text="S:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel18" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label19" runat="server" Text="T:"></asp:Label>
                    </td>
                <td>
                    &nbsp;
                    <asp:Label ID="UnitLabel19" runat="server"></asp:Label>
                </td>
                
            </tr>
            </tr>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
