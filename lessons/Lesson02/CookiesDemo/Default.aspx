<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CookiesDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListBox ID="ListBox1" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_OnSelectedIndexChanged" runat="server"></asp:ListBox>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_OnSelectedIndexChanged"></asp:DropDownList>
            <asp:Label runat="server" ID="Label1"></asp:Label>
            <asp:CheckBox AutoPostBack="True" OnCheckedChanged="CheckBox1_OnCheckedChanged" 
                          ID="CheckBox1" Text="Touch me" runat="server" />
            <asp:Panel runat="server">
                <asp:Label runat="server" ID="Label2"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
