<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UploadFilesDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="ServerDemo.aspx">Server demo</asp:HyperLink>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">File to upload: </asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Upload" />
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:BulletedList DisplayMode="HyperLink" BulletStyle="Numbered" ID="BulletedList1" runat="server"></asp:BulletedList>
        </asp:Panel>
    </form>
</body>
</html>
