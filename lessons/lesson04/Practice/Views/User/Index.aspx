<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Practice.Views.User.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>User Index page</h1>
    <form id="form1" runat="server">
        <p>
            <a href="<%= GetRouteUrl(new{controller="User", action = "List"}) %>">
                Users list page
            </a>
        </p>
        <p>
            <a href="<%= GetRouteUrl(new{controller="User", action = "Add"}) %>">
                Add User page
            </a>
        </p>
    </form>
</body>
</html>
