<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebAppExplore12_08_2020.aspx.cs" Inherits="WebAppExplore12_08_2020.WebAppExplore12_08_2020" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="24px" Width="132px"></asp:ListBox>
        <br />
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
        </asp:RadioButtonList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" Font-Names="Onyx" Height="28px" Width="65px">
        </asp:CheckBoxList>
        <br />
        <br />
    </form>
    
</body>
</html>
