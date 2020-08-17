<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connectedobjects.aspx.cs" Inherits="WebDataAcessConnected.Connectedobjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 869px;
        }
    </style>
</head>
<body style="height: 635px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" Height="168px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="292px">
        </asp:GridView>
        <br />
        EmpId&nbsp; <asp:TextBox ID="txtEmpId" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" BackColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        EmpName
        <asp:TextBox ID="txtEname" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        EmpSalary<asp:TextBox ID="txtEmpSal" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="SearchEmp" Height="26px" />
        <br />
        <br />
        <asp:Button ID="btnEmpDetails" runat="server" OnClick="btnEmpDetails_Click" Text="InsertEmpUsingQtn" Width="160px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdateWithPara" runat="server" OnClick="btnUpdateWithPara_Click" Text="UpdateWithParameters" style="margin-left: 15px" Width="206px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDeleteWithSp" runat="server" OnClick="btnDeleteWithSp_Click" Text="DeleteWithSp" Height="27px" style="margin-left: 0px" Width="158px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnInsertWithPara" runat="server" Height="25px" OnClick="btnInsertWithPara_Click" Text="InserWithParameters" Width="165px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdateEmp" runat="server" Height="23px" OnClick="btnUpdateEmp_Click" style="margin-left: 15px" Text="UpdateWithQtn" Width="208px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelWithPara" runat="server" Height="27px" OnClick="btnDelWithPara_Click" Text="DeleteWithParameters" Width="170px" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnLnsertSp" runat="server" OnClick="btnLnsertSp_Click" Text="InsertStoredProcedure" Width="166px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdateSp" runat="server" OnClick="btnUpdateSp_Click" style="margin-left: 13px" Text="UpdateWithStoredProcedure" Width="214px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelEmp" runat="server" OnClick="btnDelEmp_Click" Text="DeleteWithQtn" Width="167px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnShow" runat="server" Text="Disconnected" OnClick="btnShow_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
