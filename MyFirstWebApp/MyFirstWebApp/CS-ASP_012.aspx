<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CS-ASP_012.aspx.cs" Inherits="MyFirstWebApp.CS_ASP_012" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your note taking preferences:<br />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="noteOptions" Text="Pencil" />
            <br />
            <asp:RadioButton ID="penRadioButton" runat="server" GroupName="noteOptions" Text="Pen" />
            <br />
            <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="noteOptions" Text="Phone" />
            <br />
            <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="noteOptions" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Ok" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <asp:Image ID="resultImage" runat="server" Height="300px" Width="300px" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
