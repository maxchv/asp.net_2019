<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Practice.Views.Home.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Home page</h1>
    <form id="form1" runat="server">
        <p>
            <a href="<%= GetRouteUrl(new{controller="User", action = "Index"}) %>">
                Users index page
            </a>
        </p>
    </form>
</body>
</html>
