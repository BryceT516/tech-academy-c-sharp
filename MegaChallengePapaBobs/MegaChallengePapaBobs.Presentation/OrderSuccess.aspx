<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSuccess.aspx.cs" Inherits="MegaChallengePapaBobs.Presentation.OrderSuccesss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Papa Bob's Pizza - Order Success</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="page-header">
                <h1 class="text-primary">Success!</h1>
                <div class="lead">Your pizza is on the way...</div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="Default.aspx" class="btn btn-block btn-primary">Order Another Pizza?</a>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
