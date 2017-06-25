<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Challenge-DaysBetweenDates.aspx.cs" Inherits="MyFirstWebApp.Challenge_DaysBetweenDates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How many days have elapsed?<br />
            <br />
            Choose one date:<br />
            <asp:Calendar ID="dateOneCalendar" runat="server"></asp:Calendar>
            <br />
            Choose a second date:<br />
            <asp:Calendar ID="dateTwoCalendar" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            Elapsed Days: <asp:Label ID="elapsedDaysLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
