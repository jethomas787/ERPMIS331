<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderBurger.aspx.cs" Inherits="ERPProject.OrderBurger" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Burger</title>
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
        }
        h2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Order a Burger</h2>
            <asp:Label ID="LabelBurgerPrice" runat="server" Text="Burger Price: $5.00"></asp:Label><br /><br />
            <asp:TextBox ID="TextBoxQuantity" runat="server" placeholder="Enter quantity" /><br /><br />
            <asp:Button ID="ButtonOrder" runat="server" Text="Order" OnClick="ButtonOrder_Click" /><br /><br />
            <asp:Label ID="LabelTotal" runat="server" Text="" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>