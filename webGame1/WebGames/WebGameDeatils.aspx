<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebGameDeatils.aspx.cs" Inherits="WebGames.WebGameDeatils" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Cricket" />
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Tennis Players" />
        <asp:Panel ID="Panel1" runat="server" Height="145px" Width="1251px">
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Htmlsachin.html">Sachin</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/HtmlDhoni.html">Dhoni</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/HtmlGambhir.html">Ghambir</asp:HyperLink>
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" style="margin-right: 39px">
            <br />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/HtmlSerena.html">Serena</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/HtmlMahesh.html">Mahesh</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/HtmlSania.html">Sania</asp:HyperLink>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
