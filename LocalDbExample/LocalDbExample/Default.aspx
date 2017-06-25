<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LocalDbExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="customersGridView" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnRowCommand="customersGridView_RowCommand" OnSelectedIndexChanged="customersGridView_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="View" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            Address:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
            <br />
            City:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="cityTextBox" runat="server"></asp:TextBox>
            <br />
            State:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="stateTextBox" runat="server"></asp:TextBox>
            <br />
            Zip:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="postalCodeTextBox" runat="server"></asp:TextBox>
            <br />
            Notes:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="notesTextBox" runat="server" Height="80px" Rows="5" TextMode="MultiLine" Width="175px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="saveDataButton" runat="server" OnClick="Button1_Click" Text="Save Data" />
            <br />
        </div>
    </form>
</body>
</html>
