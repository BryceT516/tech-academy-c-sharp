<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="MyFirstChallenge.aspx">First Challenge</a>&nbsp;&nbsp;|&nbsp; <a href="FormattingLesson.aspx">Formatting Lesson</a>&nbsp; |&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CS-ASP_008.aspx">CS-ASP_008</asp:HyperLink>
&nbsp; |&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/CS-ASP_010.aspx">CS-ASP_010</asp:HyperLink>
        </div>
        <div>

            <br />

            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" >
                <asp:ListItem Value="Default.aspx">Select Page</asp:ListItem>
                <asp:ListItem Value="CS-ASP_008.aspx">CS-ASP_008</asp:ListItem>
                <asp:ListItem Value="CS-ASP_010.aspx">CS-ASP_010</asp:ListItem>
                <asp:ListItem Value="CS-ASP_011.aspx">CS-ASP_011</asp:ListItem>
                <asp:ListItem Value="CS-ASP_012.aspx">CS-ASP_012</asp:ListItem>
                <asp:ListItem Value="BootstrapOne.aspx">BootstrapOne</asp:ListItem>
                <asp:ListItem Value="MyFirstChallenge.aspx">MyFirstChallenge</asp:ListItem>
                <asp:ListItem Value="PapaBobsOne.aspx">Papa Bob&#39;s 1</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go" />
            <br />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>
            <br />
            <br />
            <br />
            <br />

            What is your first name?&nbsp;
            <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            What is your last name?&nbsp;
            <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Click Me" />
&nbsp;
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
