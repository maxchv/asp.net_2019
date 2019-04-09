<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" 
         Inherits="EmptyWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br/>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Дата" OnClick="Button1_OnClick" />
        </div>
    </form>
</body>
</html>
