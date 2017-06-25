<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeHeroMonsterClassesPart1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Challenge Hero Monster Classes Part 1</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-1">
                    &nbsp;
                </div>
                <div class="col-md-4">
                    <div class="well">
                        <h2 class="text-center">HERO:
                            <asp:Label ID="heroNameLabel" runat="server"></asp:Label>
                        </h2>
                        <hr />
                        <h3 class="text-left">Health: <span class="text-primary">
                            <asp:Label ID="heroHealthLabel" runat="server"></asp:Label></span></h3>
                    </div>
                </div>
                <div class="col-md-1">
                    &nbsp;
                </div>
                <div class="col-md-4">
                    <div class="well">
                        <h2 class="text-center">MONSTER:
                            <asp:Label ID="monsterNameLabel" runat="server"></asp:Label>
                        </h2>
                        <hr />
                        <h3 class="text-left">Health: <span class="text-primary">
                            <asp:Label ID="monsterHealthLabel" runat="server"></asp:Label></span></h3>
                    </div>
                </div>
                <div class="col-md-2">
                    &nbsp;
                </div>
            </div>
            <div class="row">
                <div class="col-md-1">
                    &nbsp;
                </div>
                <div class="col-md-9 text-center">
                    <asp:Button ID="battleButton" runat="server" Text="BATTLE!" class="btn btn-primary" OnClick="battleButton_Click"/>
                </div>
                <div class="col-md-2">
                    &nbsp;
                </div>
            </div>
            <div class="row">
                <div class="text-left text-info col-md-12">
                    <asp:Label ID="battleExchangeLabel" runat="server"></asp:Label>
                </div>
            </div>
            
        </div>

    </form>

    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
