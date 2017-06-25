<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CS-ASP_035.aspx.cs" Inherits="MyFirstWebApp.CS_ASP_035" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="challengeOneButton" runat="server" OnClick="challengeOneButton_Click" Text="Challenge 1" />
&nbsp;
            <asp:Label ID="challengeOneLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="challengeTwoButton" runat="server" OnClick="challengeTwoButton_Click" Text="Challenge 2" />
&nbsp;
            <asp:Label ID="challengeTwoLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="challengeThreeButton" runat="server" OnClick="challengeThreeButton_Click" Text="Challenge 3" />
&nbsp;
            <asp:Label ID="challengeThreeLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="challengeFourButton" runat="server" OnClick="challengeFourButton_Click" Text="Challenge 4" />
            <br />
            <br />
            <asp:Label ID="challengeFourLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
