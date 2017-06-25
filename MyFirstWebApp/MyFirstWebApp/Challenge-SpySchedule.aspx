<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Challenge-SpySchedule.aspx.cs" Inherits="MyFirstWebApp.Challenge_SpySchedule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Epic Spies Scheduling Tool</title>
    <style type="text/css">
        .auto-style1 {
            width: 163px;
            height: 201px;
        }
    </style>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="col-md-2">
                <img alt="Epic Spies Logo" class="auto-style1" src="Images/epic-spies-logo.jpg" />
            </div>
            <div class="col-md-10">
                <asp:Label ID="resultsLabel" runat="server"></asp:Label>
                <h2>Spy New Assignment Form</h2>
                <p>Spy Code Name:
                    <asp:TextBox ID="spyNameTextBox" runat="server" Width="239px"></asp:TextBox>
                </p>
                <p>Assignment Code Name:
                    <asp:TextBox ID="assignmentNameTextBox" runat="server" Width="256px" ></asp:TextBox>
                </p>
                <p>Prior Assignment End Date:<br />
                    <asp:Calendar ID="oldAssignmentEndCalendar" runat="server"></asp:Calendar>
                </p>
                <p>New Assignment Start Date:<asp:Calendar ID="newAssignementStartCalendar" runat="server"></asp:Calendar>
                </p>
                <p>Projected End Date of New Assignment:<asp:Calendar ID="newAssignmentEndCalendar" runat="server"></asp:Calendar>
                </p>
                <p>
                    <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
                </p>

            </div>


        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
</body>
</html>
