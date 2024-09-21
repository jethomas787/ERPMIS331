<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PurchasingManager.aspx.cs" Inherits="ERPProject.PurchasingManager" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Purchasing Manager Dashboard</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 20px;
        }
        .container {
            background-color: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            max-width: 600px;
            margin: auto;
        }
        h2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Welcome, Purchasing Manager</h2>
            <asp:Button ID="ButtonOrderBurger" runat="server" Text="Order Burger" OnClick="ButtonOrderBurger_Click" />
        </div>
    </form>
</body>
</html>