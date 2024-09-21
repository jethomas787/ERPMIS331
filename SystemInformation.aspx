<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SystemInformation.aspx.cs" Inherits="ERPProject.SystemInformation" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>System Information</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>System Information</h2>
            <h3>Select an option:</h3>
            <asp:Button ID="ButtonComponents" runat="server" Text="Components" OnClick="ButtonComponents_Click" />
            <asp:Button ID="ButtonInventory" runat="server" Text="Inventory" OnClick="ButtonInventory_Click" />
            <asp:Button ID="ButtonProducts" runat="server" Text="Products" OnClick="ButtonProducts_Click" />
        </div>
    </form>
</body>
</html>
