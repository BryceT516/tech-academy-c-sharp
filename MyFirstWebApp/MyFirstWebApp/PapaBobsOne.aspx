<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PapaBobsOne.aspx.cs" Inherits="MyFirstWebApp.PapaBobsOne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="jumbotron">
            <h1>Papa Bob's Pizza</h1>
        </div>
        <div class="container-fluid">
            <div class="col-md-1">
                &nbsp;
            </div>
            <div class="col-md-5">
                <div class="container text-center text-primary">
                    <h3>Build Your Pizza:</h3>
                    <div class="container text-left">
                        <p>
                            <asp:RadioButton ID="sizeBabyRadioButton" runat="server" GroupName="sizeChoice" OnCheckedChanged="sizeBabyRadioButton_CheckedChanged" Text="Baby Bob Size (10&quot;) - $10" />
                        </p>
                        <p>
                            <asp:RadioButton ID="sizeMamaRadioButton" runat="server" GroupName="sizeChoice" OnCheckedChanged="sizeMamaRadioButton_CheckedChanged" Text="Mama Bob Size (13&quot;) - $13" />
                        </p>
                        <p>
                            <asp:RadioButton ID="sizePapaRadioButton" runat="server" GroupName="sizeChoice" OnCheckedChanged="sizePapaRadioButton_CheckedChanged" Text="Papa Bob Size (16&quot;) - $16" />
                        </p>
                        <p>
                            &nbsp;</p>
                        <p>
                            <asp:RadioButton ID="crustThinRadioButton" runat="server" GroupName="crustChoice" OnCheckedChanged="crustThinRadioButton_CheckedChanged" Text="Thin Crust" />
                        </p>
                        <p>
                            <asp:RadioButton ID="crustThickRadioButton" runat="server" GroupName="crustChoice" OnCheckedChanged="crustThickRadioButton_CheckedChanged" Text="Deep Dish (+ $2)" />
                        </p>
                        <p>
                            &nbsp;</p>
                        <p>
                            <asp:CheckBox ID="ingPepperoniCheckBox" runat="server" OnCheckedChanged="ingPepperoniCheckBox_CheckedChanged" Text="Pepperoni (+ $1.50)" />
                        </p>
                        <p>
                            <asp:CheckBox ID="ingOnionsCheckBox" runat="server" OnCheckedChanged="ingOnionsCheckBox_CheckedChanged" Text="Onions (+ $0.75)" />
                        </p>
                        <p>
                            <asp:CheckBox ID="ingGreenPeppersCheckBox" runat="server" OnCheckedChanged="ingGreenPeppersCheckBox_CheckedChanged" Text="Green Peppers (+ $0.50)" />
                        </p>
                        <p>
                            <asp:CheckBox ID="ingRedPeppersCheckBox" runat="server" OnCheckedChanged="ingRedPeppersCheckBox_CheckedChanged" Text="Red Peppers (+ $0.75)" />
                        </p>
                        <p>
                            <asp:CheckBox ID="ingAnchoviesCheckBox" runat="server" OnCheckedChanged="ingAnchoviesCheckBox_CheckedChanged" Text="Anchovies (+ $2)" />
                        </p>
                        <p>
                            &nbsp;</p>
                        <h3>
                            Papa Bob&#39;s <span class="auto-style1">Special Deal</span>:</h3>
                        <p>
                            Save $2.00 when you add Perpperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.</p>
                    </div>
                    
                </div>
            </div>
            <div class="col-md-1">
                &nbsp;
            </div>
            <div class="col-md-4">
                <div class="container text-center text-info">
                    <h3>Your order:</h3>
                    <p>
                        <asp:Label ID="orderLabel" runat="server"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label3" runat="server" Text="Order Total: $"></asp:Label>
                        <asp:Label ID="orderTotalLabel" runat="server"></asp:Label>
                    </p>
                    <p>
                        <asp:Button ID="purchaseButton" runat="server" Text="Purchase" />
                    </p>
                </div>
            </div>
            <div class="col-md-1">
                &nbsp;
            </div>
        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
</body>
</html>
