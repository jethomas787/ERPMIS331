<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierManagerDashboard.aspx.cs" Inherits="ERPProject.SupplierManagerDashboard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supply Manager Dashboard</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Welcome, Supply Manager</h2>
            <asp:Button ID="ButtonViewComponents" runat="server" Text="View Components" OnClick="ButtonViewComponents_Click" />
        </div>
    </form>
</body>
</html>