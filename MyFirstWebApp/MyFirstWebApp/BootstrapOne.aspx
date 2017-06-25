<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BootstrapOne.aspx.cs" Inherits="MyFirstWebApp.BootstrapOne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trying out Bootstrap</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="jumbotron">
                <h1 class="text-center">Bootstrap Page</h1>
            </div>
            <div class="container-fluid">
                <div class="col-sm-4">
                    <h2 class="text-center">Section 1</h2>
                </div>
                <div class="col-sm-4">
                    <div class="well">
                        <h2 class="text-center">Section 2</h2>
                        <p class="text-center">
                            <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; font-size: x-large; text-decoration: underline"></asp:Label>
                        </p>
                    </div>
                </div>
                <div class="col-sm-4">
                    <div class="container">
                        <h2 class="text-center">Section 3</h2>
                        <p>What is your first name?&nbsp;  
                            <asp:TextBox ID="firstNameTextBox" runat="server" Width="170px"></asp:TextBox>
                        </p>
                        <p>What is your last name?&nbsp;
                            <asp:TextBox ID="lastNameTextBox" runat="server" Width="170px"></asp:TextBox>
                        </p>
                        <p>
                            <asp:Button ID="okButton" runat="server" Text="Click Me" CssClass="btn btn-default" OnClick="okButton_Click" />
                        </p>
                    </div>
                </div>
            </div>

        </div>
    </form>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
