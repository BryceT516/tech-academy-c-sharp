<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CS-ASP_011.aspx.cs" Inherits="MyFirstWebApp.CS_ASP_011" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Is
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
            <br />
            <asp:CheckBox ID="firstCheckBox" runat="server" Text="Are you cool?" />
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" />
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="Go" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
