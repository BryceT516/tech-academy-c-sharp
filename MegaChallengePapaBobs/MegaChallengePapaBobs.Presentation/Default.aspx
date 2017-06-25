<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaChallengePapaBobs.Presentation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Papa Bob's Pizza: Ordering Page</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="page-header">
                <h1 class="text-primary">Papa Bob's Pizza</h1>
                <div class="lead">Pizza to code by...</div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="well">
                        <h3 class="text-primary">Pizza:</h3>
                        <div class="form-group">
                            <div class="label-info">Size:</div>
                            <asp:DropDownList ID="sizeDropDownList" runat="server" CssClass="form-control" AutoPostBack="True">
                                <asp:ListItem Value="Small">Small (12 inches - $12)</asp:ListItem>
                                <asp:ListItem Value="Medium">Medium (14 inches - $14)</asp:ListItem>
                                <asp:ListItem Value="Large">Large (16 inches - $16)</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <div class="label-info">Crust:</div>
                            <asp:DropDownList ID="crustDropDownList" runat="server" CssClass="form-control" AutoPostBack="True">
                                <asp:ListItem Value="Regular">Regular</asp:ListItem>
                                <asp:ListItem Value="Thin">Thin</asp:ListItem>
                                <asp:ListItem Value="Thick">Thick (+ $2)</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <div class="label-info">Toppings:</div>
                            <asp:CheckBox ID="sausageCheckBox" runat="server" CssClass="form-control" AutoPostBack="True" Text="Sausage (+ $2)" />
                            <asp:CheckBox ID="pepperoniCheckBox" runat="server" CssClass="form-control" AutoPostBack="True" Text="Pepperoni (+ $1.50)" />
                            <asp:CheckBox ID="onionsCheckBox" runat="server" CssClass="form-control" AutoPostBack="True" Text="Onions (+ $1)" />
                            <asp:CheckBox ID="greenPeppersCheckBox" runat="server" CssClass="form-control" AutoPostBack="True" Text="Green Peppers (+ $1)" />

                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="well">
                        <h3 class="text-primary">Order Info:</h3>
                        <div class="form-group">
                            <div class="label-info">Name:</div>
                            <asp:TextBox ID="nameTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <div class="label-info">Address:</div>
                            <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <div class="label-info">Zip Code:</div>
                            <asp:TextBox ID="zipCodeTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <div class="label-info">Phone:</div>
                            <asp:TextBox ID="phoneTextBox" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-6">
                    <div class="well">
                        <h3 class="text-primary">Total Cost:</h3>
                        <h3 class="text-info">
                            <asp:Label ID="totalCostLabel" runat="server"></asp:Label>
                        </h3>
                    </div>
                </div>
                <div class="col-sm-6">
                    <div class="well">
                        <h3 class="text-primary">Payment:</h3>
                        <div class="form-group">
                            <div class="label-info">Payment Type:</div>
                            <asp:RadioButton ID="cashRadioButton" runat="server" GroupName="paymentType" Text="Cash" />
                            <br />
                            <asp:RadioButton ID="creditRadioButton" runat="server" GroupName="paymentType" Text="Credit" Checked="True" />
                        </div>
                        <asp:Label ID="errorLabel" runat="server" CssClass="label-danger"></asp:Label>
                        <div class="form-group">
                            <asp:Button ID="placeOrderButton" runat="server" Text="Place Order" CssClass="btn btn-block btn-primary" OnClick="placeOrderButton_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
