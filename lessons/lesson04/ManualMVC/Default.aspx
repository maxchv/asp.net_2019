<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ManualMVC.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Request Url: <%= Request.Url %> <br/>
            Controller: <%= Page.RouteData.Values["controller"] %><br/>
            Action: <%= Page.RouteData.Values["action"] %><br/>
            Id: <%= Page.RouteData.Values["id"] %><br/>
        </div>
    </form>
</body>
</html>
