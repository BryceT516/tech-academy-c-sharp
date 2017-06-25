<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderManagement.aspx.cs" Inherits="MegaChallengePapaBobs.Presentation.OrderManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Papa Bob's Pizza: Orders</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="page-header"><h1 class="text-primary">Order Management</h1></div>
            <div class="row">
                <div class="col-sm-12">
                    <asp:GridView ID="ordersGridView" runat="server" OnRowCommand="ordersGridView_RowCommand" OnRowUpdating="ordersGridView_RowUpdating" OnSelectedIndexChanged="ordersGridView_SelectedIndexChanged" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:ButtonField CommandName="Update" Text="Finished" />
                        </Columns>
                        <FooterStyle BackColor="#CCCC99" />                        
                        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />                        
                        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                        <RowStyle BackColor="#F7F7DE" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FBFBF2" />
                        <SortedAscendingHeaderStyle BackColor="#848384" />
                        <SortedDescendingCellStyle BackColor="#EAEAD3" />
                        <SortedDescendingHeaderStyle BackColor="#575357" />
                    </asp:GridView>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <a href="Default.aspx">Ordering Page</a>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
