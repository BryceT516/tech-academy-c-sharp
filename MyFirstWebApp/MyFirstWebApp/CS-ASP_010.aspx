<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CS-ASP_010.aspx.cs" Inherits="MyFirstWebApp.CS_ASP_010" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Calculator</h1>
            <p>
                <span class="newStyle1">First Value:</span>&nbsp;
                <asp:TextBox ID="firstValueTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <span class="newStyle1">Second Value:</span> <asp:TextBox ID="secondValueTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="addButton" runat="server" OnClick="Button1_Click" Text="+" />
&nbsp;
                <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" Width="18px" />
&nbsp;
                <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="x" />
&nbsp;
                <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
            </p>
            <p>
                <asp:Label ID="resultLabel" runat="server" Font-Names="Haettenschweiler" Font-Size="X-Large" Font-Underline="True" ForeColor="#0066FF"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
