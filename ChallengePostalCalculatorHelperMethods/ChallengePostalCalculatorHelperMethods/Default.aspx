<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    

    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
    </style>
    

</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Cost Calculator<br />
            <br />
            Height:
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="OnChange"></asp:TextBox>
            <span class="auto-style1">*</span><br />
            Width:
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="OnChange"></asp:TextBox>
            <span class="auto-style1">*</span><br />
            Length:
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="OnChange"></asp:TextBox>
            <br />
            <br />
            Select Shipping Method:<br />
            <asp:RadioButton ID="shippingGroundRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="OnChange" Text="Ground" />
            <br />
            <asp:RadioButton ID="shippingAirRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="OnChange" Text="Air" />
            <br />
            <asp:RadioButton ID="shippingNextDayRadioButton" runat="server" AutoPostBack="True" GroupName="shipping" OnCheckedChanged="OnChange" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
