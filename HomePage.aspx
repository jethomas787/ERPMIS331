<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ERPProject.HomePage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome, <asp:Label ID="LabelUserName" runat="server"></asp:Label></h2>
            <h3>Admin Dashboard</h3>
            <ul>
                <li><a href="SystemInformation.aspx">System Information</a></li>
                <li><a href="OrderProduct.aspx">Order Product</a></li>
                <li><asp:Button ID="ButtonPurchase" runat="server" Text="Purchase Products" OnClick="ButtonPurchase_Click" /></li>
            </ul>
            <asp:Button ID="ButtonLogout" runat="server" Text="Logout" OnClick="ButtonLogout_Click" />
        </div>
    </form>
</body>
</html>