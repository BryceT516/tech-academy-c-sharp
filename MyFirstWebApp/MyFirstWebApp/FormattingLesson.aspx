<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormattingLesson.aspx.cs" Inherits="MyFirstWebApp.FormattingLesson" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Formatting Lesson page</title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
        .auto-style2 {
            width: 150px;
            height: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Head Line 1</h1>
        <h2>Head Line 2</h2>
        <h3>Head Line 3</h3>
        <h4>Head Line 4</h4>
        <h5>Head Line 5</h5>
        <h6>Head Line 6</h6>
        <p>This is some text that I want to <span class="auto-style1">apply</span> a style to.</p>
        <p><a href="http://www.brycetucker.net">Add a hyperlink</a></p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.brycetucker.net" Target="_blank">This is another hyperlink</asp:HyperLink>
        </p>
        <p>
            <img alt="" class="auto-style2" src="file:///C:/Users/Bryce%20Tucker/Pictures/Camera%20Roll/WIN_20160823_09_54_11_Pro-cropped-150px.jpg" /></p>
        <p>&nbsp;</p>
        <div>
        </div>
    </form>
</body>
</html>
