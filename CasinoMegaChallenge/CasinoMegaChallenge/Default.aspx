<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CasinoMegaChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mega Challenge Casino</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="jumbotron text-center">

                <asp:Image ID="cellOneImage" runat="server" Height="200px" Width="200px" ImageUrl="~/Images/Plum.png" />
                &nbsp;<asp:Image ID="cellTwoImage" runat="server" Height="200px" Width="200px" ImageUrl="~/Images/Clover.png" />

            &nbsp;<asp:Image ID="cellThreeImage" runat="server" Height="200px" Width="200px" ImageUrl="~/Images/HorseShoe.png" />

            </div>
            <hr />
            <div class="row">
                <div class="col-md-2">
                    &nbsp;
                </div>
                <div class="col-md-4 text-center">
                    Your Bet: 
                <asp:TextBox ID="betInputTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-4 text-center">
                    Balance: 
                <asp:Label ID="balanceLabel" runat="server"></asp:Label>
                </div>
                <div class="col-md-2">
                    &nbsp;
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    &nbsp;
                </div>
                <div class="col-md-4 text-center">
                    <asp:Button ID="leverButton" runat="server" Text="Pull The Lever!" CssClass="btn btn-success" OnClick="leverButton_Click" />
                </div>
                <div class="col-md-4">
                    &nbsp;
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    &nbsp;
                </div>
                <div class="col-md-4">
                    
                    <asp:Label ID="resultLabel" runat="server"></asp:Label>
                    
                </div>
                <div class="col-md-4">
                    &nbsp;
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-md-4">
                    &nbsp;
                </div>
                <div class="col-md-4 text-center">
                    <p>1 Cherry - x2 Your Bet</p>
                    <p>2 Cherries - x3 Your bet</p>
                    <p>3 Cherries - x4 Your Bet</p>
                    <p>3 7&#39;s = Jackpot - x100 Your Bet</p>
                    <p>HOWEVER</p>
                    <p>If there&#39;s even one BAR you win nothing.</p>
                </div>
                <div class="col-md-4">
                    &nbsp;
                </div>
            </div>
           
        </div>
    </form>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
