<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleSelection.aspx.cs" Inherits="ERPProject.RoleSelection" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Role</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            background: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        h2 {
            margin-bottom: 20px;
        }
        .role-button {
            background-color: #007BFF;
            color: white;
            border: none;
            border-radius: 5px;
            padding: 15px 20px;
            font-size: 16px;
            cursor: pointer;
            margin: 10px;
            transition: background-color 0.3s;
        }
        .role-button:hover {
            background-color: #0056b3;
        }
        .button-container {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Select Your Role</h2>
            <div class="button-container">
                <asp:Button ID="ButtonSupplyManager" runat="server" CssClass="role-button" Text="Supply Manager" OnClick="RoleButton_Click" CommandArgument="1" />
                <asp:Button ID="ButtonERPManager" runat="server" CssClass="role-button" Text="ERP Manager" OnClick="RoleButton_Click" CommandArgument="2" />
                <asp:Button ID="ButtonPurchasingManager" runat="server" CssClass="role-button" Text="Purchasing Manager" OnClick="RoleButton_Click" CommandArgument="3" />
                <asp:Button ID="ButtonWarehouseManager" runat="server" CssClass="role-button" Text="Warehouse Manager" OnClick="RoleButton_Click" CommandArgument="4" />
                <asp:Button ID="ButtonSalesManager" runat="server" CssClass="role-button" Text="Sales Manager" OnClick="RoleButton_Click" CommandArgument="5" />
            </div>
        </div>
    </form>
</body>
</html>