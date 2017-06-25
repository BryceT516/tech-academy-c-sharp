<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CS-ASP_053.aspx.cs" Inherits="MyFirstWebApp.CS_ASP_053" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="NoneSelected">Select a Character Type</asp:ListItem>
                <asp:ListItem>Fighter</asp:ListItem>
                <asp:ListItem>Wizard</asp:ListItem>
                <asp:ListItem>Thief</asp:ListItem>
                <asp:ListItem>Cleric</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
