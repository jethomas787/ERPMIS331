<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ERPManagerDashboard.aspx.cs" Inherits="ERPProject.ERPManagerDashboard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ERP Manager Dashboard</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            background: #ffffff; /* Full white background */
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            width: 100%; /* Full width */
        }
        h2 {
            margin-bottom: 20px;
        }
        .button {
            background-color: #007BFF;
            color: white;
            border: none;
            border-radius: 5px;
            padding: 10px 15px;
            font-size: 16px;
            cursor: pointer;
            margin: 10px;
            transition: background-color 0.3s;
        }
        .button:hover {
            background-color: #0056b3;
        }
        .grid-view {
            margin-top: 20px;
            width: 100%;
            max-height: 300px; /* Limit the height of the GridView */
            overflow: auto; /* Add scroll if content overflows */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Welcome, ERP Manager</h2>
            <asp:Button ID="ButtonViewComponents" runat="server" Text="View Components" CssClass="button" OnClick="ButtonViewComponents_Click" />
            <asp:Button ID="ButtonViewInventory" runat="server" Text="View Inventory" CssClass="button" OnClick="ButtonViewInventory_Click" />
            <asp:Button ID="ButtonViewProducts" runat="server" Text="View Products" CssClass="button" OnClick="ButtonViewProducts_Click" />
            <asp:Button ID="ButtonViewPurchases" runat="server" Text="View Purchases" CssClass="button" OnClick="ButtonViewPurchases_Click" />
            <asp:Button ID="ButtonViewUsers" runat="server" Text="View Users" CssClass="button" OnClick="ButtonViewUsers_Click" />
            
            <asp:GridView ID="GridViewData" runat="server" CssClass="grid-view" AutoGenerateColumns="True" />
        </div>
    </form>
</body>
</html>