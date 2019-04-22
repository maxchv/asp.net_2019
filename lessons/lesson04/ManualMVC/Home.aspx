<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ManualMVC.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Home page</h1>
    <form id="form1" runat="server">
        <div>
            <%= GetRouteUrl(new {controller="Test", action="Index"}) %>
        </div>
    </form>
</body>
</html>
